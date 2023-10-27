using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Pet;

namespace Pri.Pawpi.Core.Services
{
    public class PetService : ServiceBase<Pet>, IPetService
    {
        private readonly IPetRepository _petRepository;
        private readonly IConsultationRepository _consultationRepository;
        private readonly IMedicationRepository _medicationRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IFileService _fileService;

        public PetService(IPetRepository petRepository, 
            IConsultationRepository consultationRepository,
            IMedicationRepository medicationRepository,
            ICustomerRepository customerRepository,
            IFileService fileService) : base(petRepository)
        {
            _petRepository = petRepository;
            _consultationRepository = consultationRepository;
            _medicationRepository = medicationRepository;
            _customerRepository = customerRepository;
            _fileService = fileService;
        }

        public async Task<ResultModel<Pet>> AddAsync(PetAddModel addModel)
        {
            var petToAdd = new Pet();

            string idSetSuccessMessage = SetIds(petToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return petToAdd.ToErrorModel(idSetSuccessMessage);

            string nameSetSuccessMessage = SetName(petToAdd, addModel);
            if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                return petToAdd.ToErrorModel(nameSetSuccessMessage);

            var imageSetSuccess = SetImage(petToAdd, addModel);
            if (!string.IsNullOrEmpty(imageSetSuccess.Result))
                return petToAdd.ToErrorModel(imageSetSuccess.Result);

            var pedigreeSetSuccess = SetPedigree(petToAdd, addModel);
            if (!string.IsNullOrEmpty(pedigreeSetSuccess.Result))
                return petToAdd.ToErrorModel(pedigreeSetSuccess.Result);

            petToAdd.MapEntity(addModel);

            if (!await _repository.CreateAsync(petToAdd))
                return petToAdd.ToErrorModel(Constants.DBCreateMessage);

            return petToAdd.ToResultModel();
        }

        public async Task<ResultModel<Pet>> UpdateAsync(PetUpdateModel updateModel)
        {
            var petToUpdate = await _petRepository.GetByIdAsync(updateModel.Id);

            if (petToUpdate == null)
                return petToUpdate.ToErrorModel(Constants.NoPetFoundMessage);

            string idSetSuccessMessage = SetIds(petToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return petToUpdate.ToErrorModel(idSetSuccessMessage);

            if (petToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                string nameSetSuccessMessage = SetName(petToUpdate, updateModel);
                if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                    return petToUpdate.ToErrorModel(nameSetSuccessMessage);
            }

            var imageSetSuccess = SetImage(petToUpdate, updateModel);
            if (!string.IsNullOrEmpty(imageSetSuccess.Result))
                return petToUpdate.ToErrorModel(imageSetSuccess.Result);

            var pedigreeSetSuccess = SetPedigree(petToUpdate, updateModel);
            if (!string.IsNullOrEmpty(pedigreeSetSuccess.Result))
                return petToUpdate.ToErrorModel(pedigreeSetSuccess.Result);

            petToUpdate.MapEntity(updateModel);

            if (!await _repository.UpdateAsync(petToUpdate))
                return petToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return petToUpdate.ToResultModel();
        }

        public async Task<ResultModel<Pet>> SearchByNameAsync(string name)
        {
            var pets = await _petRepository.SearchByNameAsync(name);

            if (pets == null)
                return pets.ToErrorModel(Constants.NoPetFoundMessage);

            return pets.ToResultModel();
        }

        public async Task<ResultModel<Pet>> SearchByAnimalTypeAsync(string animalType)
        {
            var pets = await _petRepository.SearchByAnimalTypeAsync(animalType);

            if (pets == null)
                return pets.ToErrorModel(Constants.NoPetFoundMessage);

            return pets.ToResultModel();
        }

        public async Task<ResultModel<Pet>> SearchByBreedAsync(string breed)
        {
            var pets = await _petRepository.SearchByBreedAsync(breed);

            if (pets == null)
                return pets.ToErrorModel(Constants.NoPetFoundMessage);

            return pets.ToResultModel();
        }

        public async Task<ResultModel<Medication>> GetMedicineFromPetAsync(int id)
        {
            var medicine = await _medicationRepository.GetAllAsync();

            var medicineByPets = medicine.Where(s => s.Pets.Any(v => v.Id == id));

            if (medicineByPets.Count() == 0)
                return medicineByPets.ToErrorModel(Constants.NoMedicineFoundMessage);

            return medicineByPets.ToResultModel();
        }

        public async Task<ResultModel<Consultation>> GetConsultationsFromPetAsync(int id)
        {
            var consultations = await _consultationRepository.GetAllAsync();

            var consultationsByPet = consultations.Where(c => c.PetId.Equals(id));

            if (consultationsByPet.Count() == 0)
                return consultationsByPet.ToErrorModel(Constants.NoConsultationFoundMessage);

            return consultationsByPet.ToResultModel();
        }

        private string SetIds(Pet pet, PetAddModel model)
        {
            var customers = _customerRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var medicine = _medicationRepository.GetAll();

            var modelConsultationIds = model.ConsultationIds ?? new List<int>();
            var modelMedicineIds = model.MedicationIds ?? new List<int>();

            // Input checks
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return Constants.UnknownConsultationMessage;
            if (!medicine.CheckIfIdsExist(modelMedicineIds))
                return Constants.UnknownMedicineMessage;
            if (!customers.CheckIfIdExists(model.CustomerId))
                return Constants.UnknownCustomerMessage;

            if (!consultations.CheckIdsInput(modelConsultationIds))
                return Constants.NoConsultationMessage;
            if (!medicine.CheckIdsInput(modelMedicineIds))
                return Constants.NoMedicineMessage;
            if (model.CustomerId == 0)
                return Constants.NoCustomerMessage;

            var medicineToLink = medicine.Where(v => modelMedicineIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(c => modelConsultationIds.Contains(c.Id)).ToList();
            var customerToLink = customers.FirstOrDefault(c => c.Id == model.CustomerId);

            pet.Medications = medicineToLink;
            pet.Consultations = consultationsToLink;
            pet.Customer = customerToLink;

            return string.Empty;
        }

        private string SetName(Pet pet, PetAddModel model)
        {
            var pets = _repository.GetAll();

            if (pets.Any(m => m.Name.ToUpper().Equals(model.Name.ToUpper())))
                return Constants.NameExistsMessage;

            pet.Name = model.Name;
            return string.Empty;
        }

        private async Task<string> SetImage(Pet pet, PetAddModel model)
        {
            if (model.Image is null)
                return string.Empty;

            var imageResult = await _fileService.StoreFile<Pet>(model.Image, "PetImages");
            if (!imageResult.IsSuccess)
                return imageResult.Error;

            pet.ImageFile = imageResult.FileName;
            return string.Empty;
        }

        private async Task<string> SetPedigree(Pet pet, PetAddModel model)
        {
            if (model.Pedigree is null)
                return string.Empty;

            var pedigreeResult = await _fileService.StoreFile<Pet>(model.Image, "PetPedigrees");
            if (!pedigreeResult.IsSuccess)
                return pedigreeResult.Error;

            pet.PedigreeFile = pedigreeResult.FileName;
            return string.Empty;
        }
    }
}
