
using Microsoft.AspNetCore.Identity;

namespace Pri.Pawpi.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public int? VeterinarianId { get; set; }
        public Veterinarian Veterinarian { get; set; }
        public int? CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int? PracticeId { get; set; }
        public Practice Practice { get; set; }
    }
}
