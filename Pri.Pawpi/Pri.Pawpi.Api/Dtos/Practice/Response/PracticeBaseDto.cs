namespace Pri.Pawpi.Api.Dtos.Practice.Response
{
    public class PracticeBaseDto : BaseDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
    }
}
