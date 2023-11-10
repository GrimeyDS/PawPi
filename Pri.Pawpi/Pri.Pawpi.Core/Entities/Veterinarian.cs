using System.ComponentModel.DataAnnotations.Schema;

namespace Pri.Pawpi.Core.Entities
{
    public class Veterinarian : Person
    {
        public string ImageFile { get; set; }
        public ICollection<Specialty> Specialties { get; set; }

        public ICollection<Practice> Practices { get; set; }

        public ICollection<Consultation> Consultations { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
