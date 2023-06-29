using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace CineminhaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private TempMockRepository _repository;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
            _repository = new TempMockRepository();
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _repository.ReturnMovies();
        }
    }
}
