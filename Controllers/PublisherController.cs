using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class PublisherController : Controller {
        private readonly DatabaseContext _context;

        public PublisherController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Publisher> GetAll() {
            return _context.Publishers;
        }
    }
}
