using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IPracticeRepository : IBaseRepository<Practice>
    {
        Task<IEnumerable<Practice>> SearchByAddressAsync(string address);
    }
}
