using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IPetService : IServiceBase<Pet>
    {
        Task<ResultModel<Pet>> SearchByNameAsync(string name);
    }
}
