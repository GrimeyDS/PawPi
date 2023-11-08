using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IMedicationRepository : IBaseRepository<Medication>
    {
        Task<IEnumerable<Medication>> SearchBySideEffectAsync(string sideEffect);

    }
}