using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Medication;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IMedicationService
    {
        Task<ResultModel<Medication>> AddAsync(MedicationAddModel addModel);
        Task<ResultModel<Medication>> UpdateAsync(MedicationUpdateModel updateModel);
        Task<ResultModel<Medication>> DeleteAsync(int id);
        Task<ResultModel<Medication>> GetAllAsync();
        Task<ResultModel<Medication>> GetByIdAsync(int id);
        Task<ResultModel<Medication>> SearchByNameAsync(string name);
    }
}
