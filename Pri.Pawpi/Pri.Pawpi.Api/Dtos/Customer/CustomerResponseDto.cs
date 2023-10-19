using Pri.Pawpi.Api.Dtos.Pet;

namespace Pri.Pawpi.Api.Dtos.Customer
{
    public class CustomerResponseDto : PersonResponseDto
    {
        public IEnumerable<PetResponseDto> Pets { get; set; }
    }
}
