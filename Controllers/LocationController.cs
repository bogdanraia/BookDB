using BookDB.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookDB.Controllers {
    public class LocationController : Controller {
        private readonly DatabaseContext _context;

        public LocationController(DatabaseContext context) {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Location> GetAll() {
            return _context.Locations;
        }
    }
}
