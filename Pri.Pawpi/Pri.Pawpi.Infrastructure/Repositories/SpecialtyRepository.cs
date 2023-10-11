using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class SpecialtyRepository : BaseRepository<Specialty>, ISpecialtyRepository
    {
        public SpecialtyRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Specialty>> logger) : base(PawPiDb, logger)
        {

        }

        public override async Task<IEnumerable<Specialty>> SearchByNameAsync(string name)
        {
            var specialties = GetAll();
            return await specialties.Where(s => s.Name.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}
