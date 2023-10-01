using Pri.Pawpi.Core.Interfaces;

namespace Pri.Pawpi.Core.Entities
{
    public abstract class Person : BaseEntity, IContactEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
    }
}