using Microsoft.AspNetCore.Mvc.RazorPages;
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
            var pets = _petRepository.GetAll();

            var customers = _customerRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var medicine = _medicationRepository.GetAll();

            var modelConsultationIds = addModel.ConsultationIds;
            var modelMedicineIds = addModel.MedicationIds;

            var petToAdd = new Pet();

            // Input checks
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return petToAdd.ToErrorModel(Constants.UnknownConsultationMessage);
            if (!medicine.CheckIfIdsExist(modelMedicineIds))
                return petToAdd.ToErrorModel(Constants.UnknownMedicineMessage);
            if (!customers.CheckIfIdExists(addModel.CustomerId))
                return petToAdd.ToErrorModel(Constants.UnknownCustomerMessage);

            if (addModel.CustomerId == 0)
                return petToAdd.ToErrorModel(Constants.NoCustomerMessage);

            if (pets.Any(m => m.Name.ToUpper().Equals(addModel.Name.ToUpper())))
                return petToAdd.ToErrorModel(Constants.NameExistsMessage);

            // store image
            var imageResult = await _fileService.StoreFile<Pet>(addModel.Image, "PetImages");
            if (!imageResult.IsSuccess)
                return petToAdd.ToErrorModel(imageResult.Error);

            // Get ids to attach as entities
            var medicineToLink = medicine.Where(v => modelMedicineIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(c => modelConsultationIds.Contains(c.Id)).ToList();
            var customerToLink = customers.FirstOrDefault(c => c.Id == addModel.CustomerId);

            // Update new pet entity
            petToAdd.MapEntity(addModel);
            petToAdd.ImageFile = imageResult.FileName;
            petToAdd.Medications = medicineToLink;
            petToAdd.Consultations = consultationsToLink;
            petToAdd.Customer = customerToLink;


            if (!await _repository.CreateAsync(petToAdd))
                return petToAdd.ToErrorModel(Constants.DBCreateMessage);

            return petToAdd.ToResultModel();
        }

        public async Task<ResultModel<Pet>> UpdateAsync(PetUpdateModel updateModel)
        {
            var pets = _petRepository.GetAll();

            var customers = _customerRepository.GetAll();
            var consultations = _consultationRepository.GetAll();
            var medicine = _medicationRepository.GetAll();

            var modelConsultationIds = updateModel.ConsultationIds;
            var modelMedicineIds = updateModel.MedicationIds;

            var petToUpdate = await _petRepository.GetByIdAsync(updateModel.Id);

            if (petToUpdate == null)
                return petToUpdate.ToErrorModel(Constants.NoPetFoundMessage);

            // Input checks
            if (!consultations.CheckIfIdsExist(modelConsultationIds))
                return petToUpdate.ToErrorModel(Constants.UnknownConsultationMessage);
            if (!medicine.CheckIfIdsExist(modelMedicineIds))
                return petToUpdate.ToErrorModel(Constants.UnknownMedicineMessage);
            if (!customers.CheckIfIdExists(updateModel.CustomerId))
                return petToUpdate.ToErrorModel(Constants.UnknownCustomerMessage);

            if (updateModel.CustomerId == 0)
                return petToUpdate.ToErrorModel(Constants.NoCustomerMessage);

            if (petToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                if (pets.Any(m => m.Name.ToUpper().Equals(updateModel.Name.ToUpper())))
                    return petToUpdate.ToErrorModel(Constants.NameExistsMessage);
            }

            // store image
            var imageResult = await _fileService.StoreFile<Pet>(updateModel.Image, "PetImages");
            if (!imageResult.IsSuccess)
                return petToUpdate.ToErrorModel(imageResult.Error);

            // Get ids to attach as entities
            var medicineToLink = medicine.Where(v => modelMedicineIds.Contains(v.Id)).ToList();
            var consultationsToLink = consultations.Where(c => modelConsultationIds.Contains(c.Id)).ToList();
            var customerToLink = customers.FirstOrDefault(c => c.Id == updateModel.CustomerId);

            // Update veterinarian entity
            petToUpdate.MapEntity(updateModel);
            petToUpdate.ImageFile = imageResult.FileName;
            petToUpdate.Medications.AddRange(medicineToLink);
            petToUpdate.Consultations.AddRange(consultationsToLink);
            petToUpdate.Customer = customerToLink;

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
    }
}
