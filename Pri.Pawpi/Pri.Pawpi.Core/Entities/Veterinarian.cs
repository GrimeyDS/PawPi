using System.ComponentModel.DataAnnotations.Schema;

namespace Pri.Pawpi.Core.Entities
{
    public class Veterinarian : Person
    {
        public ICollection<Specialty> Specialties { get; set; }

        public ICollection<Practice> Practices { get; set; }

        public ICollection<Consultation> Consultations { get; set; }
    }
}
