namespace BaasDashboard.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? HeartRate { get; set; }
        public decimal? Steps { get; set; }
        public string? ImgPath { get; set; }
    }
}
