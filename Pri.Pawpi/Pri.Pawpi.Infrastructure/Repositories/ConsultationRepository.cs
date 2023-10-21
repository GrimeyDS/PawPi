using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class ConsultationRepository : BaseRepository<Consultation>, IConsultationRepository
    {
        public ConsultationRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Consultation>> logger) : base(PawPiDb, logger)
        {

        }

        public async override Task<IEnumerable<Consultation>> GetAllAsync()
        {
            return await _table.Include(c => c.Pet)
                               .Include(c => c.Veterinarian)
                               .ToListAsync();
        }

        public async override Task<Consultation> GetByIdAsync(int id)
        {
            return await _table.Include(c => c.Pet)
                               .Include(c => c.Veterinarian)
                               .FirstOrDefaultAsync(v => v.Id == id);
        }

        public override IQueryable<Consultation> GetAll()
        {
            return _table.Include(c => c.Pet)
                         .Include(c => c.Veterinarian)
                         .AsQueryable();
        }

        public async Task<IEnumerable<Consultation>> SearchByTitleAsync(string title)
        {
            var consultations = GetAll();
            return await consultations.Where(c => c.Title.ToUpper() == title.ToUpper()).ToListAsync();
        }

        public async Task<IEnumerable<Consultation>> SearchByDiagnoseAsync(string diagnose)
        {
            var consultations = GetAll();
            return await consultations.Where(c => c.Diagnosis.ToUpper() == diagnose.ToUpper()).ToListAsync();
        }
    }
}
