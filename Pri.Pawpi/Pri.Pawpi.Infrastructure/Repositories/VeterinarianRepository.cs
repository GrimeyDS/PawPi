using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class VeterinarianRepository : BaseRepository<Veterinarian>, IVeterinarianRepository
    {
        public VeterinarianRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Veterinarian>> logger) : base(PawPiDb, logger)
        {

        }

        public async override Task<IEnumerable<Veterinarian>> GetAllAsync()
        {
            return await _table.Include(v => v.Specialties)
                               .Include(v => v.Practices)
                               .Include(v => v.Consultations)
                               .ToListAsync();
        }

        public async override Task<Veterinarian> GetByIdAsync(int id)
        {
            return await _table.Include(v => v.Specialties)
                               .Include(v => v.Practices)
                               .Include(v => v.Consultations)
                               .FirstOrDefaultAsync(v => v.Id == id);
        }

        public override IQueryable<Veterinarian> GetAll()
        {
            return _table.Include(v => v.Specialties)
                         .Include(v => v.Practices)
                         .Include(v => v.Consultations)
                         .AsQueryable();
        }

        public override async Task<IEnumerable<Veterinarian>> SearchByNameAsync(string name)
        {
            var people = GetAll();
            return await people.Where(p => p.FirstName.ToUpper().Contains(name.ToUpper()) || p.LastName.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}
