using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Core.Services
{
    public class VeterinarianService : ServiceBase<Veterinarian>, IVeterinarianService
    {
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly IConsultationRepository _consultationRepository;
        private readonly IPracticeRepository _practiceRepository;
        private readonly IFileService _fileService;

        public VeterinarianService(IVeterinarianRepository veterinarianRepository, 
            ISpecialtyRepository specialtyRepository,
            IConsultationRepository consultationRepository,
            IPracticeRepository practiceRepository,
            IFileService fileService) : base(veterinarianRepository)
        {
            _specialtyRepository = specialtyRepository;
            _consultationRepository = consultationRepository;
            _practiceRepository = practiceRepository;
            _fileService = fileService;
        }

        public async Task<ResultModel<Veterinarian>> SearchByNameAsync(string name)
        {
            var vets = await _repository.SearchByNameAsync(name);

            if (vets.Count() == 0)
                return vets.ToErrorModel(Constants.NoVeterinarianFoundMessage);

            return vets.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> GetSpecialtiesFromVeterinariansAsync(int id)
        {
            var specialties = await _specialtyRepository.GetAllAsync();

            var specialtiesByVets = specialties.Where(s => s.Veterinarians.Any(v => v.Id == id));

            if (specialtiesByVets.Count() == 0)
                return specialtiesByVets.ToErrorModel(Constants.NoSpecialtyFoundMessage);

            return specialtiesByVets.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> GetConsultationsFromVeterinariansAsync(int id)
        {
            var consultations = await _consultationRepository.GetAllAsync();

            var consultationsByVets = consultations.Where(c => c.VeterinarianId.Equals(id));

            if (consultationsByVets.Count() == 0)
                return consultationsByVets.ToErrorModel(Constants.NoConsultationFoundMessage);

            return consultationsByVets.ToResultModel();
        }

        public async Task<ResultModel<Practice>> GetPracticesFromVeterinariansAsync(int id)
        {
            var practices = await _practiceRepository.GetAllAsync();

            var practicesByVet = practices.Where(s => s.Veterinarians.Any(v => v.Id == id));

            if (practicesByVet.Count() == 0)
                return practicesByVet.ToErrorModel(Constants.NoPracticeFoundMessage);

            return practicesByVet.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel)
        {
            var vets = _repository.GetAll();

            var veterinarianToAdd = new Veterinarian();

            string idSetSuccessMessage = SetIds(veterinarianToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return veterinarianToAdd.ToErrorModel(idSetSuccessMessage);

            string nameSetSuccessMessage = SetName(veterinarianToAdd, addModel);
            if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                return veterinarianToAdd.ToErrorModel(nameSetSuccessMessage);

            if (!addModel.Birth.CheckFutureDate())
                return veterinarianToAdd.ToErrorModel(Constants.FutureDateMessage);

            var imageSetSuccess = SetImage(veterinarianToAdd, addModel);
            if (!string.IsNullOrEmpty(imageSetSuccess.Result))
                return veterinarianToAdd.ToErrorModel(imageSetSuccess.Result);

            veterinarianToAdd.MapEntity(addModel);

            if (!await _repository.CreateAsync(veterinarianToAdd))
                return veterinarianToAdd.ToErrorModel(Constants.DBCreateMessage);

            return veterinarianToAdd.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel)
        {
            var vets = _repository.GetAll();

            var veterinarianToUpdate = await _repository.GetByIdAsync(updateModel.Id);

            if (veterinarianToUpdate == null)
                return veterinarianToUpdate.ToErrorModel(Constants.NoVeterinarianFoundMessage);

            string idSetSuccessMessage = SetIds(veterinarianToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return veterinarianToUpdate.ToErrorModel(idSetSuccessMessage);

            if (!updateModel.Birth.CheckFutureDate())
                return veterinarianToUpdate.ToErrorModel(Constants.FutureDateMessage);

            if (veterinarianToUpdate.FirstName.ToUpper() != updateModel.FirstName.ToUpper() && 
                veterinarianToUpdate.LastName.ToUpper() != updateModel.LastName.ToUpper())
            {
                string nameSetSuccessMessage = SetName(veterinarianToUpdate, updateModel);
                if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                    return veterinarianToUpdate.ToErrorModel(nameSetSuccessMessage);
            }

            var imageSetSuccess = SetImage(veterinarianToUpdate, updateModel);
            if (!string.IsNullOrEmpty(imageSetSuccess.Result))
                return veterinarianToUpdate.ToErrorModel(imageSetSuccess.Result);

            veterinarianToUpdate.MapEntity(updateModel);

            if (!await _repository.UpdateAsync(veterinarianToUpdate))
                return veterinarianToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return veterinarianToUpdate.ToResultModel();
        }

        private string SetIds(Veterinarian vet, VeterinarianAddModel model)
        {
            var specialties = _specialtyRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var practices = _practiceRepository.GetAll();

            var modelSpecialtyIds = model.SpecialtyIds ?? new List<int>();
            var modelConsultationIds = model.ConsultationIds ?? new List<int>();
            var modelPracticeIds = model.PracticeIds ?? new List<int>();

            // Input checks
            if (!specialties.CheckIfIdsExist(modelSpecialtyIds))
                return Constants.UnknownSpecialtyMessage;
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return Constants.UnknownConsultationMessage;
            if (!practices.CheckIfIdsExist(modelPracticeIds))
                return Constants.UnknownPracticeMessage;

            if (!specialties.CheckIdsInput(modelSpecialtyIds))
                return Constants.NoSpecialtyMessage;
            if (!consultations.CheckIdsInput(modelConsultationIds))
                return Constants.NoConsultationMessage;
            if (!practices.CheckIdsInput(modelPracticeIds))
                return Constants.NoPracticeMessage;

            var specialtiesToLink = specialties.Where(v => modelSpecialtyIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(v => modelConsultationIds.Contains(v.Id)).ToList();
            var practicesToLink = practices.Where(v => modelPracticeIds.Contains(v.Id)).ToList();

            vet.Specialties = specialtiesToLink;
            vet.Consultations = consultationsToLink;
            vet.Practices = practicesToLink;

            return string.Empty;
        }

        private string SetName(Veterinarian vet, VeterinarianAddModel model)
        {
            var vets = _repository.GetAll();

            if (vets.Any(m => m.FirstName.ToUpper().Equals(model.FirstName.ToUpper())
                    && m.LastName.ToUpper().Equals(model.LastName.ToUpper())))
                return Constants.NameExistsMessage;

            vet.FirstName = model.FirstName;
            vet.LastName = model.LastName;
            return string.Empty;
        }

        private async Task<string> SetImage(Veterinarian vet, VeterinarianAddModel model)
        {
            if (model.Image is null)
                return string.Empty;

            var imageResult = await _fileService.StoreFile<Veterinarian>(model.Image, "VeterinarianImages");
            if (!imageResult.IsSuccess)
                return imageResult.Error;

            vet.ImageFile = imageResult.FileName;
            return string.Empty;
        }
    }
}
