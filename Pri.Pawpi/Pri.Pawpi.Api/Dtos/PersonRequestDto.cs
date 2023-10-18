using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos
{
    public class PersonRequestDto : BaseDto
    {
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Birthday is required")]
        public DateTime Birth { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [Required(ErrorMessage = "email is required")]
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Postal { get; set; }
    }
}
