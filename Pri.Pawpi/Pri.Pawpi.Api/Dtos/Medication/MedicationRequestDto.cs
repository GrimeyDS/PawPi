using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Medication
{
    public class MedicationRequestDto : BaseDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        public string Notes { get; set; }
        public string SideEffects { get; set; }

        [Required(ErrorMessage = "Dosage is required")]
        public string Dosage { get; set; }

        [Required(ErrorMessage = "Frequency is required")]
        public string Frequency { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public IEnumerable<int> PetIds { get; set; }
    }
}
