using Pri.Pawpi.Api.Dtos.Practice.Response;

namespace Pri.Pawpi.Api.Dtos.Consultation.Response
{
    public class ConsultationGetDto : BaseDto
    {
        public string Title { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public string ImageUrl { get; set; }
        public string DocumentUrl { get; set; }
        public string VeterinarianName { get; set; }
        public string PetName { get; set; }
    }
}
