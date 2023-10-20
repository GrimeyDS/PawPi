using Pri.Pawpi.Api.Dtos.Specialty.Response;

namespace Pri.Pawpi.Api.Dtos.Veterinarian.Response
{
    public class VeterinarianGetDto : PersonResponseDto
    {
        public IEnumerable<SpecialtyBaseDto> Specialties { get; set; }
    }
}
