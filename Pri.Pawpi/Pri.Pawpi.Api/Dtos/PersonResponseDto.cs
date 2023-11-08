namespace Pri.Pawpi.Api.Dtos
{
    public class PersonResponseDto : BaseDto
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
