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
            var consultationToAdd = new Consultation();

            string idSetSuccessMessage = SetIds(consultationToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return consultationToAdd.ToErrorModel(idSetSuccessMessage);

            if (!addModel.DateOfConsultation.CheckFutureDate())
                return consultationToAdd.ToErrorModel(Constants.FutureDateMessage);

            var imageSetSuccess = SetImage(consultationToAdd, addModel);
            if (!string.IsNullOrEmpty(imageSetSuccess.Result))
                return consultationToAdd.ToErrorModel(imageSetSuccess.Result);

            var documentSetSuccess = SetDocument(consultationToAdd, addModel);
            if (!string.IsNullOrEmpty(documentSetSuccess.Result))
                return consultationToAdd.ToErrorModel(documentSetSuccess.Result);

            consultationToAdd.MapEntity(addModel);

            if (!await _repository.CreateAsync(consultationToAdd))
                return consultationToAdd.ToErrorModel(Constants.DBCreateMessage);

            return consultationToAdd.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> UpdateAsync(ConsultationUpdateModel updateModel)
        {
            var consultationToUpdate = await _consultationRepository.GetByIdAsync(updateModel.Id);

            if (consultationToUpdate == null)
                return consultationToUpdate.ToErrorModel(Constants.UnknownConsultationMessage);

            string idSetSuccessMessage = SetIds(consultationToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return consultationToUpdate.ToErrorModel(idSetSuccessMessage);

            if (!updateModel.DateOfConsultation.CheckFutureDate())
                return consultationToUpdate.ToErrorModel(Constants.FutureDateMessage);

            var imageSetSuccess = SetImage(consultationToUpdate, updateModel);
            if (!string.IsNullOrEmpty(imageSetSuccess.Result))
                return consultationToUpdate.ToErrorModel(imageSetSuccess.Result);

            var documentSetSuccess = SetDocument(consultationToUpdate, updateModel);
            if (!string.IsNullOrEmpty(documentSetSuccess.Result))
                return consultationToUpdate.ToErrorModel(documentSetSuccess.Result);

            consultationToUpdate.MapEntity(updateModel);

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

        private string SetIds(Consultation cons, ConsultationAddModel model)
        {
            var vets = _veterinarianRepository.GetAll();
            var pets = _petRepository.GetAll();

            // Input checks
            if (!vets.CheckIfIdExists(model.VeterinarianId))
                return Constants.UnknownVeterinarianMessage;
            if (!pets.CheckIfIdExists(model.PetId))
                return Constants.UnknownPetMessage;

            if (model.VeterinarianId == 0)
                return Constants.NoVeterinarianMessage;
            if (model.PetId == 0)
                return Constants.NoPetMessage;

            var veterinarianToLink = vets.FirstOrDefault(p => p.Id == model.VeterinarianId);
            var petToLink = pets.FirstOrDefault(p => p.Id == model.PetId);

            cons.Veterinarian = veterinarianToLink;
            cons.Pet = petToLink;

            return string.Empty;
        }

        private async Task<string> SetImage(Consultation cons, ConsultationAddModel model)
        {
            if (model.Image is null)
                return string.Empty;

            var imageResult = await _fileService.StoreFile<Consultation>(model.Image, "ConsultationImages");
            if (!imageResult.IsSuccess)
                return imageResult.Error;

            cons.ImageFile = imageResult.FileName;
            return string.Empty;
        }

        private async Task<string> SetDocument(Consultation cons, ConsultationAddModel model)
        {
            if (model.Document is null)
                return string.Empty;

            var docuResulst = await _fileService.StoreFile<Consultation>(model.Image, "ConsultationDocuments");
            if (!docuResulst.IsSuccess)
                return docuResulst.Error;

            cons.DocumentFile = docuResulst.FileName;
            return string.Empty;
        }
    }
}
