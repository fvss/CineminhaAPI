using Models;

namespace DataAccess
{
    public class TempMockRepository
    {
        List<ExibitionHall> _halls;
        List<Movie> _movies;

        public IEnumerable<Movie> ReturnMovies()
        {
            CreateExibitionHalls();
            CreateMovies();
            CreateMovieSessions();

            return _movies;

        }

        private void CreateExibitionHalls()
        {
            _halls = new List<ExibitionHall>();

            ExibitionHall addHall;

            for(int i = 1; i <= 3; i++)
            {
                addHall = new ExibitionHall();
                addHall.Id = i;
                addHall.Name = $"Sala {i}";
                addHall.IsImax = i % 2 == 0 ? true : false;
                addHall.HasSeatForCouples = i % 2 == 0 ? true : false;
                addHall.Capacity = 120 + (i * 2);
                _halls.Add(addHall);
            }

        }

        private void CreateMovies()
        {
            _movies = new List<Movie>();

            _movies.Add(new Movie() {
                Id = 1,
                Name = "Avatar",
                Genre = "Ação",
                Duration = new TimeSpan(2, 35, 23),
                Director = "James Cameron",
                Synopsis = @"Em um mundo alienígena, um ex-fuzileiro se
                            une aos nativos para proteger seu lar, descobrindo
                            seu verdadeiro propósito."
            });

            _movies.Add(new Movie()
            {
                Id = 2,
                Name = "Whiplash",
                Genre = "Drama",
                Duration = new TimeSpan(2, 12, 33),
                Director = "Damien Chazelle",
                Synopsis = @"Jovem baterista luta por perfeição musical sob a tutela
                    implacável de um professor exigente. Ambição e sacrifício se entrelaçam."
            });

            _movies.Add(new Movie()
            {
                Id = 3,
                Name = "Interstellar",
                Genre = "Drama",
                Duration = new TimeSpan(2, 12, 33),
                Director = "Christopher Nolan",
                Synopsis = @"Um grupo de exploradores espaciais parte em uma missão
                            para salvar a humanidade, buscando um novo lar além do sistema solar."
            });

            _movies.Add(new Movie()
            {
                Id = 4,
                Name = "Matrix",
                Genre = "Ação",
                Duration = new TimeSpan(2, 12, 33),
                Director = "Lana Wachowski, Lilly Wachowski",
                Synopsis = @"'Matrix' segue a jornada de Neo, um programador que descobre a
                            verdade sobre a realidade e se une à resistência humana contra
                            as máquinas que controlam o mundo."
            });

        }

        private void CreateMovieSessions()
        {
            Random random = new Random();
            int id = 1;

            foreach (var item in _movies)
            {

                for (int i = 1; i <= 5; i++)
                {
                    int v = random.Next(1, 4);
                    int h = random.Next(-4, 8);
                    int m = random.Next(-40, 10);

                    item.SessionList.Add(new MovieSession()
                    {
                        Id = i,
                        ExibitionHall = _halls.FirstOrDefault(i => i.Id == v),
                        Is3DTime = v % 2 == 0 ? false : true,
                        ExibitTimeStart = (new TimeOnly(12 + h, 45 + m)).ToString("HH:mm"),
                        IsPromotionalTime = new TimeOnly(12 + h, 45 + m) < new TimeOnly(12, 00) ? true : false
                    });
                }
            }
        }

    }
}