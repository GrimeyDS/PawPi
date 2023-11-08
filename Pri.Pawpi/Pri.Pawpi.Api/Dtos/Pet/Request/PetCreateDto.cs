using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Pet.Request
{
    public class PetCreateDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string CallName { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        [Required(ErrorMessage = "Animal type is required")]
        public string AnimalType { get; set; }
        public double? Weight { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile Pedigree { get; set; }
        public List<int> ConsultationIds { get; set; }
        public List<int> MedicationIds { get; set; }
        [Required(ErrorMessage = "Customer is required")]
        public int CustomerId { get; set; }
    }
}
