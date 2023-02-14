using CoffeeVending.Models;
using CoffeeVending.Models.DTO;
using CoffeeVending.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeVending.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeVendingController : ControllerBase
    {
        private readonly ICoffeeVendingService _service;

        public CoffeeVendingController(ICoffeeVendingService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Coffee> Get()
        {
            var coffees = _service.GetCoffeeVending();
            return coffees;
        }

        [HttpPost]
        public dynamic Order(OrderDTO order)
        {
            _service.CreateOrder(order);
            return Ok();
        }
    }
}