using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Specialty;

namespace Pri.Pawpi.Core.Services
{
    public class SpecialtyService : ServiceBase<Specialty>, ISpecialtyService
    {
        private readonly IVeterinarianRepository _veterinarianRepository;

        public SpecialtyService(ISpecialtyRepository specialtyRepository, IVeterinarianRepository veterinarianRepository)  : base(specialtyRepository) 
        {
            _veterinarianRepository = veterinarianRepository;
        }

        public async Task<ResultModel<Specialty>> AddAsync(SpecialtyAddModel addModel)
        {
            var vets = _veterinarianRepository.GetAll();
            var specialties = _repository.GetAll();
            var modelVeterinarianIds = addModel.VeterinarianIds;

            var specialtyToAdd = new Specialty();

            // Input checks
            if (!vets.CheckIfIdsExist(modelVeterinarianIds))
                return specialtyToAdd.ToErrorModel(Constants.UnknownVeterinarianMessage);

            if (!vets.CheckIdsInput(modelVeterinarianIds))
                return specialtyToAdd.ToErrorModel(Constants.NoVeterinarianMessage);

            if (specialties.Any(m => m.Name.ToUpper().Equals(addModel.Name.ToUpper())))
                return specialtyToAdd.ToErrorModel(Constants.NameExistsMessage);

            // Get veterinarians to attach
            var vetsToLink = vets.Where(v => modelVeterinarianIds.Contains(v.Id)).ToList();

            // Update new specialty entity
            specialtyToAdd.MapEntity(addModel);
            specialtyToAdd.Veterinarians = vetsToLink;

            if (!await _repository.CreateAsync(specialtyToAdd))
                return specialtyToAdd.ToErrorModel(Constants.DBCreateMessage);

            return specialtyToAdd.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> UpdateAsync(SpecialtyUpdateModel updateModel)
        {
            var vets = _veterinarianRepository.GetAll();
            var specialties = _repository.GetAll();
            var specialtyToUpdate = await _repository.GetByIdAsync(updateModel.Id);
            var modelVeterinarianIds = updateModel.VeterinarianIds;

            if (specialtyToUpdate == null)
                return specialtyToUpdate.ToErrorModel(Constants.NoSpecialtyFoundMessage);

            // Input checks
            if (!vets.CheckIfIdsExist(modelVeterinarianIds))
                return specialtyToUpdate.ToErrorModel(Constants.UnknownVeterinarianMessage);

            if (!vets.CheckIdsInput(modelVeterinarianIds))
                return specialtyToUpdate.ToErrorModel(Constants.NoVeterinarianMessage);

            if (specialtyToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                if (specialties.Any(m => m.Name.ToUpper().Equals(updateModel.Name.ToUpper())))
                    return specialtyToUpdate.ToErrorModel(Constants.NameExistsMessage);
            }

            // Get veterinarians to attach
            var vetsToLink = vets.Where(p => modelVeterinarianIds.Contains(p.Id)).ToList();

            // Update found specialty entity
            specialtyToUpdate.MapEntity(updateModel);
            specialtyToUpdate.Veterinarians.AddRange(vetsToLink);

            if (!await _repository.UpdateAsync(specialtyToUpdate))
                return specialtyToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return specialtyToUpdate.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> SearchByNameAsync(string name)
        {
            var specialties = await _repository.SearchByNameAsync(name);

            if (specialties.Count() == 0)
                return specialties.ToErrorModel(Constants.NoSpecialtyFoundMessage);

            return specialties.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> GetVetsFromSpecialtyAsync(int id)
        {
            var vets = await _veterinarianRepository.GetAllAsync();

            var vetsBySpecialty = vets.Where(v => v.Specialties.Any(s => s.Id == id));

            if (vetsBySpecialty.Count() == 0)
                return vetsBySpecialty.ToErrorModel(Constants.NoVeterinarianFoundMessage);

            return vetsBySpecialty.ToResultModel();
        }
    }
}
