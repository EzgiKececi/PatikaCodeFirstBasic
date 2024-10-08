using CodeFirstBasic.Context;
using CodeFirstBasic.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstBasic.Controllers
{
    public class GameController : Controller
    {
        private readonly PatikaFirstDbContext _context;

        public GameController(PatikaFirstDbContext context)
        {
            _context = context;
        }
        public IActionResult Add()
        {

            var newGame = new GameEntity()
            {
                Name = "CS:GO",
                Platform = "PC",
                Rating = 10
            };

            _context.Games.Add(newGame);
            _context.SaveChanges();

            return Ok();
        }
    }
}
