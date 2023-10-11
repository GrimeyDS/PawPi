using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IPracticeRepository : IBaseRepository<Practice>
    {
        public Task<DateTime?> GetOpenTime(int practiceId);
        public Task<DateTime?> GetClosureTime(int practiceId);
        public Task<IEnumerable<Practice>> SearchByCity(string city);
    }
}
