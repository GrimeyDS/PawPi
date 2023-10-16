using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Interfaces.Repositories
{
    public interface IPetRepository : IBaseRepository<Pet>
    {
        public Task<IEnumerable<Pet>> SearchByAnimalType(string type);
        public Task<IEnumerable<Pet>> SearchByBreed(string breed);
    }
}
