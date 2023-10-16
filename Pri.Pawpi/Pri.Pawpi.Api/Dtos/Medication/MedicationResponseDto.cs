using Pri.Pawpi.Api.Dtos;

namespace Pri.Pawpi.Api.Dtos.Medication
{
    public class MedicationResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public string SideEffects { get; set; }
    }
}
