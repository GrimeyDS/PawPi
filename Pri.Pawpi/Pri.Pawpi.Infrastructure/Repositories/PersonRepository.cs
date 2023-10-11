using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pri.Pawpi.Core.Entities;
using Pri.Pawpi.Core.Interfaces.Repositories;
using Pri.Pawpi.Infrastructure.Data;

namespace Pri.Pawpi.Infrastructure.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(PawpiDbContext PawPiDb, ILogger<BaseRepository<Person>> logger) : base(PawPiDb, logger)
        {

        }

        public override async Task<IEnumerable<Person>> SearchByNameAsync(string name)
        {
            var people = GetAll();
            return await people.Where(s => s.FirstName.ToUpper().Contains(name.ToUpper()) || s.LastName.ToUpper().Contains(name.ToUpper())).ToListAsync();
        }
    }
}
