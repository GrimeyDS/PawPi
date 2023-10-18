using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;
using System.Xml.Linq;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class PracticeRepository : BaseRepository<Practice>, IPracticeRepository
    {
        public PracticeRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Practice>> logger) : base(PawPiDb, logger)
        {

        }

        public async override Task<IEnumerable<Practice>> GetAllAsync()
        {
            return await _table.Include(p => p.Veterinarians)
                                .Include(p => p.Customers)
                                .ToListAsync();
        }

        public async override Task<Practice> GetByIdAsync(int id)
        {
            return await _table.Include(p => p.Veterinarians)
                               .Include(p => p.Customers)
                               .FirstOrDefaultAsync(t => t.Id == id);
        }

        public override IQueryable<Practice> GetAll()
        {
            return _table.Include(p => p.Veterinarians)
                         .Include(p => p.Customers)
                         .AsQueryable();
        }

        public async Task<DateTime?> GetClosureTime(int practiceId)
        {
            var practice = await GetByIdAsync(practiceId);
            return practice.CloseTime;
        }

        public async Task<DateTime?> GetOpenTime(int practiceId)
        {
            var practice = await GetByIdAsync(practiceId);
            return practice.OpenTime;
        }

        public async Task<IEnumerable<Practice>> SearchByCity(string city)
        {
            var practices = GetAll();
            return await practices.Where(p => p.City.ToUpper().Contains(city.ToUpper())).ToListAsync();
        }

        public override async Task<IEnumerable<Practice>> SearchByNameAsync(string name)
        {
            var practices = GetAll();
            return await practices.Where(p => p.Name.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}