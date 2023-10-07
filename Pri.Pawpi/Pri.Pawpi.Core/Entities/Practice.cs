using Pri.Pawpi.Core.Interfaces;

namespace Pri.Pawpi.Core.Entities
{
    public class Practice : BaseEntity, IContactEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public List<Veterinarian> Veterinarians { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
