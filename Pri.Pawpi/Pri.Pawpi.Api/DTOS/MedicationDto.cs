namespace Pri.Pawpi.Api.DTOS
{
    public class MedicationDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SideEffects { get; set; }
    }
}
