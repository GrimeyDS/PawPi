using Pri.Pawpi.Api.Dtos.Specialty.Response;

namespace Pri.Pawpi.Api.Dtos.Veterinarian
{
    public class VeterinarianResponseDto : PersonResponseDto
    {
        public IEnumerable<SpecialtyGetDto> Specialties { get; set; }
    }
}
