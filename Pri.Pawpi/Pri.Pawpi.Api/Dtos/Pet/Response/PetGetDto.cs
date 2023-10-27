
using Pri.Pawpi.Api.Dtos.Consultation.Response;
using Pri.Pawpi.Api.Dtos.Customer.Response;

namespace Pri.Pawpi.Api.Dtos.Pet.Response
{
    public class PetGetDto : BaseDto
    {
        public string Name { get; set; }
        public string CallName { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string AnimalType { get; set; }
        public double? Weight { get; set; }
        public string ImageUrl { get; set; }
        public string PedigreeUrl { get; set; }
        public CustomerBaseDto Customer { get; set; }
        public ConsultationBaseDto LastConsultation { get; set; }
    }
}
