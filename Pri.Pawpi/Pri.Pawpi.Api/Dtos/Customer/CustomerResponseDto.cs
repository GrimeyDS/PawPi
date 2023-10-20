using Pri.Pawpi.Api.Dtos.Pet.Response;

namespace Pri.Pawpi.Api.Dtos.Customer
{
    public class CustomerResponseDto : PersonResponseDto
    {
        public IEnumerable<PetGetDto> Pets { get; set; }
    }
}
