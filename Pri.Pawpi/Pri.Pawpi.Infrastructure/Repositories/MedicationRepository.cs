using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class MedicationRepository : BaseRepository<Medication>, IMedicationRepository
    {
        public MedicationRepository(PawpiDbContext applicationDbContext, ILogger<BaseRepository<Medication>> logger) : base(PawpiDbContext, logger)
        {
        }
    }
}
