using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Core.Services.Models;
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

        public async Task<IEnumerable<Practice>> SearchByAddressAsync(string address)
        {
            var practices = GetAll();
            return await practices.Where(p => p.Address.ToUpper().Contains(address.ToUpper()) ||
                                              p.City.ToUpper().Contains(address.ToUpper()) ||
                                              p.Postal.ToUpper().Contains(address.ToUpper()))
                                              .ToListAsync();
        }

        public override async Task<IEnumerable<Practice>> SearchByNameAsync(string name)
        {
            var practices = GetAll();
            return await practices.Where(p => p.Name.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}