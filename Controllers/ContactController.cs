using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class ContactController : Controller {
        private readonly DatabaseContext _context;

        public ContactController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Contact> GetAll() {
            return _context.Contacts;
        }
    }
}
