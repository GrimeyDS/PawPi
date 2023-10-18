using Pri.Pawpi.Api.Dtos.Veterinarian;

namespace Pri.Pawpi.Api.Dtos.Specialty
{
    public class SpecialtyResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<VeterinarianResponseDto> Veterinarians { get; set; }
    }
}
