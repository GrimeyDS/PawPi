using Pri.Pawpi.Api.Dtos.Specialty;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Api.Dtos.Veterinarian
{
    public class VeterinarianResponseDto : PersonResponseDto
    {
        //public IEnumerable<PracticeResponseDto> Practices { get; set; }

        public IEnumerable<SpecialtyResponseDto> Specialties { get; set; }
    }
}
