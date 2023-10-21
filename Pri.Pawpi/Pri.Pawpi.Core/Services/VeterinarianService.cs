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

        public VeterinarianService(IVeterinarianRepository veterinarianRepository, 
            ISpecialtyRepository specialtyRepository, 
            IConsultationRepository consultationRepository,
            IPracticeRepository practiceRepository) : base(veterinarianRepository)
        {
            _specialtyRepository = specialtyRepository;
            _consultationRepository = consultationRepository;
            _practiceRepository = practiceRepository;
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

            var specialties = _specialtyRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var practices = _practiceRepository.GetAll();
            
            var modelSpecialtyIds = addModel.SpecialtyIds;
            var modelConsultationIds = addModel.ConsultationIds;
            var modelPracticeIds = addModel.PracticeIds;

            var veterinarianToAdd = new Veterinarian();

            // Input checks
            if (!specialties.CheckIfIdsExist(modelSpecialtyIds))
                return veterinarianToAdd.ToErrorModel(Constants.UnknownSpecialtyMessage);
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return veterinarianToAdd.ToErrorModel(Constants.UnknownConsultationMessage);
            if (!practices.CheckIfIdsExist(modelPracticeIds))
                return veterinarianToAdd.ToErrorModel(Constants.UnknownPracticeMessage);

            if (!specialties.CheckIdsInput(modelSpecialtyIds))
                return veterinarianToAdd.ToErrorModel(Constants.NoSpecialtyMessage);
            if (!practices.CheckIdsInput(modelPracticeIds))
                return veterinarianToAdd.ToErrorModel(Constants.NoPracticeMessage);

            if (vets.Any(m => m.FirstName.ToUpper().Equals(addModel.FirstName.ToUpper())
                                && m.LastName.ToUpper().Equals(addModel.LastName.ToUpper())))
                return veterinarianToAdd.ToErrorModel(Constants.NameExistsMessage);

            if (addModel.Birth >= DateTime.Now)
                return veterinarianToAdd.ToErrorModel(Constants.FutureDateMessage);

            // Get ids to attach as entities
            var specialtiesToLink = specialties.Where(v => modelSpecialtyIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(v => modelConsultationIds.Contains(v.Id)).ToList();
            var practicesToLink = practices.Where(v => modelPracticeIds.Contains(v.Id)).ToList();

            // Update new veterinarian entity
            veterinarianToAdd.MapEntity(addModel);
            veterinarianToAdd.Specialties = specialtiesToLink;
            veterinarianToAdd.Consultations = consultationsToLink;
            veterinarianToAdd.Practices = practicesToLink;


            if (!await _repository.CreateAsync(veterinarianToAdd))
                return veterinarianToAdd.ToErrorModel(Constants.DBCreateMessage);

            return veterinarianToAdd.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel)
        {
            var vets = _repository.GetAll();

            var specialties = _specialtyRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var practices = _practiceRepository.GetAll();

            var modelSpecialtyIds = updateModel.SpecialtyIds;
            var modelConsultationIds = updateModel.ConsultationIds;
            var modelPracticeIds = updateModel.PracticeIds;

            var veterinarianToUpdate = await _repository.GetByIdAsync(updateModel.Id);

            if (veterinarianToUpdate == null)
                return veterinarianToUpdate.ToErrorModel(Constants.NoVeterinarianFoundMessage);

            // Input checks
            if (!specialties.CheckIfIdsExist(modelSpecialtyIds))
                return veterinarianToUpdate.ToErrorModel(Constants.UnknownSpecialtyMessage);
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return veterinarianToUpdate.ToErrorModel(Constants.UnknownConsultationMessage);
            if (!practices.CheckIfIdsExist(modelPracticeIds))
                return veterinarianToUpdate.ToErrorModel(Constants.UnknownPracticeMessage);

            if (!specialties.CheckIdsInput(modelSpecialtyIds))
                return veterinarianToUpdate.ToErrorModel(Constants.NoSpecialtyMessage);
            if (!practices.CheckIdsInput(modelPracticeIds))
                return veterinarianToUpdate.ToErrorModel(Constants.NoPracticeMessage);

            if (updateModel.Birth >= DateTime.Now)
                return veterinarianToUpdate.ToErrorModel(Constants.FutureDateMessage);

            if (veterinarianToUpdate.FirstName.ToUpper() != updateModel.FirstName.ToUpper() && 
                veterinarianToUpdate.LastName.ToUpper() != updateModel.LastName.ToUpper())
            {
                if (vets.Any(m => m.FirstName.ToUpper().Equals(updateModel.FirstName.ToUpper())
                    && m.LastName.ToUpper().Equals(updateModel.LastName.ToUpper())))
                    return veterinarianToUpdate.ToErrorModel(Constants.NameExistsMessage);
            }

            // Get ids to attach as entities
            var specialtiesToLink = specialties.Where(v => modelSpecialtyIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(v => modelConsultationIds.Contains(v.Id)).ToList();
            var practicesToLink = practices.Where(v => modelPracticeIds.Contains(v.Id)).ToList();

            // Update veterinarian entity
            veterinarianToUpdate.MapEntity(updateModel);
            veterinarianToUpdate.Specialties.AddRange(specialtiesToLink);
            veterinarianToUpdate.Consultations.AddRange(consultationsToLink);
            veterinarianToUpdate.Practices.AddRange(practicesToLink);

            if (!await _repository.UpdateAsync(veterinarianToUpdate))
                return veterinarianToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return veterinarianToUpdate.ToResultModel();
        }
    }
}
