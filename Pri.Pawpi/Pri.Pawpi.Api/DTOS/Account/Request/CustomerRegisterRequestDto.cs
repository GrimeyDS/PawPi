using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.DTOS.Account.Request
{
    public class CustomerRegisterRequestDto : CustomerCreateDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}