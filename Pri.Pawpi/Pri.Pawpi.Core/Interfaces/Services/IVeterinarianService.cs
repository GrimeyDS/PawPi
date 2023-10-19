using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IVeterinarianService : IServiceBase<Veterinarian>
    {
        Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel);
        Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel);
    }
}
