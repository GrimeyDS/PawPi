namespace Pri.Pawpi.Api.Dtos.Consultation
{
    public class ConsultationResponseDto
    {
        public string Title { get; set; }
        public string Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public string? Notes { get; set; }
        public DateTime DateOfConsultation { get; set; }
    }
}
