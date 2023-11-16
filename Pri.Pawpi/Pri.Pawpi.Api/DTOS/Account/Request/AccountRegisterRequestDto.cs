using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.DTOS.Account.Request
{
    public class AccountRegisterRequestDto : AccountBaseDto
    {
        [Required]
        [Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}