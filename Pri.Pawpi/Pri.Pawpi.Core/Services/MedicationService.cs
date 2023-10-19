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
        public MedicationService(IMedicationRepository medicationRepository) : base(medicationRepository)
        {
        }

        public Task<ResultModel<Medication>> AddAsync(MedicationAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Medication>> SearchByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Medication>> UpdateAsync(MedicationUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }

        //public async Task<ResultModel<Medication>> AddAsync(MedicationAddModel addModel)
        //{
        //    var pets =  _petRepository.GetAll();
        //    var medicine = _repository.GetAll();
        //    var medicationToAdd = new Medication();

        //    if (!pets.CheckIfIdsExist(addModel.PetIds))
        //        return medicationToAdd.ToErrorModel("Invalid pets");

        //    if (medicine.Any(m => m.Name.ToUpper().Equals(addModel.Name.ToUpper())))
        //        return medicationToAdd.ToErrorModel("Name already exists");

        //    var petsToLink = pets.Where(p => addModel.PetIds.Contains(p.Id)).ToList();

        //    medicationToAdd.Name = addModel.Name;
        //    medicationToAdd.Notes = addModel.Notes;
        //    medicationToAdd.SideEffects = addModel.SideEffects;
        //    medicationToAdd.Pets = petsToLink;
        //    medicationToAdd.Frequency = addModel.Frequency;
        //    medicationToAdd.Dosage = addModel.Dosage;

        //    if (!await _medicationRepository.CreateAsync(medicationToAdd))
        //        return medicationToAdd.ToErrorModel("Something went wrong while adding medication");

        //    return medicationToAdd.ToResultModel();
        //}

        //public async Task<ResultModel<Medication>> UpdateAsync(MedicationUpdateModel updateModel)
        //{
        //    var pets = _petRepository.GetAll();
        //    var medicationToUpdate = await _medicationRepository.GetByIdAsync(updateModel.Id);

        //    if (medicationToUpdate == null)
        //        return medicationToUpdate.ToErrorModel("Medication not found");

        //    if (!pets.CheckIfIdsExist(updateModel.PetIds))
        //        return medicationToUpdate.ToErrorModel("Invalid pets");


        //    // TO UPDATE, THROWS ERROR WITH DUPLICATE PETS
        //    var petsToLink = pets.Where(p => updateModel.PetIds.Contains(p.Id)).ToList();

        //    medicationToUpdate.Name = updateModel.Name;
        //    medicationToUpdate.Notes = updateModel.Notes;
        //    medicationToUpdate.SideEffects = updateModel.SideEffects;
        //    medicationToUpdate.Pets = petsToLink;
        //    medicationToUpdate.Frequency = updateModel.Frequency;
        //    medicationToUpdate.Dosage = updateModel.Dosage;

        //    if (!await _medicationRepository.UpdateAsync(medicationToUpdate))
        //        return medicationToUpdate.ToErrorModel("Something went wrong while updating medication");

        //    return medicationToUpdate.ToResultModel();
        //}

        //public async Task<ResultModel<Medication>> SearchByNameAsync(string name)
        //{
        //    var medicine = await _medicationRepository.SearchByNameAsync(name);

        //    if (medicine == null)
        //        return medicine.ToErrorModel("Medication not found");

        //    return medicine.ToResultModel();
        //}
    }
}
