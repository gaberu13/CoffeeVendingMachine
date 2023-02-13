using CoffeeVending.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeVending.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeVendingController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CoffeeVendingController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public dynamic Get()
        {
            var coffees = _context.Coffees.ToList();
            return coffees;
        }
    }
}