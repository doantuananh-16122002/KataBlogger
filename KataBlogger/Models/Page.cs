namespace KataBlogger.Models
{
    public class Page
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public string? Description { get; set; }
        public string? slug { get; set; }

    }
}