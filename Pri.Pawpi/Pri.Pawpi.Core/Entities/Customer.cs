namespace Pri.Pawpi.Core.Entities
{
    public class Customer : Person
    {
        public List<Pet> Pets { get; set; }

        public int VeterinarianId { get; set; }
        public Veterinarian Veterinarian { get; set; }
    }
}
