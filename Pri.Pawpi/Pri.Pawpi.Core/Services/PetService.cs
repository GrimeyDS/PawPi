using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Pet;

namespace Pri.Pawpi.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public Task<ResultModel<Pet>> AddAsync(PetAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Pet>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Pet>> GetAllAsync()
        {
            var pets = await _petRepository.GetAllAsync();
            return pets.ToResultModel();
        }

        public async Task<ResultModel<Pet>> GetByIdAsync(int id)
        {
            var pet = await _petRepository.GetByIdAsync(id);

            if (pet == null)
                return pet.ToErrorModel("Pet not found");

            return pet.ToResultModel();
        }

        public Task<ResultModel<Pet>> UpdateAsync(PetUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Pet>> SearchByNameAsync(string name)
        {
            var pets = await _petRepository.SearchByNameAsync(name);

            if (pets == null)
                return pets.ToErrorModel("Medication not found");

            return pets.ToResultModel();
        }
    }
}
