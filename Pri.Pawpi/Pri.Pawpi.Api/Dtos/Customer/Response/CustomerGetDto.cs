using Pri.Pawpi.Api.Dtos.Consultation.Response;
using Pri.Pawpi.Api.Dtos.Pet.Response;
using Pri.Pawpi.Api.Dtos.Practice.Response;


namespace Pri.Pawpi.Api.Dtos.Customer.Response
{
    public class CustomerGetDto : PersonResponseDto
    {
        public IEnumerable<PetBaseDto> Pets { get; set; }
        public PracticeBaseDto Practice { get; set; }
    }
}
