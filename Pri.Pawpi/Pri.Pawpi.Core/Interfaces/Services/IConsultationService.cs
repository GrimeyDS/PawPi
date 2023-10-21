using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Consultations;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IConsultationService : IServiceBase<Consultation>
    {
        Task<ResultModel<Consultation>> AddAsync(ConsultationAddModel addModel);
        Task<ResultModel<Consultation>> UpdateAsync(ConsultationUpdateModel updateModel);
        Task<ResultModel<Consultation>> SearchByTitleAsync(string title);
        Task<ResultModel<Consultation>> SearchByDiagnoseAsync(string diagnose);
    }
}
