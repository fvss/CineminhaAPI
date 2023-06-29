namespace Models
{
    public class MovieSession
    {
        public int Id { get; set; }
        public string ExibitTimeStart { get; set; }
        public bool IsPromotionalTime { get; set; }
        public bool Is3DTime { get; set; }
        public ExibitionHall ExibitionHall { get; set; }
        public Movie Movie { get; set; }
    }
}
