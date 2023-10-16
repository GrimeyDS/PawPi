namespace Pri.Pawpi.Core.Services.Models.Medication
{
    public class MedicationAddModel
    {
        public string Name { get; set; }
        public string Notes { get; set; }
        public string SideEffects { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public IEnumerable<int> PetIds { get; set; }
    }
}
