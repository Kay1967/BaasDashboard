namespace BaasDashboard.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? HeartRate { get; set; }
        public decimal? Steps { get; set; }
        public decimal? Stress { get; set; }
        public decimal? Sleep { get; set; } 
        public string? Inhabitability { get; set; }
        public string? ImgPath { get; set; }
    }
}
