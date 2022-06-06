using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class DomainController : Controller {
        private readonly DatabaseContext _context;

        public DomainController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Domain> GetAll() {
            return _context.Domains;
        }
    }
}
