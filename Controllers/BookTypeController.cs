using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class BookTypeController : Controller {
        private readonly DatabaseContext _context;

        public BookTypeController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<BookType> GetAll() {
            return _context.BookTypes;
        }
    }
}
