
namespace Pri.Pawpi.Core.Services.Models.Practice
{
    public class PracticeAddModel
    {
        public string Name { get; set; }        
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public IEnumerable<int> CustomerIds { get; set; }
        public IEnumerable<int> VeterinarianIds { get; set; }
    }
}
