using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Services.Models.Consultations;

namespace Pri.Pawpi.Core.Services
{
    public class ConsultationService : ServiceBase<Consultation>, IConsultationService
    {
        private readonly IConsultationRepository _consultationRepository;
        private readonly IPetRepository _petRepository;
        private readonly IVeterinarianRepository _veterinarianRepository;

        private const string UnknownVeterinarianMessage = "Unknown veterinarian!";
        private const string UnknownPetMessage = "Unknown pet!";
        private const string UnknownConsultationMessage = "Unknown consultation!";
        private const string NoVeterinarianMessage = "Please provide a veterinarian";
        private const string NoPetMessage = "Please provide a practice";
        private const string FutureDateMessage = "Birth date cannot be in the future";
        private const string SomethingWentWrongMessage = "Something went wrong while adding/updating consultation";

        public ConsultationService(IConsultationRepository consultationRepository, IPetRepository petRepository, IVeterinarianRepository veterinarianRepository) : base(consultationRepository)
        {
            _consultationRepository = consultationRepository;
            _petRepository = petRepository;
            _veterinarianRepository = veterinarianRepository;
        }

        public async Task<ResultModel<Consultation>> AddAsync(ConsultationAddModel addModel)
        {
            var consultations = _consultationRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();
            var pets = _petRepository.GetAll();

            var consultationToAdd = new Consultation();

            // Input checks
            if (!vets.CheckIfIdExists(addModel.VeterinarianId))
                return consultationToAdd.ToErrorModel(UnknownVeterinarianMessage);
            if (!pets.CheckIfIdExists(addModel.PetId))
                return consultationToAdd.ToErrorModel(UnknownPetMessage);

            if (addModel.VeterinarianId == 0)
                return consultationToAdd.ToErrorModel(NoVeterinarianMessage);
            if (addModel.PetId == 0)
                return consultationToAdd.ToErrorModel(NoPetMessage);

            if (addModel.DateOfConsultation >= DateTime.Now)
                return consultationToAdd.ToErrorModel(FutureDateMessage);

            // Get ids to attach as entities
            var veterinarianToLink = vets.FirstOrDefault(p => p.Id == addModel.VeterinarianId);
            var petToLink = pets.FirstOrDefault(p => p.Id == addModel.PetId);

            // Update new consultation entity
            consultationToAdd.MapEntity(addModel);
            consultationToAdd.Veterinarian = veterinarianToLink;
            consultationToAdd.Pet = petToLink;


            if (!await _repository.CreateAsync(consultationToAdd))
                return consultationToAdd.ToErrorModel(SomethingWentWrongMessage);

            return consultationToAdd.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> UpdateAsync(ConsultationUpdateModel updateModel)
        {
            var consultations = _consultationRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();
            var pets = _petRepository.GetAll();


            var consultationToUpdate = await _consultationRepository.GetByIdAsync(updateModel.Id);

            if (consultationToUpdate == null)
                return consultationToUpdate.ToErrorModel(UnknownConsultationMessage);

            // Input checks
            if (!vets.CheckIfIdExists(updateModel.VeterinarianId))
                return consultationToUpdate.ToErrorModel(UnknownVeterinarianMessage);
            if (!pets.CheckIfIdExists(updateModel.PetId))
                return consultationToUpdate.ToErrorModel(UnknownPetMessage);

            if (updateModel.VeterinarianId == 0)
                return consultationToUpdate.ToErrorModel(NoVeterinarianMessage);
            if (updateModel.PetId == 0)
                return consultationToUpdate.ToErrorModel(NoPetMessage);

            if (updateModel.DateOfConsultation >= DateTime.Now)
                return consultationToUpdate.ToErrorModel(FutureDateMessage);

            // Get ids to attach as entities
            var veterinarianToLink = vets.FirstOrDefault(p => p.Id == updateModel.VeterinarianId);
            var petToLink = pets.FirstOrDefault(p => p.Id == updateModel.PetId);

            // Update consultation entity
            consultationToUpdate.MapEntity(updateModel);
            consultationToUpdate.Veterinarian = veterinarianToLink;
            consultationToUpdate.Pet = petToLink;

            if (!await _repository.UpdateAsync(consultationToUpdate))
                return consultationToUpdate.ToErrorModel(SomethingWentWrongMessage);

            return consultationToUpdate.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> SearchByTitleAsync(string title)
        {
            var consultations = await _consultationRepository.SearchByTitleAsync(title);

            if (consultations == null)
                return consultations.ToErrorModel(UnknownConsultationMessage);

            return consultations.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> SearchByDiagnoseAsync(string diagnose)
        {
            var consultations = await _consultationRepository.SearchByDiagnoseAsync(diagnose);

            if (consultations == null)
                return consultations.ToErrorModel(UnknownConsultationMessage);

            return consultations.ToResultModel();
        }
    }
}
