
using Microsoft.AspNetCore.Identity;

namespace Pri.Pawpi.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public Veterinarian Veterinarian { get; set; }
        public Customer Customer { get; set; }
    }
}
