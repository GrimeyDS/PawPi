using Pri.Pawpi.Api.Dtos.Veterinarian.Response;

namespace Pri.Pawpi.Api.Dtos.Practice.Response
{
    public class PracticeGetDto : BaseDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public string Logo { get; set; }
        public IEnumerable<VeterinarianBaseDto> Veterinarians { get; set; }
    }
}
