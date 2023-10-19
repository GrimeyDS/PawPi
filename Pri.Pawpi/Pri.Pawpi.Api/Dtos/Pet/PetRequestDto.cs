using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Pet
{
    public class PetRequestDto : BaseDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string? CallName { get; set; }
        public string? Breed { get; set; }
        public string? Color { get; set; }

        [Required(ErrorMessage = "Animal type is required")]
        public string AnimalType { get; set; }
        public double? Weight { get; set; }
        //public List<ConsultationResponseDto> Consultations { get; set; }
    }
}
