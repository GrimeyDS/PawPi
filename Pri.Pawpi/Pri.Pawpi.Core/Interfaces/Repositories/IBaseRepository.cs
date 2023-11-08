using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> CreateAsync(T toCreate);
        Task<bool> UpdateAsync(T toUpdate);
        Task<bool> DeleteAsync(T toDelete);
        IQueryable<T> GetAll();
        Task<IEnumerable<T>> SearchByNameAsync(string name);
    }
}
