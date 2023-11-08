using Pri.Pawpi.Api.Dtos.Pet.Response;

namespace Pri.Pawpi.Api.Dtos.Medication.Response
{
    public class MedicationGetDto : BaseDto
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public string SideEffects { get; set; }
        public IEnumerable<PetBaseDto> Pets { get; set; }
    }
}
