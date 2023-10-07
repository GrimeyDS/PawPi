namespace Pri.Pawpi.Core.Entities
{
    public class Pet : BaseEntity
    {
        public string Name { get; set; }
        public string? CallName { get; set; }
        public string? Breed { get; set; }
        public string? Color { get; set; }
        public string AnimalType { get; set; }
        public double? Weight { get; set; }
        public List<Consultation> Consultations { get; set; }
        public List<Medication> Medications { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}