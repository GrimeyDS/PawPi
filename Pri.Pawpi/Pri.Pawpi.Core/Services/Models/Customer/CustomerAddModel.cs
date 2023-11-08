using Pri.Pawpi.Core.Entities;

namespace Pri.Pawpi.Core.Services.Models.Customer
{
    public class CustomerAddModel : PersonModel
    {
        public IEnumerable<int> PetIds { get; set; }
        public int PracticeId { get; set;}
    }
}
