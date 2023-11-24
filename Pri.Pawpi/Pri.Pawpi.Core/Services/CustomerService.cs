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
            var customerToAdd = new Customer();

            string idSetSuccessMessage = SetIds(customerToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return customerToAdd.ToErrorModel(idSetSuccessMessage);

            string nameSetSuccessMessage = SetName(customerToAdd, addModel);
            if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                return customerToAdd.ToErrorModel(nameSetSuccessMessage);

            if (!addModel.Birth.CheckFutureDate())
                return customerToAdd.ToErrorModel(Constants.FutureDateMessage);

            // Update new customer entity
            customerToAdd.MapEntity(addModel);

            if (!await _repository.CreateAsync(customerToAdd))
                return customerToAdd.ToErrorModel(Constants.DBCreateMessage);

            return customerToAdd.ToResultModel();
        }

        public async Task<ResultModel<Pet>> GetPetsFromCustomerAsync(int id)
        {
            var pets = await _petRepository.GetAllAsync();

            var petsByCustomer = pets.Where(c => c.CustomerId.Equals(id));

            if (petsByCustomer.Count() == 0)
                return petsByCustomer.ToErrorModel(Constants.NoPetFoundMessage);

            return petsByCustomer.ToResultModel();
        }

        public async Task<ResultModel<Customer>> SearchByNameAsync(string name)
        {
            var customers = await _customerRepository.SearchByNameAsync(name);

            if (customers.Count() == 0)
                return customers.ToErrorModel(Constants.NoCustomerFoundMessage);

            return customers.ToResultModel();
        }

        public async Task<ResultModel<Customer>> SearchByAddressAsync(string address)
        {
            var customers = await _customerRepository.SearchByAddressAsync(address);

            if (customers.Count() == 0)
                return customers.ToErrorModel(Constants.NoCustomerFoundMessage);

            return customers.ToResultModel();
        }

        public async Task<ResultModel<Customer>> UpdateAsync(CustomerUpdateModel updateModel)
        {
            var customerToUpdate = await _repository.GetByIdAsync(updateModel.Id);

            if (customerToUpdate == null)
                return customerToUpdate.ToErrorModel(Constants.NoCustomerMessage);

            string idSetSuccessMessage = SetIds(customerToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return customerToUpdate.ToErrorModel(idSetSuccessMessage);

            if (!updateModel.Birth.CheckFutureDate())
                return customerToUpdate.ToErrorModel(Constants.FutureDateMessage);

            if (customerToUpdate.FirstName.ToUpper() != updateModel.FirstName.ToUpper() &&
                customerToUpdate.LastName.ToUpper() != updateModel.LastName.ToUpper())
            {
                string nameSetSuccessMessage = SetName(customerToUpdate, updateModel);
                if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                    return customerToUpdate.ToErrorModel(nameSetSuccessMessage);
            }

            // Update customer entity
            customerToUpdate.MapEntity(updateModel);

            if (!await _repository.UpdateAsync(customerToUpdate))
                return customerToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return customerToUpdate.ToResultModel();
        }

        private string SetIds(Customer customer, CustomerAddModel model)
        {
            var pets = _petRepository.GetAll();
            var practices = _practiceRepository.GetAll();

            var modelPetIds = model.PetIds ?? new List<int>();


            // Input checks
            if (!pets.CheckIfIdsExist(modelPetIds))
                return Constants.UnknownPetMessage;
            if (!practices.CheckIfIdExists(model.PracticeId))
                return Constants.UnknownPracticeMessage;

            if (model.PracticeId == 0)
                return Constants.NoPracticeMessage;

            // Get ids to attach as entities
            var petsToLink = pets.Where(v => modelPetIds.Contains(v.Id)).ToList();
            var practiceToLink = practices.FirstOrDefault(p => p.Id == model.PracticeId);

            customer.Pets = petsToLink;
            customer.Practice = practiceToLink;

            return string.Empty;
        }

        private string SetName(Customer customer, CustomerAddModel model)
        {
            var customers = _repository.GetAll();

            if (customers.Any(m => m.FirstName.ToUpper().Equals(model.FirstName.ToUpper())
                    && m.LastName.ToUpper().Equals(model.LastName.ToUpper())))
                return Constants.NameExistsMessage;

            customer.FirstName = model.FirstName;
            customer.LastName = model.LastName;
            return string.Empty;
        }
    }
}
