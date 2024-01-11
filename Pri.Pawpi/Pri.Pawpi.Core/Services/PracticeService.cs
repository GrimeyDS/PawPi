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
            var practiceToAdd = new Practice();

            string idSetSuccessMessage = SetIds(practiceToAdd, addModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return practiceToAdd.ToErrorModel(idSetSuccessMessage);

            string nameSetSuccessMessage = SetName(practiceToAdd, addModel);
            if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                return practiceToAdd.ToErrorModel(nameSetSuccessMessage);

            var logoSetSuccess = SetLogo(practiceToAdd, addModel);
            if (!string.IsNullOrEmpty(logoSetSuccess.Result))
                return practiceToAdd.ToErrorModel(logoSetSuccess.Result);

            practiceToAdd.MapEntity(addModel);

            if (!await _repository.CreateAsync(practiceToAdd))
                return practiceToAdd.ToErrorModel(Constants.DBCreateMessage);

            return practiceToAdd.ToResultModel();
        }

        public async Task<ResultModel<Practice>> UpdateAsync(PracticeUpdateModel updateModel)
        {
            var practiceToUpdate = await _practiceRepository.GetByIdAsync(updateModel.Id);

            if (practiceToUpdate == null)
                return practiceToUpdate.ToErrorModel(Constants.NoPracticeFoundMessage);

            string idSetSuccessMessage = SetIds(practiceToUpdate, updateModel);
            if (!string.IsNullOrEmpty(idSetSuccessMessage))
                return practiceToUpdate.ToErrorModel(idSetSuccessMessage);

            if (practiceToUpdate.Name.ToUpper() != updateModel.Name.ToUpper())
            {
                string nameSetSuccessMessage = SetName(practiceToUpdate, updateModel);
                if (!string.IsNullOrEmpty(nameSetSuccessMessage))
                    return practiceToUpdate.ToErrorModel(nameSetSuccessMessage);
            }

            var logoSetSuccess = SetLogo(practiceToUpdate, updateModel);
            if (!string.IsNullOrEmpty(logoSetSuccess.Result))
                return practiceToUpdate.ToErrorModel(logoSetSuccess.Result);

            practiceToUpdate.MapEntity(updateModel);

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

        private string SetIds(Practice practice, PracticeAddModel model)
        {
            var customers = _customerRepository.GetAll();
            var vets = _veterinarianRepository.GetAll();

            var modelCustomerIds = model.CustomerIds ?? new List<int>();
            var modelVetsIds = model.VeterinarianIds ?? new List<int>();

            // Input checks
            if (!vets.CheckIfIdsExist(modelVetsIds))
                return Constants.UnknownVeterinarianMessage;
            if (!customers.CheckIfIdsExist(modelCustomerIds))
                return Constants.UnknownCustomerMessage;

            if (!vets.CheckIdsInput(modelVetsIds))
                return Constants.NoVeterinarianMessage;

            var customersToLink = customers.Where(c => modelCustomerIds.Contains(c.Id)).ToList();
            var vetsToLink = vets.Where(v => modelVetsIds.Contains(v.Id)).ToList();

            //practice.Customers = customersToLink;
            practice.Veterinarians = vetsToLink;

            return string.Empty;
        }

        private string SetName(Practice practice, PracticeAddModel model)
        {
            var practices = _repository.GetAll();

            if (practices.Any(m => m.Name.ToUpper().Equals(model.Name.ToUpper())))
                return Constants.NameExistsMessage;

            practice.Name = model.Name;
            return string.Empty;
        }

        private async Task<string> SetLogo(Practice practice, PracticeAddModel model)
        {
            if (model.Logo is null)
                return string.Empty;

            var logoResult = await _fileService.StoreFile<Practice>(model.Logo, "Logos");
            if (!logoResult.IsSuccess)
                return logoResult.Error;

            practice.Logo = logoResult.FileName;
            return string.Empty;
        }
    }
}
