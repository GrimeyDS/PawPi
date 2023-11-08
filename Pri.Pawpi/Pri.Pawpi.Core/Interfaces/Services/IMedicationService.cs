using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Medication;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IMedicationService : IServiceBase<Medication>
    {
        Task<ResultModel<Medication>> AddAsync(MedicationAddModel addModel);
        Task<ResultModel<Medication>> UpdateAsync(MedicationUpdateModel updateModel);
        Task<ResultModel<Medication>> SearchByNameAsync(string name);
        Task<ResultModel<Medication>> SearchBySideEffectAsync(string sideEffect);
        Task<ResultModel<Pet>> GetPetsByMedicationIdAsync(int id);
    }
}
