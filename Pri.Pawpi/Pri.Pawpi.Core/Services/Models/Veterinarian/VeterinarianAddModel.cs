using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Services.Models.Veterinarian
{
    public class VeterinarianAddModel : Person
    {
        public List<int> SpecialtyIds { get; set; }
        public List<int> PracticeIds { get; set; }
    }
}
