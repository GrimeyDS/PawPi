
using Pri.Pawpi.Core.Entities;
using System.Security.Claims;

namespace Pri.Pawpi.Api.Extensions
{
    public static class IdentityValidationExtensions
    {
        public static bool CheckUserIdentity(this IEnumerable<Claim> claims, Pet pet)
        {
            var userId = claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.PrimarySid));
            var userRole = claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role));

            // check if requested pet is a pet of the logged in customer
            if (userRole.Value == "Customer")
            {
                if (userId.Value != pet.CustomerId.ToString())
                    return false;
            }
            return true;
        }

        public static bool CheckUserIdentity(this IEnumerable<Claim> claims, Consultation cons)
        {
            var userId = claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.PrimarySid));
            var userRole = claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role));

            if (userRole.Value == "Customer")
            {
                if (userId.Value != cons.Pet.CustomerId.ToString())
                    return false;
            }
            return true;
        }

        public static bool CheckUserIdentity(this IEnumerable<Claim> claims, int id)
        {
            var userId = claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.PrimarySid));
            var userRole = claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.Role));

            if (userRole.Value == "Customer")
            {
                if (userId.Value != id.ToString())
                    return false;
            }
            return true;
        }
    }
}
