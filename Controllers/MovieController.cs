using CodeFirstBasic.Context;
using CodeFirstBasic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers
{
    public class MovieController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public MovieController(PatikaFirstDbContext context)
        {
            _context = context;
        }

        public IActionResult Add()
        {

            var newMovie = new MovieEntity()
            {
                Title = "The Pianist",
                Genre = "Drama",
                ReleaseYear = new DateTime(2002, 02, 28)

            };

            _context.Movies.Add(newMovie);
            _context.SaveChanges();

            return Ok();
        }
    }
}
