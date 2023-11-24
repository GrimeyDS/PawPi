using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.DTOS.Account
{
    public class AccountBaseDto
    {
        [Required]
        [EmailAddress]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
