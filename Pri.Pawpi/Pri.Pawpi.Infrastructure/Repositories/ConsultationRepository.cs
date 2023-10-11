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

        public async Task<IEnumerable<Consultation>> SearchByDateAsync(DateTime date)
        {
            var consultations = GetAll();
            return await consultations.Where(c => c.DateOfConsultation.Date == date.Date).ToListAsync();
        }

        public override async Task<IEnumerable<Consultation>> SearchByNameAsync(string name)
        {
            var consultations = GetAll();
            return await consultations.Where(s => s.Title.ToUpper() == name.ToUpper()).ToListAsync();
        }

        public async Task<IEnumerable<Consultation>> SearchByPetIdAsync(int petId)
        {
            var consultations = GetAll();
            return await consultations.Where(s => s.PetId == petId).ToListAsync();
        }

        public async Task<IEnumerable<Consultation>> SearchByVeterinarianIdAsync(int vetId)
        {
            var consultations = GetAll();
            return await consultations.Where(s => s.VeterinarianId == vetId).ToListAsync();
        }
    }
}
