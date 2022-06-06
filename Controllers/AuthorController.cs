using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class AuthorController : Controller {
        private readonly DatabaseContext _context;

        public AuthorController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Author> GetAll() {
            return _context.Authors;
        }
    }
}
