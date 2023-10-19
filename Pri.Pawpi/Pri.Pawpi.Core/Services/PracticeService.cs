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
        public PracticeService(IPracticeRepository practiceRepository) : base(practiceRepository)
        {
        }

        public Task<ResultModel<Practice>> AddAsync(PracticeAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Practice>> UpdateAsync(PracticeUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Practice>> SearchByNameAsync(string name)
        {
            var practices = await _repository.SearchByNameAsync(name);

            if (practices == null)
                return practices.ToErrorModel("Practices not found");

            return practices.ToResultModel();
        }
    }
}
