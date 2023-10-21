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
        private readonly ICustomerRepository _customerRepository;
        private readonly IPetRepository _petRepository;
        private readonly IPracticeRepository _practiceRepository;

        public CustomerService(ICustomerRepository customerRepository, IPetRepository petRepository, IPracticeRepository practiceRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
            _petRepository = petRepository;
            _practiceRepository = practiceRepository;
        }

        public async Task<ResultModel<Customer>> AddAsync(CustomerAddModel addModel)
        {
            var customers = _repository.GetAll();
            var pets = _petRepository.GetAll();
            var practices = _practiceRepository.GetAll();

            var modelPetIds = addModel.PetIds;

            var customerToAdd = new Customer();

            // Input checks
            if (!pets.CheckIfIdsExist(modelPetIds))
                return customerToAdd.ToErrorModel("Unknown pets!");
            if (practices.All(p => p.Id != addModel.PracticeId))
                return customerToAdd.ToErrorModel("Unknown practice!");

            if (!pets.CheckIdsInput(modelPetIds))
                return customerToAdd.ToErrorModel("Please provide a pet");
            if (addModel.PracticeId == 0)
                return customerToAdd.ToErrorModel("Please provide a practice");

            if (customers.Any(m => m.FirstName.ToUpper().Equals(addModel.FirstName.ToUpper())
                                && m.LastName.ToUpper().Equals(addModel.LastName.ToUpper())))
                return customerToAdd.ToErrorModel("Name already exists");

            if (addModel.Birth >= DateTime.Now)
                return customerToAdd.ToErrorModel("Birth date cannot be in the future");

            // Get ids to attach as entities
            var petsToLink = pets.Where(v => modelPetIds.Contains(v.Id)).ToList();
            var practiceToLink = practices.FirstOrDefault(p => p.Id == addModel.PracticeId);

            // Update new specialty entity
            customerToAdd.MapEntity(addModel);
            customerToAdd.Pets = petsToLink;
            customerToAdd.Practice = practiceToLink;


            if (!await _repository.CreateAsync(customerToAdd))
                return customerToAdd.ToErrorModel("Something went wrong while adding customer");

            return customerToAdd.ToResultModel();
        }

        public async Task<ResultModel<Pet>> GetPetsFromCustomerAsync(int id)
        {
            var pets = await _petRepository.GetAllAsync();

            var petsByCustomer = pets.Where(c => c.CustomerId.Equals(id));

            if (petsByCustomer.Count() == 0)
                return petsByCustomer.ToErrorModel("No pets found");

            return petsByCustomer.ToResultModel();
        }

        public async Task<ResultModel<Customer>> SearchByNameAsync(string name)
        {
            var customers = await _customerRepository.SearchByNameAsync(name);

            if (customers.Count() == 0)
                return customers.ToErrorModel("No customers found");

            return customers.ToResultModel();
        }

        public async Task<ResultModel<Customer>> SearchByAddressAsync(string address)
        {
            var customers = await _customerRepository.SearchByAddressAsync(address);

            if (customers.Count() == 0)
                return customers.ToErrorModel("No customers found");

            return customers.ToResultModel();
        }

        public async Task<ResultModel<Customer>> UpdateAsync(CustomerUpdateModel updateModel)
        {
            var customers = _repository.GetAll();
            var pets = _petRepository.GetAll();
            var practices = _practiceRepository.GetAll();

            var modelPetIds = updateModel.PetIds;

            var customerToUpdate = await _repository.GetByIdAsync(updateModel.Id);

            if (customerToUpdate == null)
                return customerToUpdate.ToErrorModel("Customer not found");

            // Input checks
            if (!pets.CheckIfIdsExist(modelPetIds))
                return customerToUpdate.ToErrorModel("Unknown pets!");
            if (practices.All(p => p.Id != updateModel.PracticeId))
                return customerToUpdate.ToErrorModel("Unknown practice!");

            if (!pets.CheckIdsInput(modelPetIds))
                return customerToUpdate.ToErrorModel("Please provide a pet");
            if (customerToUpdate.PracticeId == 0)
                return customerToUpdate.ToErrorModel("Please provide a practice");

            if (customers.Any(m => m.FirstName.ToUpper().Equals(updateModel.FirstName.ToUpper())
                                && m.LastName.ToUpper().Equals(updateModel.LastName.ToUpper())))
                return customerToUpdate.ToErrorModel("Name already exists");

            if (updateModel.Birth >= DateTime.Now)
                return customerToUpdate.ToErrorModel("Birth date cannot be in the future");

            // Get ids to attach as entities
            var petsToLink = pets.Where(v => modelPetIds.Contains(v.Id)).ToList();
            var practiceToLink = practices.FirstOrDefault(p => p.Id == updateModel.PracticeId);

            // Update specialty entity
            customerToUpdate.MapEntity(updateModel);
            customerToUpdate.Pets.AddRange(petsToLink);
            customerToUpdate.Practice = practiceToLink;


            if (!await _repository.UpdateAsync(customerToUpdate))
                return customerToUpdate.ToErrorModel("Something went wrong while updating customer");

            return customerToUpdate.ToResultModel();
        }
    }
}
