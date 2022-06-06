using BookDB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BookDB.Controllers {
    public class BookController : Controller {
        private readonly DatabaseContext _context;

        public BookController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Book> GetAll() {
            return _context.Books;
        }
    }
}
