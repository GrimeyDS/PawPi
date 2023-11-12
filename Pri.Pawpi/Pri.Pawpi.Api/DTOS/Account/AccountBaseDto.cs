using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.DTOS.Account
{
    public class AccountBaseDto
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
