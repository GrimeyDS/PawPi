using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Medication;

namespace Pri.Pawpi.Core.Services
{
    public class MedicationService : ServiceBase<Medication>, IMedicationService
    {
        private readonly IPetRepository _petRepository;
        private readonly IMedicationRepository _medicationRepository;

        public MedicationService(IMedicationRepository medicationRepository, IPetRepository petRepository) : base(medicationRepository)
        {
            _petRepository = petRepository;
            _medicationRepository = medicationRepository;
        }

        public async Task<ResultModel<Medication>> AddAsync(MedicationAddModel addModel)
        {
            var medicine = _medicationRepository.GetAll();
            var pets = _petRepository.GetAll();
            var modelPetIds = addModel.PetIds;

            var medicationToAdd = new Medication();

            // Input checks
            if (!pets.CheckIfIdsExist(modelPetIds))
                return medicationToAdd.ToErrorModel(Constants.NoPetMessage);

            if (medicine.Any(m => m.Name.ToUpper().Equals(addModel.Name.ToUpper())))
                return medicationToAdd.ToErrorModel(Constants.NameExistsMessage);

            // Get veterinarians to attach
            var petsToLink = pets.Where(v => modelPetIds.Contains(v.Id)).ToList();

            // Update new medication entity
            medicationToAdd.MapEntity(addModel);
            medicationToAdd.Pets = petsToLink;

            if (!await _medicationRepository.CreateAsync(medicationToAdd))
                return medicationToAdd.ToErrorModel(Constants.DBCreateMessage);

            return medicationToAdd.ToResultModel();
        }

        public async Task<ResultModel<Medication>> SearchByNameAsync(string name)
        {
            var medicine = await _medicationRepository.SearchByNameAsync(name);

            if (medicine.Count() == 0)
                return medicine.ToErrorModel(Constants.NoMedicineFoundMessage);

            return medicine.ToResultModel();
        }

        public async Task<ResultModel<Medication>> SearchBySideEffectAsync(string sideEffect)
        {
            var medicine = await _medicationRepository.SearchBySideEffectAsync(sideEffect);

            if (medicine.Count() == 0)
                return medicine.ToErrorModel(Constants.NoMedicineFoundMessage);

            return medicine.ToResultModel();
        }

        public async Task<ResultModel<Pet>> GetPetsByMedicationIdAsync(int id)
        {
            var pets = await _petRepository.GetAllAsync();

            var petsByMedication = pets.Where(p => p.Medications.Any(m => m.Id == id));

            if (petsByMedication.Count() == 0)
                return petsByMedication.ToErrorModel(Constants.NoPetFoundMessage);

            return petsByMedication.ToResultModel();
        }

        public async Task<ResultModel<Medication>> UpdateAsync(MedicationUpdateModel updateModel)
        {
            var medicine = _medicationRepository.GetAll();
            var pets = _petRepository.GetAll();
            var modelPetIds = updateModel.PetIds;

            var medicationToUpdate = await _medicationRepository.GetByIdAsync(updateModel.Id);

            if (medicationToUpdate == null)
                return medicationToUpdate.ToErrorModel(Constants.UnknownMedicineMessage);

            // Input checks
            if (!pets.CheckIfIdsExist(modelPetIds))
                return medicationToUpdate.ToErrorModel(Constants.UnknownPetMessage);

            if (medicationToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                if (medicine.Any(m => m.Name.ToUpper().Equals(updateModel.Name.ToUpper())))
                    return medicationToUpdate.ToErrorModel(Constants.NameExistsMessage);
            }

            // Get veterinarians to attach
            var petsToLink = pets.Where(p => modelPetIds.Contains(p.Id)).ToList();

            // Update new medication entity
            medicationToUpdate.Name = updateModel.Name;
            medicationToUpdate.Dosage = updateModel.Dosage;
            medicationToUpdate.Frequency = updateModel.Frequency;
            medicationToUpdate.Notes = updateModel.Notes;
            medicationToUpdate.SideEffects = updateModel.SideEffects;
            medicationToUpdate.Pets = petsToLink;

            if (!await _medicationRepository.UpdateAsync(medicationToUpdate))
                return medicationToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return medicationToUpdate.ToResultModel();
        }
    }
}
