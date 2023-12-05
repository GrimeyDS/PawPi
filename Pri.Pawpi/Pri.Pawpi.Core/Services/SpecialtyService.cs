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
            var specialtyToAdd = new Specialty();

            string idSetSuccessMessage = SetIds(specialtyToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return specialtyToAdd.ToErrorModel(idSetSuccessMessage);

            string nameSetSuccessMessage = SetName(specialtyToAdd, addModel);
            if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                return specialtyToAdd.ToErrorModel(nameSetSuccessMessage);

            specialtyToAdd.MapEntity(addModel);

            if (!await _repository.CreateAsync(specialtyToAdd))
                return specialtyToAdd.ToErrorModel(Constants.DBCreateMessage);

            return specialtyToAdd.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> UpdateAsync(SpecialtyUpdateModel updateModel)
        { 
            var specialtyToUpdate = await _repository.GetByIdAsync(updateModel.Id);

            if (specialtyToUpdate == null)
                return specialtyToUpdate.ToErrorModel(Constants.NoSpecialtyFoundMessage);

            string idSetSuccessMessage = SetIds(specialtyToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return specialtyToUpdate.ToErrorModel(idSetSuccessMessage);


            if (specialtyToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                string nameSetSuccessMessage = SetName(specialtyToUpdate, updateModel);
                if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                    return specialtyToUpdate.ToErrorModel(nameSetSuccessMessage);
            }

            specialtyToUpdate.MapEntity(updateModel);

            if (!await _repository.UpdateAsync(specialtyToUpdate))
                return specialtyToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return specialtyToUpdate.ToResultModel();
        }

        public async Task<ResultModel<Specialty>> SearchByNameAsync(string name)
        {
            var specialties = await _repository.SearchByNameAsync(name);

            if (specialties == null)
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

        private string SetIds(Specialty spec, SpecialtyAddModel model)
        {
            var vets = _veterinarianRepository.GetAll();

            var modelVeterinarianIds = model.VeterinarianIds ?? new List<int>();

            if (!vets.CheckIfIdsExist(modelVeterinarianIds))
                return Constants.UnknownVeterinarianMessage;

            if (!vets.CheckIdsInput(modelVeterinarianIds))
                return Constants.NoVeterinarianMessage;

            var vetsToLink = vets.Where(p => modelVeterinarianIds.Contains(p.Id)).ToList();

            spec.Veterinarians = vetsToLink;

            return string.Empty;
        }

        private string SetName(Specialty spec, SpecialtyAddModel model)
        {
            var specialties = _repository.GetAll();

            if (specialties.Any(m => m.Name.ToUpper().Equals(model.Name.ToUpper())))
                return Constants.NameExistsMessage;

            spec.Name = model.Name;
            return string.Empty;
        }
    }
}
