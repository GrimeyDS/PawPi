using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class MedicationRepository : BaseRepository<Medication>, IMedicationRepository
    {
        public MedicationRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Medication>> logger) : base(PawPiDb, logger)
        {

        }

        public override async Task<IEnumerable<Medication>> SearchByNameAsync(string name)
        {
            var medication = GetAll();
            return await medication.Where(m => m.Name.ToUpper() == name.ToUpper()).ToListAsync();
        }
    }
}
