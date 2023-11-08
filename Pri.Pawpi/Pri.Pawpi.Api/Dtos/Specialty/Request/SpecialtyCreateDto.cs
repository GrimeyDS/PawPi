using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Specialty.Request
{
    public class SpecialtyCreateDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public IEnumerable<int> VeterinarianIds { get; set; }
    }
}
