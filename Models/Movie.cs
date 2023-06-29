namespace Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Synopsis { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public TimeSpan Duration { get; set; }
        public IList<MovieSession> SessionList { get; set; }

        public Movie()
        {
            SessionList = new List<MovieSession>();
        }

    }
}