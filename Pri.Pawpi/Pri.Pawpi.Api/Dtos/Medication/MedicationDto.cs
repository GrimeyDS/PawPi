using Pri.Pawpi.Api.Dtos;

namespace Pri.Pawpi.Api.Dtos.Medication
{
    public class MedicationDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
    }
}
