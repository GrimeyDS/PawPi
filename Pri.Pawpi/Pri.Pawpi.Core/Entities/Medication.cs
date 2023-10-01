namespace Pri.Pawpi.Core.Entities
{
    public class Medication : BaseEntity
    {
        public string Name { get; set; }
        public string Dosage { get; set; }
        public string Frequency { get; set; }
        public string Notes { get; set; }
        public string SideEffects { get; set; }

        public List<Pet> Pets { get; set; }
    }
}