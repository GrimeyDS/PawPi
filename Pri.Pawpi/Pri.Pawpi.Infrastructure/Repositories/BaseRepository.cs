using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly PawpiDbContext _applicationDbContext;
        private readonly ILogger<BaseRepository<T>> _logger;
        protected readonly DbSet<T> _table;

        public BaseRepository(PawpiDbContext applicationDbContext, ILogger<BaseRepository<T>> logger)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
            _table = _applicationDbContext.Set<T>();
        }

        public async Task<bool> CreateAsync(T toCreate)
        {
            _table.Add(toCreate);
            return await SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(T toDelete)
        {
            _table.Remove(toDelete);
            return await SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(
                t => t.Id == id);
        }

        private async Task<bool> SaveChangesAsync()
        {
            try
            {
                await _applicationDbContext.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException dbUpdateException)
            {
                _logger.LogError(dbUpdateException.Message);
                return false;
            }
        }

        public async Task<bool> UpdateAsync(T toUpdate)
        {
            var entity = await GetByIdAsync(toUpdate.Id);
            entity = toUpdate;
            return await SaveChangesAsync();
        }

        public virtual IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }

        public virtual async Task<IEnumerable<T>> SearchByNameAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
