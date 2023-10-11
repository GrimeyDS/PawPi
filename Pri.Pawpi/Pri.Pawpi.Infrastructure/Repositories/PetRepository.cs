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

        public async Task<IEnumerable<Pet>> SearchByAnimalType(string type)
        {
            var pets = GetAll();
            return await pets.Where(p => p.AnimalType.ToUpper().Contains(type.ToUpper())).ToListAsync();
        }

        public async Task<IEnumerable<Pet>> SearchByBreed(string breed)
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
