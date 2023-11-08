using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class PetRepository : BaseRepository<Pet>, IPetRepository
    {
        public PetRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Pet>> logger) : base(PawPiDb, logger)
        {

        }

        public async override Task<IEnumerable<Pet>> GetAllAsync()
        {
            return await _table.Include(p => p.Customer)
                               .Include(p => p.Consultations)
                               .Include(p => p.Medications)
                               .ToListAsync();
        }

        public async override Task<Pet> GetByIdAsync(int id)
        {
            return await _table.Include(p => p.Customer)
                               .Include(p => p.Consultations)
                               .Include(p => p.Medications)
                               .FirstOrDefaultAsync(p => p.Id == id);
        }

        public override IQueryable<Pet> GetAll()
        {
            return _table.Include(p => p.Customer)
                         .Include(p => p.Consultations)
                         .Include(p => p.Medications)
                         .AsQueryable();
        }

        public async Task<IEnumerable<Pet>> SearchByAnimalTypeAsync(string type)
        {
            var pets = GetAll();
            return await pets.Where(p => p.AnimalType.ToUpper().Contains(type.ToUpper())).ToListAsync();
        }

        public async Task<IEnumerable<Pet>> SearchByBreedAsync(string breed)
        {
            var pets = GetAll();
            return await pets.Where(p => p.Breed.ToUpper().Contains(breed.ToUpper())).ToListAsync();
        }

        public override async Task<IEnumerable<Pet>> SearchByNameAsync(string name)
        {
            var pets = GetAll();
            return await pets.Where(p => p.Name.ToUpper().Contains(name.ToUpper()) || p.CallName.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}
