
namespace Pri.Pawpi.Api.Dtos.Veterinarian.Request
{
    public class CustomerCreateDto : PersonRequestDto
    {
        public IEnumerable<int> Pets { get; set; }
        public int PracticeId { get; set; }
    }
}
