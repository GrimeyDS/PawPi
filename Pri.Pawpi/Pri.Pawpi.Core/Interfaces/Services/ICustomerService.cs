using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Customer;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface ICustomerService
    {
        Task<ResultModel<Customer>> AddAsync(CustomerAddModel addModel);
        Task<ResultModel<Customer>> UpdateAsync(CustomerUpdateModel updateModel);
        Task<ResultModel<Customer>> DeleteAsync(int id);
        Task<ResultModel<Customer>> GetAllAsync();
        Task<ResultModel<Customer>> GetByIdAsync(int id);
    }
}
