namespace modul9_2211104007
{
    using Microsoft.AspNetCore.Mvc;

    namespace modul9_NIM.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class MoviesController : ControllerBase
        {
            private static List<Movie> movies = new List<Movie>
        {
            new Movie
            {
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                Stars = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Description = "A banker convicted of uxoricide forms a friendship over a quarter century with a hardened convict, while maintaining his innocence and trying to remain hopeful through simple compassion."
            },
            new Movie
            {
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                Stars = new List<string> { "Marlon Brando", "Al Pacino" },
                Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son."
            },
            new Movie
            {
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                Stars = new List<string> { "Christian Bale", "Heath Ledger" },
                Description = "When a menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman, James Gordon and Harvey Dent must work together to put an end to the madness."
            }
        };

            [HttpGet]
            public IActionResult GetMovies() => Ok(movies);

            [HttpGet("{id}")]
            public IActionResult GetMovie(int id)
            {
                if (id < 0 || id >= movies.Count)
                    return NotFound();
                return Ok(movies[id]);
            }

            [HttpPost]
            public IActionResult AddMovie([FromBody] Movie movie)
            {
                movies.Add(movie);
                return Ok(movie);
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteMovie(int id)
            {
                if (id < 0 || id >= movies.Count)
                    return NotFound();
                var removed = movies[id];
                movies.RemoveAt(id);
                return Ok(removed);
            }
        }
    }
}
