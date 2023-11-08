using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IConsultationRepository : IBaseRepository<Consultation>
    {
        Task<IEnumerable<Consultation>> SearchByTitleAsync(string title);
        Task<IEnumerable<Consultation>> SearchByDiagnoseAsync(string diagnose);
    }
}
