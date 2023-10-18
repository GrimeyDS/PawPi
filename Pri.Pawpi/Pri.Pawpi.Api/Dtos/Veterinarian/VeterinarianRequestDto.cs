using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Veterinarian
{
    public class VeterinarianRequestDto : PersonRequestDto
    {
        public List<int> PracticeIds { get; set; }
        public List<int> SpecialtyIds { get; set; }
    }
}
