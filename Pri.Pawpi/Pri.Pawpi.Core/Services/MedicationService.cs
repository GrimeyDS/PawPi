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
            var medicationToAdd = new Medication();

            string idSetSuccessMessage = SetIds(medicationToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return medicationToAdd.ToErrorModel(idSetSuccessMessage);

            string nameSetSuccessMessage = SetName(medicationToAdd, addModel);
            if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                return medicationToAdd.ToErrorModel(nameSetSuccessMessage);

            medicationToAdd.MapEntity(addModel);

            if (!await _medicationRepository.CreateAsync(medicationToAdd))
                return medicationToAdd.ToErrorModel(Constants.DBCreateMessage);

            return medicationToAdd.ToResultModel();
        }

        public async Task<ResultModel<Medication>> SearchByNameAsync(string name)
        {
            var medicine = await _medicationRepository.SearchByNameAsync(name);

            if (medicine == null)
                return medicine.ToErrorModel(Constants.NoMedicineFoundMessage);

            return medicine.ToResultModel();
        }

        public async Task<ResultModel<Medication>> SearchBySideEffectAsync(string sideEffect)
        {
            var medicine = await _medicationRepository.SearchBySideEffectAsync(sideEffect);

            if (medicine == null)
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
            var medicationToUpdate = await _medicationRepository.GetByIdAsync(updateModel.Id);

            if (medicationToUpdate == null)
                return medicationToUpdate.ToErrorModel(Constants.UnknownMedicineMessage);

            string idSetSuccessMessage = SetIds(medicationToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return medicationToUpdate.ToErrorModel(idSetSuccessMessage);

            if (medicationToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                string nameSetSuccessMessage = SetName(medicationToUpdate, updateModel);
                if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                    return medicationToUpdate.ToErrorModel(nameSetSuccessMessage);
            }

            medicationToUpdate.MapEntity(updateModel);

            if (!await _medicationRepository.UpdateAsync(medicationToUpdate))
                return medicationToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return medicationToUpdate.ToResultModel();
        }

        private string SetIds(Medication med, MedicationAddModel model)
        {
            var pets = _petRepository.GetAll();
            var modelPetIds = model.PetIds ?? new List<int>();

            if (!pets.CheckIfIdsExist(modelPetIds))
                return Constants.UnknownPetMessage;
            if (!pets.CheckIdsInput(modelPetIds))
                return Constants.NoPetMessage;

            var petsToLink = pets.Where(p => modelPetIds.Contains(p.Id)).ToList();

            med.Pets = petsToLink;

            return string.Empty;
        }

        private string SetName(Medication med, MedicationAddModel model)
        {
            var medicine = _medicationRepository.GetAll();

            if (medicine.Any(m => m.Name.ToUpper().Equals(model.Name.ToUpper())))
                return Constants.NameExistsMessage;

            med.Name = model.Name;
            return string.Empty;
        }
    }
}
