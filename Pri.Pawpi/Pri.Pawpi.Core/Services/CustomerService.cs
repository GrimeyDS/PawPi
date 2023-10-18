using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Customer;

namespace Pri.Pawpi.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<ResultModel<Customer>> AddAsync(CustomerAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Customer>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Customer>> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return customers.ToResultModel();
        }

        public Task<ResultModel<Customer>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Customer>> UpdateAsync(CustomerUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }
    }
}
