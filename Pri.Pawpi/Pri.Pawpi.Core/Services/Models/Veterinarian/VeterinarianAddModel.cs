using Microsoft.AspNetCore.Http;
using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Services.Models.Veterinarian
{
    public class VeterinarianAddModel : PersonModel
    {
        public IFormFile Image { get; set; }
        public IEnumerable<int> SpecialtyIds { get; set; }
        public IEnumerable<int> PracticeIds { get; set; }
        public IEnumerable<int> ConsultationIds { get; set; }
    }
}
