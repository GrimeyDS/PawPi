using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Practice;
using Pri.Pawpi.Core.Extensions;

namespace Pri.Pawpi.Core.Services
{
    public class PracticeService : ServiceBase<Practice>, IPracticeService
    {
        private readonly IPracticeRepository _practiceRepository;
        private readonly IVeterinarianRepository _veterinarianRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IFileService _fileService;

        public PracticeService(IPracticeRepository practiceRepository, IVeterinarianRepository veterinarianRepository, ICustomerRepository customerRepository, IFileService fileservice) : base(practiceRepository)
        {
            _practiceRepository = practiceRepository;
            _veterinarianRepository = veterinarianRepository;
            _customerRepository = customerRepository;
            _fileService = fileservice;
        }

        public async Task<ResultModel<Practice>> AddAsync(PracticeAddModel addModel)
        {
            var practices = _practiceRepository.GetAll();

            var customers = _customerRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();

            var modelCustomerIds = addModel.CustomerIds;
            var modelVetsIds = addModel.VeterinarianIds;

            var practiceToAdd = new Practice();

            // Input checks
            if (!vets.CheckIfIdsExist(modelVetsIds))
                return practiceToAdd.ToErrorModel(Constants.UnknownVeterinarianMessage);
            if (!customers.CheckIfIdsExist(modelCustomerIds))
                return practiceToAdd.ToErrorModel(Constants.UnknownCustomerMessage);


            if (!customers.CheckIdsInput(modelCustomerIds))
                return practiceToAdd.ToErrorModel(Constants.NoCustomerMessage);
            if (!vets.CheckIdsInput(modelVetsIds))
                return practiceToAdd.ToErrorModel(Constants.NoVeterinarianMessage);

            if (practices.Any(m => m.Name.ToUpper().Equals(addModel.Name.ToUpper())))
                return practiceToAdd.ToErrorModel(Constants.NameExistsMessage);

            // Get ids to attach as entities
            var vetsToLink = vets.Where(v => modelVetsIds.Contains(v.Id)).ToList();
            var customersToLink = customers.Where(c => modelCustomerIds.Contains(c.Id)).ToList();

            // store logo
            var fileResult = await _fileService.StoreFile<Practice>(addModel.Logo, "logos");
            if (!fileResult.IsSuccess)
                return practiceToAdd.ToErrorModel(fileResult.Error);

            // Update new pet entity
            practiceToAdd.MapEntity(addModel);
            practiceToAdd.Logo = fileResult.FileName;
            practiceToAdd.Customers = customersToLink;
            practiceToAdd.Veterinarians = vetsToLink;

            if (!await _repository.CreateAsync(practiceToAdd))
                return practiceToAdd.ToErrorModel(Constants.DBCreateMessage);

            return practiceToAdd.ToResultModel();
        }

        public async Task<ResultModel<Practice>> UpdateAsync(PracticeUpdateModel updateModel)
        {
            var practices = _practiceRepository.GetAll();

            var customers = _customerRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();

            var modelCustomerIds = updateModel.CustomerIds;
            var modelVetsIds = updateModel.VeterinarianIds;

            var practiceToUpdate = await _practiceRepository.GetByIdAsync(updateModel.Id);

            if (practiceToUpdate == null)
                return practiceToUpdate.ToErrorModel(Constants.NoPracticeFoundMessage);

            // Input checks
            if (!vets.CheckIfIdsExist(modelVetsIds))
                return practiceToUpdate.ToErrorModel(Constants.UnknownVeterinarianMessage);
            if (!customers.CheckIfIdsExist(modelCustomerIds))
                return practiceToUpdate.ToErrorModel(Constants.UnknownCustomerMessage);

            if (!vets.CheckIdsInput(modelVetsIds))
                return practiceToUpdate.ToErrorModel(Constants.NoVeterinarianMessage);

            if (practiceToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                if (practices.Any(m => m.Name.ToUpper().Equals(updateModel.Name.ToUpper())))
                    return practiceToUpdate.ToErrorModel(Constants.NameExistsMessage);
            }

            // store logo
            var fileResult = await _fileService.StoreFile<Practice>(updateModel.Logo, "logos");
            if (!fileResult.IsSuccess)
                return practiceToUpdate.ToErrorModel(fileResult.Error);

            // Get ids to attach as entities
            var customersToLink = customers.Where(c => modelCustomerIds.Contains(c.Id)).ToList();
            var vetsToLink = vets.Where(v => modelVetsIds.Contains(v.Id)).ToList();

            // Update new pet entity
            practiceToUpdate.MapEntity(updateModel);
            practiceToUpdate.Logo = fileResult.FileName;
            practiceToUpdate.Customers.AddRange(customersToLink);
            practiceToUpdate.Veterinarians.AddRange(vetsToLink);

            if (!await _repository.UpdateAsync(practiceToUpdate))
                return practiceToUpdate.ToErrorModel(Constants.DBUpdateMessage);

            return practiceToUpdate.ToResultModel();
        }

        public async Task<ResultModel<Practice>> SearchByNameAsync(string name)
        {
            var practices = await _practiceRepository.SearchByNameAsync(name);

            if (practices == null)
                return practices.ToErrorModel(Constants.NoPracticeFoundMessage);

            return practices.ToResultModel();
        }

        public async Task<ResultModel<Practice>> SearchByAddressAsync(string address)
        {
            var practices = await _practiceRepository.SearchByAddressAsync(address);

            if (practices == null)
                return practices.ToErrorModel(Constants.NoPracticeFoundMessage);

            return practices.ToResultModel();
        }

        public async Task<ResultModel<Veterinarian>> GetVeterinariansFromPracticeAsync(int id)
        {
            var vets = await _veterinarianRepository.GetAllAsync();

            var vetsByPractice = vets.Where(v => v.Practices.Any(p => p.Id == id));

            if (vetsByPractice.Count() == 0)
                return vetsByPractice.ToErrorModel(Constants.NoVeterinarianFoundMessage);

            return vetsByPractice.ToResultModel();
        }

        public async Task<ResultModel<Customer>> GetCustomersByPracticeAsync(int id)
        {
            var customers = await _customerRepository.GetAllAsync();

            var customersByPractice = customers.Where(c => c.PracticeId.Equals(id));

            if (customersByPractice.Count() == 0)
                return customersByPractice.ToErrorModel(Constants.NoCustomerFoundMessage);

            return customersByPractice.ToResultModel();
        }
    }
}
