using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IMedicationService : IServiceBase<Medication>
    {
        Task<ResultModel<Medication>> SearchByNameAsync(string name);
    }
}
