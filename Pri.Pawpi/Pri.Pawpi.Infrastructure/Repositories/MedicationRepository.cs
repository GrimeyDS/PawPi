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

        public async override Task<IEnumerable<Medication>> GetAllAsync()
        {
            return await _table.Include(m => m.Pets)
                               .ToListAsync();
        }

        public async override Task<Medication> GetByIdAsync(int id)
        {
            return await _table.Include(m => m.Pets)
                                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public override IQueryable<Medication> GetAll()
        {
            return _table.Include(m => m.Pets)
                         .AsQueryable();
        }

        public override async Task<IEnumerable<Medication>> SearchByNameAsync(string name)
        {
            var medicine = GetAll();
            return await medicine.Where(m => m.Name.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }

        public async Task<IEnumerable<Medication>> SearchBySideEffectAsync(string sideEffect)
        {
            var medicine = GetAll();
            return await medicine.Where(m => m.SideEffects.ToUpper().Contains(sideEffect.ToUpper())).ToListAsync();
        }
    }
}
