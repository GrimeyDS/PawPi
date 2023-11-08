using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Customer>> logger) : base(PawPiDb, logger)
        {

        }

        public async override Task<IEnumerable<Customer>> GetAllAsync()
        {
            return await _table.Include(c => c.Pets)
                               .Include(c => c.Practice)
                               .ToListAsync();
        }

        public async override Task<Customer> GetByIdAsync(int id)
        {
            return await _table.Include(c => c.Pets)
                               .Include(c => c.Practice)
                               .FirstOrDefaultAsync(v => v.Id == id);
        }

        public override IQueryable<Customer> GetAll()
        {
            return _table.Include(c => c.Pets)
                         .Include(c => c.Practice)
                         .AsQueryable();
        }

        public override async Task<IEnumerable<Customer>> SearchByNameAsync(string name)
        {
            var people = GetAll();
            return await people.Where(p => p.FirstName.ToUpper().Contains(name.ToUpper()) || p.LastName.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }

        public async Task<IEnumerable<Customer>> SearchByAddressAsync(string address)
        {
            var people = GetAll();
            return await people.Where(p => p.Address.ToUpper().Contains(address.ToUpper()) || 
                                           p.City.ToUpper().Contains(address.ToUpper()) ||
                                           p.Postal.ToUpper().Contains(address.ToUpper()))
                                           .ToListAsync();
        }
    }
}
