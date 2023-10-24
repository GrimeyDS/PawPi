
using Microsoft.AspNetCore.Http;

namespace Pri.Pawpi.Core.Services.Models.Consultations
{
    public class ConsultationAddModel
    {
        public string Title { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
        public DateTime DateOfConsultation { get; set; }
        public IFormFile Image { get; set; }
        public IFormFile Document { get; set; }
        public int VeterinarianId { get; set; }
        public int PetId { get; set; }
    }
}
