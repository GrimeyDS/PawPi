using Pri.Pawpi.Api.Dtos.Veterinarian.Request;
using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.DTOS.Account.Request
{
    public class VeterinarianRegisterRequestDto : VeterinarianCreateDto
    {
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
