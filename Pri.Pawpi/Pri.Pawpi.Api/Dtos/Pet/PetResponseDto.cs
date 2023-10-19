using Pri.Pawpi.Api.Dtos.Consultation;

namespace Pri.Pawpi.Api.Dtos.Pet
{
    public class PetResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string CallName { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string AnimalType { get; set; }
        public double Weight { get; set; }
        public IEnumerable<ConsultationResponseDto> Consultations { get; set; }
    }
}
