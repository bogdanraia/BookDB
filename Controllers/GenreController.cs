using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class GenreController : Controller {
        private readonly DatabaseContext _context;

        public GenreController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Genre> GetAll() {
            return _context.Genres;
        }
    }
}
