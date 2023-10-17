using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Specialty;

namespace Pri.Pawpi.Core.Services
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly ISpecialtyRepository _specialtyRepository;
        private readonly IVeterinarianRepository _veterinarianRepository;

        public SpecialtyService(ISpecialtyRepository specialtyRepository, IVeterinarianRepository veterinarianRepository)
        {
            _specialtyRepository = specialtyRepository;
            _veterinarianRepository = veterinarianRepository;
        }

        public async Task<ResultModel<Specialty>> AddAsync(SpecialtyAddModel addModel)
        {
            var vets = _veterinarianRepository.GetAll();
            var specialties = _specialtyRepository.GetAll();

            var specialtyToAdd = new Specialty();

            if (!vets.CheckIfIdsExist(addModel.VeterinarianIds))
                return specialtyToAdd.ToErrorModel("Invalid veterinarians");

            if (specialties.Any(m => m.Name.ToUpper().Equals(addModel.Name.ToUpper())))
                return specialtyToAdd.ToErrorModel("Name already exists");

            var vetsToLink = vets.Where(p => addModel.VeterinarianIds.Contains(p.Id)).ToList();

            specialtyToAdd.Name = addModel.Name;
            specialtyToAdd.Description = addModel.Description;
            specialtyToAdd.Veterinarians = vetsToLink;

            if (!await _specialtyRepository.CreateAsync(specialtyToAdd))
                return specialtyToAdd.ToErrorModel("Something went wrong while adding specialty");

            return specialtyToAdd.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> DeleteAsync(int id)
        {
            var specialtyToDelete = await _specialtyRepository.GetByIdAsync(id);

            if (specialtyToDelete == null)
                return specialtyToDelete.ToErrorModel("Specialty not found");

            if (!await _specialtyRepository.DeleteAsync(specialtyToDelete))
                return specialtyToDelete.ToErrorModel("Something went wrong while deleting medication");

            return specialtyToDelete.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> GetAllAsync()
        {
            var specialties = await _specialtyRepository.GetAllAsync();
            return specialties.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> GetByIdAsync(int id)
         {
            var specialty = await _specialtyRepository.GetByIdAsync(id);

            if (specialty == null)
                return specialty.ToErrorModel("Specialty not found");

            return specialty.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> UpdateAsync(SpecialtyUpdateModel updateModel)
        {
            var vets = _veterinarianRepository.GetAll();
            var specialtyToUpdate = await _specialtyRepository.GetByIdAsync(updateModel.Id);

            if (specialtyToUpdate == null)
                return specialtyToUpdate.ToErrorModel("Specialty not found");

            if (!vets.CheckIfIdsExist(updateModel.VeterinarianIds))
                return specialtyToUpdate.ToErrorModel("Invalid veterinarians");


            // TO UPDATE, THROWS ERROR WITH DUPLICATE PETS
            var vetsToLink = vets.Where(p => updateModel.VeterinarianIds.Contains(p.Id)).ToList();

            specialtyToUpdate.Name = updateModel.Name;
            specialtyToUpdate.Description = updateModel.Description;
            specialtyToUpdate.Veterinarians = vetsToLink;

            if (!await _specialtyRepository.UpdateAsync(specialtyToUpdate))
                return specialtyToUpdate.ToErrorModel("Something went wrong while updating specialty");

            return specialtyToUpdate.ToResultModel();
        }
    }
}
