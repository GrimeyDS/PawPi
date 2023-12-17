
namespace Pri.Pawpi.Api.Dtos.Veterinarian.Request
{
    public class VeterinarianCreateDto : PersonRequestDto
    {
        public IFormFile Image { get; set; }
        public IEnumerable<int> Consultations { get; set; }
        public IEnumerable<int> Specialties { get; set; }
        public IEnumerable<int> Practices { get; set; }
    }
}
