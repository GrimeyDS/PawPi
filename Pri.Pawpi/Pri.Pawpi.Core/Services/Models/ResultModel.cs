namespace Pri.Pawpi.Core.Services.Models
{
    public class ResultModel<T>
    {
        public bool IsSuccess { get; set; }
        public T Item { get; set; }
        public IEnumerable<T> Items { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
