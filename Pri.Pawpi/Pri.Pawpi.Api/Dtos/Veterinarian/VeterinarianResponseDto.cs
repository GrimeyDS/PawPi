using Pri.Pawpi.Api.Dtos.Specialty;

namespace Pri.Pawpi.Api.Dtos.Veterinarian
{
    public class VeterinarianResponseDto : PersonResponseDto
    {
        public IEnumerable<SpecialtyResponseDto> Specialties { get; set; }
    }
}
