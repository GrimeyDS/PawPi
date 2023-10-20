using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Services.Models.Veterinarian
{
    public class VeterinarianAddModel : Person
    {
        public IEnumerable<int> SpecialtyIds { get; set; }
        public IEnumerable<int> PracticeIds { get; set; }
        public IEnumerable<int> ConsultationIds { get; set; }
    }
}
