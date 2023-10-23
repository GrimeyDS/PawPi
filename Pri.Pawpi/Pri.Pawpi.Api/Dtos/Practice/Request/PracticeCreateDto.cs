using System.ComponentModel.DataAnnotations;

namespace Pri.Pawpi.Api.Dtos.Practice.Request
{
    public class PracticeCreateDto
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
        [Required(ErrorMessage = "City is required")]
        public string City { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Postal code is required")]
        public string Postal { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime OpenTime { get; set; }
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        public DateTime CloseTime { get; set; }
        public IFormFile Logo { get; set; }
        public IEnumerable<int> CustomerIds { get; set; }
        public IEnumerable<int> VeterinarianIds { get; set; }
    }
}
