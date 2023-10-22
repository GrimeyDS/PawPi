using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Practice;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IPracticeService : IServiceBase<Practice>
    {
        Task<ResultModel<Practice>> AddAsync(PracticeAddModel addModel);
        Task<ResultModel<Practice>> UpdateAsync(PracticeUpdateModel updateModel);

        Task<ResultModel<Practice>> SearchByNameAsync(string name);
        Task<ResultModel<Practice>> SearchByAddressAsync(string address);
        Task<ResultModel<Customer>> GetCustomersByPracticeAsync(int id);
        Task<ResultModel<Veterinarian>> GetVeterinariansFromPracticeAsync(int id);
    }
}
