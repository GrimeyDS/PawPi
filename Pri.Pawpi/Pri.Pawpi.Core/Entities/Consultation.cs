namespace Pri.Pawpi.Core.Entities
{
    public class Consultation : BaseEntity
    {
        public string Title { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public Veterinarian Veterinarian { get; set; }
    }
}