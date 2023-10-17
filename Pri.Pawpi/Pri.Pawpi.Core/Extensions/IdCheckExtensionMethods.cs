using Pri.Pawpi.Core.Entities;


namespace Pri.Pawpi.Core.Extensions
{
    public static class PetExtensions
    {
        public static bool CheckIfPetsExist(this IQueryable<Pet> pets, IEnumerable<int> petIdsToCheck)
        {
            if (pets.Where(p => petIdsToCheck.Contains(p.Id)).Count() != petIdsToCheck.Count())
                return false;
            return true;
        }

        public static bool CheckIfVetsExist(this IQueryable<Veterinarian> vets, IEnumerable<int> vetIdsToCheck)
        {
            if (vets.Where(v => vetIdsToCheck.Contains(v.Id)).Count() != vetIdsToCheck.Count())
                return false;
            return true;
        }
    }
}
