namespace Pri.Pawpi.Core.Services.Models.Specialty
{
    public class SpecialtyAddModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }

        public IEnumerable<int> VeterinarianIds { get; set; }
    }
}
