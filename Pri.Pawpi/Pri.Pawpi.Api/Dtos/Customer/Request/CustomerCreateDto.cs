
using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Veterinarian.Request
{
    public class CustomerCreateDto : PersonRequestDto
    {
        public IEnumerable<int> PetIds { get; set; }
        public int PracticeId { get; set; }
    }
}
