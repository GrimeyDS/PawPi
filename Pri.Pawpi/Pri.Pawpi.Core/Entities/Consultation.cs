namespace Pri.Pawpi.Core.Entities
{
    public class Consultation : BaseEntity
    {
        public string Title { get; set; }
        public string Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public string? Notes { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string ImageFile { get; set; }
        public string DocumentFile { get; set; }

        public int VeterinarianId { get; set; }
        public Veterinarian Veterinarian { get; set; }

        public int PetId { get; set; }
        public Pet Pet { get; set; }
    }
}