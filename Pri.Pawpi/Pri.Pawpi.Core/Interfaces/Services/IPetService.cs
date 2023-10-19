using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Pet;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IPetService
    {
        Task<ResultModel<Pet>> AddAsync(PetAddModel addModel);
        Task<ResultModel<Pet>> UpdateAsync(PetUpdateModel updateModel);
        Task<ResultModel<Pet>> DeleteAsync(int id);
        Task<ResultModel<Pet>> GetAllAsync();
        Task<ResultModel<Pet>> GetByIdAsync(int id);
        Task<ResultModel<Pet>> SearchByNameAsync(string name);
    }
}
