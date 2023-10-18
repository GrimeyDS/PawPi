using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IVeterinarianService
    {
        Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel);
        Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel);
        Task<ResultModel<Veterinarian>> DeleteAsync(int id);
        Task<ResultModel<Veterinarian>> GetAllAsync();
        Task<ResultModel<Veterinarian>> GetByIdAsync(int id);
    }
}
