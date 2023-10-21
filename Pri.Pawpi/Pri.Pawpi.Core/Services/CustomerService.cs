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
                return customerToAdd.ToErrorModel(Constants.UnknownCustomerMessage);
            if (!practices.CheckIfIdExists(addModel.PracticeId))
                return customerToAdd.ToErrorModel(Constants.UnknownCustomerMessage);

            if (!pets.CheckIdsInput(modelPetIds))
                return customerToAdd.ToErrorModel(Constants.NoPetMessage);
            if (addModel.PracticeId == 0)
                return customerToAdd.ToErrorModel(Constants.NoPracticeMessage);

            if (customers.Any(m => m.FirstName.ToUpper().Equals(addModel.FirstName.ToUpper())
                                && m.LastName.ToUpper().Equals(addModel.LastName.ToUpper())))
                return customerToAdd.ToErrorModel(Constants.NameExistsMessage);

            if (addModel.Birth >= DateTime.Now)
                return customerToAdd.ToErrorModel(Constants.FutureDateMessage);

            // Get ids to attach as entities
            var petsToLink = pets.Where(v => modelPetIds.Contains(v.Id)).ToList();
            var practiceToLink = practices.FirstOrDefault(p => p.Id == addModel.PracticeId);

            // Update new specialty entity
            customerToAdd.MapEntity(addModel);
            customerToAdd.Pets = petsToLink;
            customerToAdd.Practice = practiceToLink;


            if (!await _repository.CreateAsync(customerToAdd))
                return customerToAdd.ToErrorModel(Constants.DBCreateMessage);

            return customerToAdd.ToResultModel();
        }

        public async Task<ResultModel<Pet>> GetPetsFromCustomerAsync(int id)
        {
            var pets = await _petRepository.GetAllAsync();

            var petsByCustomer = pets.Where(c => c.CustomerId.Equals(id));

            if (petsByCustomer.Count() == 0)
                return petsByCustomer.ToErrorModel(Constants.NoPetMessage);

            return petsByCustomer.ToResultModel();
        }

        public async Task<ResultModel<Customer>> SearchByNameAsync(string name)
        {
            var customers = await _customerRepository.SearchByNameAsync(name);

            if (customers.Count() == 0)
                return customers.ToErrorModel(Constants.NoCustomerMessage);

            return customers.ToResultModel();
        }

        public async Task<ResultModel<Customer>> SearchByAddressAsync(string address)
        {
            var customers = await _customerRepository.SearchByAddressAsync(address);

            if (customers.Count() == 0)
                return customers.ToErrorModel(Constants.NoCustomerMessage);

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
                return customerToUpdate.ToErrorModel(Constants.NoCustomerMessage);

            // Input checks
            if (!pets.CheckIfIdsExist(modelPetIds))
                return customerToUpdate.ToErrorModel(Constants.UnknownPetMessage);
            if (!practices.CheckIfIdExists(updateModel.PracticeId))
                return customerToUpdate.ToErrorModel(Constants.UnknownCustomerMessage);

            if (!pets.CheckIdsInput(modelPetIds))
                return customerToUpdate.ToErrorModel(Constants.NoPetMessage);
            if (customerToUpdate.PracticeId == 0)
                return customerToUpdate.ToErrorModel(Constants.NoCustomerMessage);

            if (customers.Any(m => m.FirstName.ToUpper().Equals(updateModel.FirstName.ToUpper())
                                && m.LastName.ToUpper().Equals(updateModel.LastName.ToUpper())))
                return customerToUpdate.ToErrorModel(Constants.NameExistsMessage);

            if (updateModel.Birth >= DateTime.Now)
                return customerToUpdate.ToErrorModel(Constants.FutureDateMessage);

            // Get ids to attach as entities
            var petsToLink = pets.Where(v => modelPetIds.Contains(v.Id)).ToList();
            var practiceToLink = practices.FirstOrDefault(p => p.Id == updateModel.PracticeId);

            // Update specialty entity
            customerToUpdate.MapEntity(updateModel);
            customerToUpdate.Pets.AddRange(petsToLink);
            customerToUpdate.Practice = practiceToLink;


            if (!await _repository.UpdateAsync(customerToUpdate))
                return customerToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return customerToUpdate.ToResultModel();
        }
    }
}
