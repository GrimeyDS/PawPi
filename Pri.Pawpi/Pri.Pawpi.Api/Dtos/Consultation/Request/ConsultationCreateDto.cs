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
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfConsultation { get; set; }
        public int VeterinarianId { get; set; }
        public int PetId { get; set; }
    }
}
