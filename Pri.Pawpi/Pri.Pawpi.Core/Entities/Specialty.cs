namespace Pri.Pawpi.Core.Entities
{
    public class Specialty : BaseEntity
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public List<Veterinarian> Veterinarians { get; set; }
    }
}