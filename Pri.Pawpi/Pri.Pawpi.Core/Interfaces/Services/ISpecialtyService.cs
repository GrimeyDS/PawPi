using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;
using Pri.Pawpi.Core.Services.Models.Specialty;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface ISpecialtyService
    {
        Task<ResultModel<Specialty>> AddAsync(SpecialtyAddModel addModel);
        Task<ResultModel<Specialty>> UpdateAsync(SpecialtyUpdateModel updateModel);
        Task<ResultModel<Specialty>> DeleteAsync(int id);
        Task<ResultModel<Specialty>> GetAllAsync();
        Task<ResultModel<Specialty>> GetByIdAsync(int id);
    }
}
