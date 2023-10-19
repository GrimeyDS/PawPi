using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Pet;
using Pri.Pawpi.Core.Services.Models.Specialty;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface ISpecialtyService : IServiceBase<Specialty>
    {
        Task<ResultModel<Specialty>> AddAsync(SpecialtyAddModel addModel);
        Task<ResultModel<Specialty>> UpdateAsync(SpecialtyUpdateModel updateModel);
    }
}
