using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Customer;

namespace Pri.Pawpi.Core.Services
{
    public class CustomerService : ServiceBase<Customer>, ICustomerService
    {
        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
        }

        public Task<ResultModel<Customer>> AddAsync(CustomerAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Customer>> UpdateAsync(CustomerUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
