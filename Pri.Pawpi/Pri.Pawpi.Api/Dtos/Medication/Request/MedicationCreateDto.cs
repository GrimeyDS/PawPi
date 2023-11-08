using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Medication.Request
{
    public class MedicationCreateDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Notes { get; set; }
        public string SideEffects { get; set; }

        [Required(ErrorMessage = "Dosage is required")]
        public string Dosage { get; set; }

        [Required(ErrorMessage = "Frequency is required")]
        public string Frequency { get; set; }
        public IEnumerable<int> PetIds { get; set; }
    }
}
