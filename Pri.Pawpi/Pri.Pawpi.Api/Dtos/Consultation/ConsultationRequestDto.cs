using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Consultation
{
    public class ConsultationRequestDto : BaseDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Diagnosis is required")]
        public string Diagnosis { get; set; }
        public string? Treatment { get; set; }
        public string? Notes { get; set; }
        [Required(ErrorMessage = "Date is required")]
        public DateTime DateOfConsultation { get; set; }
    }
}
