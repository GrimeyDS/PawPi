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
        public PetService(IPetRepository petRepository) : base(petRepository)
        {
        }

        public Task<ResultModel<Pet>> AddAsync(PetAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Pet>> UpdateAsync(PetUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Pet>> SearchByNameAsync(string name)
        {
            var pets = await _repository.SearchByNameAsync(name);

            if (pets == null)
                return pets.ToErrorModel("Pet not found");

            return pets.ToResultModel();
        }
    }
}
