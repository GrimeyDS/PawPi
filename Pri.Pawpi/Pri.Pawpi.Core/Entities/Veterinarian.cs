using System.ComponentModel.DataAnnotations.Schema;

namespace Pri.Pawpi.Core.Entities
{
    public class Veterinarian : Person
    {
        public string ImageFile { get; set; }
        public List<Specialty> Specialties { get; set; }

        public List<Practice> Practices { get; set; }

        public List<Consultation> Consultations { get; set; }
    }
}
