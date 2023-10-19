using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Services.Models;

namespace Pri.Pawpi.Core.Interfaces.Services
{
    public interface IServiceBase<T> where T : BaseEntity
    {
        Task<ResultModel<T>> AddAsync(T addModel);
        Task<ResultModel<T>> UpdateAsync(T updateModel);
        Task<ResultModel<T>> DeleteAsync(int id);
        Task<ResultModel<T>> GetAllAsync();
        Task<ResultModel<T>> GetByIdAsync(int id);
    }
}
