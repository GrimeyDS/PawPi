using Pri.Pawpi.Api.Dtos.Practice.Response;
using Pri.Pawpi.Api.Dtos.Specialty.Response;

namespace Pri.Pawpi.Api.Dtos.Veterinarian.Response
{
    public class VeterinarianGetDto : PersonResponseDto
    {
        public string Image { get; set; }
        public IEnumerable<SpecialtyBaseDto> Specialties { get; set; }
        public IEnumerable<PracticeBaseDto> Practices { get; set; }
    }
}
