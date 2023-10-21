
namespace Pri.Pawpi.Api.Dtos.Veterinarian.Request
{
    public class CustomerCreateDto : PersonRequestDto
    {
        public IEnumerable<int> ConsultationIds { get; set; }
        public IEnumerable<int> SpecialtyIds { get; set; }
        public IEnumerable<int> PracticeIds { get; set; }
    }
}
