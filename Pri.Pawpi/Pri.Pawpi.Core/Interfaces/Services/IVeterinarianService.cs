using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Veterinarian;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IVeterinarianService : IServiceBase<Veterinarian>
    {
        Task<ResultModel<Veterinarian>> AddAsync(VeterinarianAddModel addModel);
        Task<ResultModel<Veterinarian>> UpdateAsync(VeterinarianUpdateModel updateModel);
        Task<ResultModel<Veterinarian>> SearchByNameAsync(string name);
        Task<ResultModel<Specialty>> GetSpecialtiesFromVeterinariansAsync(int id);
        Task<ResultModel<Consultation>> GetConsultationsFromVeterinariansAsync(int id);
        Task<ResultModel<Practice>> GetPracticesFromVeterinariansAsync(int id);
    }
}
