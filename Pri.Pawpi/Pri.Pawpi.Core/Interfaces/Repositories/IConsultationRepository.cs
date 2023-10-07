using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IConsultationRepository : IBaseRepository<Consultation>
    {
        public Task<IEnumerable<Consultation>> SearchByPetIdAsync(int petId);
        public Task<IEnumerable<Consultation>> SearchByVeterinarianIdAsync(int vetId);
    }
}
