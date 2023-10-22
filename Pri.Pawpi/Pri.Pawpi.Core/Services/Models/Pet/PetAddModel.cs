
namespace Pri.Pawpi.Core.Services.Models.Pet
{
    public class PetAddModel
    {
        public string Name { get; set; }
        public string CallName { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string AnimalType { get; set; }
        public double? Weight { get; set; }
        public List<int> ConsultationIds { get; set; }
        public List<int> MedicationIds { get; set; }
        public int CustomerId { get; set; }
    }
}
