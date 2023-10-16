using Pri.Pawpi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
