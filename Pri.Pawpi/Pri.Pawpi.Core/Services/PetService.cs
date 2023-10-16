using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IPetRepository _petRepository;

        public PetService(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public Task<ResultModel<Pet>> AddAsync(Pet addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Pet>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Pet>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Pet>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Pet>> UpdateAsync(Pet updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
