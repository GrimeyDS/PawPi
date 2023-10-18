namespace Pri.Pawpi.Api.Dtos.Veterinarian
{
    public class VeterinarianResponseDto : PersonResponseDto
    {
        public List<int> PracticeIds { get; set; }
        public List<int> SpecialtyIds { get; set; }
    }
}
