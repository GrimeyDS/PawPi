using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Core.Services
{
    public class VeterinarianService : IVeterinarianService
    {
        private readonly IVeterinarianRepository _veterinarianRepository;

        public VeterinarianService(IVeterinarianRepository veterinarianRepository)
        {
            _veterinarianRepository = veterinarianRepository;
        }

        public Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Veterinarian>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Veterinarian>> GetAllAsync()
        {
            var vets = await _veterinarianRepository.GetAllAsync();
            return vets.ToResultModel();
        }

        public Task<ResultModel<Veterinarian>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
