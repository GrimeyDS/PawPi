using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Customer;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface ICustomerService : IServiceBase<Customer>
    {
        Task<ResultModel<Customer>> AddAsync(CustomerAddModel addModel);
        Task<ResultModel<Customer>> UpdateAsync(CustomerUpdateModel updateModel);
        Task<ResultModel<Customer>> SearchByNameAsync(string name);
        Task<ResultModel<Customer>> SearchByAddressAsync(string address);
        Task<ResultModel<Pet>> GetPetsFromCustomerAsync(int id);
    }
}
