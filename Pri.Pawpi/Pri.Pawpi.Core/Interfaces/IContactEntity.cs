namespace Pri.Pawpi.Core.Interfaces
{
    public interface IContactEntity
    {
        string Address { get; set; }
        string City { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string Postal { get; set; }
    }
}