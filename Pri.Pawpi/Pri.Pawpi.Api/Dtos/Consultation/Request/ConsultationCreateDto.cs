using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Consultation.Request
{
    public class ConsultationCreateDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Diagnosis is required")]
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-YYYY}", ApplyFormatInEditMode = true)]
        public DateTime DateOfConsultation { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile Document { get; set; }
        [Required]
        public int Veterinarian { get; set; }
        [Required]
        public int Pet { get; set; }
    }
}
