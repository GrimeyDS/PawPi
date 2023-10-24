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
        private readonly IFileService _fileService;

        public ConsultationService(IConsultationRepository consultationRepository, IPetRepository petRepository, 
            IVeterinarianRepository veterinarianRepository, IFileService fileService) : base(consultationRepository)
        {
            _consultationRepository = consultationRepository;
            _petRepository = petRepository;
            _veterinarianRepository = veterinarianRepository;
            _fileService = fileService;
        }

        public async Task<ResultModel<Consultation>> AddAsync(ConsultationAddModel addModel)
        {
            var consultations = _consultationRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();
            var pets = _petRepository.GetAll();

            var consultationToAdd = new Consultation();

            // Input checks
            if (!vets.CheckIfIdExists(addModel.VeterinarianId))
                return consultationToAdd.ToErrorModel(Constants.UnknownVeterinarianMessage);
            if (!pets.CheckIfIdExists(addModel.PetId))
                return consultationToAdd.ToErrorModel(Constants.UnknownPetMessage);

            if (addModel.VeterinarianId == 0)
                return consultationToAdd.ToErrorModel(Constants.NoVeterinarianMessage);
            if (addModel.PetId == 0)
                return consultationToAdd.ToErrorModel(Constants.NoPetMessage);

            if (addModel.DateOfConsultation >= DateTime.Now)
                return consultationToAdd.ToErrorModel(Constants.FutureDateMessage);

            // store files
            var imageResult = await _fileService.StoreFile<Consultation>(addModel.Image, "ConsultationImages");
            if (!imageResult.IsSuccess)
                return consultationToAdd.ToErrorModel(imageResult.Error);
            var documentResult = await _fileService.StoreFile<Consultation>(addModel.Document, "ConsultationDocuments");
            if (!documentResult.IsSuccess)
                return consultationToAdd.ToErrorModel(documentResult.Error);


            // Get ids to attach as entities
            var veterinarianToLink = vets.FirstOrDefault(p => p.Id == addModel.VeterinarianId);
            var petToLink = pets.FirstOrDefault(p => p.Id == addModel.PetId);

            // Update new consultation entity
            consultationToAdd.MapEntity(addModel);
            consultationToAdd.ImageFile = imageResult.FileName;
            consultationToAdd.DocumentFile = documentResult.FileName;
            consultationToAdd.Veterinarian = veterinarianToLink;
            consultationToAdd.Pet = petToLink;


            if (!await _repository.CreateAsync(consultationToAdd))
                return consultationToAdd.ToErrorModel(Constants.DBCreateMessage);

            return consultationToAdd.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> UpdateAsync(ConsultationUpdateModel updateModel)
        {
            var consultations = _consultationRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();
            var pets = _petRepository.GetAll();


            var consultationToUpdate = await _consultationRepository.GetByIdAsync(updateModel.Id);

            if (consultationToUpdate == null)
                return consultationToUpdate.ToErrorModel(Constants.UnknownConsultationMessage);

            // Input checks
            if (!vets.CheckIfIdExists(updateModel.VeterinarianId))
                return consultationToUpdate.ToErrorModel(Constants.UnknownVeterinarianMessage);
            if (!pets.CheckIfIdExists(updateModel.PetId))
                return consultationToUpdate.ToErrorModel(Constants.UnknownPetMessage);

            if (updateModel.VeterinarianId == 0)
                return consultationToUpdate.ToErrorModel(Constants.NoVeterinarianMessage);
            if (updateModel.PetId == 0)
                return consultationToUpdate.ToErrorModel(Constants.NoPetMessage);

            if (updateModel.DateOfConsultation >= DateTime.Now)
                return consultationToUpdate.ToErrorModel(Constants.FutureDateMessage);

            // store files
            var imageResult = await _fileService.StoreFile<Consultation>(updateModel.Image, "ConsultationImages");
            if (!imageResult.IsSuccess)
                return consultationToUpdate.ToErrorModel(imageResult.Error);
            var documentResult = await _fileService.StoreFile<Consultation>(updateModel.Document, "ConsultationDocuments");
            if (!documentResult.IsSuccess)
                return consultationToUpdate.ToErrorModel(documentResult.Error);

            // Get ids to attach as entities
            var veterinarianToLink = vets.FirstOrDefault(p => p.Id == updateModel.VeterinarianId);
            var petToLink = pets.FirstOrDefault(p => p.Id == updateModel.PetId);

            // Update consultation entity
            consultationToUpdate.MapEntity(updateModel);
            consultationToUpdate.ImageFile = imageResult.FileName;
            consultationToUpdate.DocumentFile = documentResult.FileName;
            consultationToUpdate.Veterinarian = veterinarianToLink;
            consultationToUpdate.Pet = petToLink;

            if (!await _repository.UpdateAsync(consultationToUpdate))
                return consultationToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return consultationToUpdate.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> SearchByTitleAsync(string title)
        {
            var consultations = await _consultationRepository.SearchByTitleAsync(title);

            if (consultations == null)
                return consultations.ToErrorModel(Constants.NoConsultationFoundMessage);

            return consultations.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> SearchByDiagnoseAsync(string diagnose)
        {
            var consultations = await _consultationRepository.SearchByDiagnoseAsync(diagnose);

            if (consultations == null)
                return consultations.ToErrorModel(Constants.NoConsultationFoundMessage);

            return consultations.ToResultModel();
        }
    }
}
