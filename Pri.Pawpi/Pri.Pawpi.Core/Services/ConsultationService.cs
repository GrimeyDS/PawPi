using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Interfaces.Services;
using Pri.Pawpi.Core.Services.Models.Practice;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Extensions;
using Pri.Pawpi.Core.Services.Models.Consultations;

namespace Pri.Pawpi.Core.Services
{
    public class ConsultationService : ServiceBase<Consultation>, IConsultationService
    {
        public ConsultationService(IConsultationRepository consultationRepository) : base(consultationRepository)
        {
        }

        public Task<ResultModel<Consultation>> AddAsync(ConsultationAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public Task<ResultModel<Consultation>> UpdateAsync(ConsultationUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ResultModel<Consultation>> SearchByNameAsync(string name)
        {
            var consultations = await _repository.SearchByNameAsync(name);

            if (consultations == null)
                return consultations.ToErrorModel("Consultations not found");

            return consultations.ToResultModel();
        }
    }
}
