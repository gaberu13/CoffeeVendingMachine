using CoffeeVending.Models;
using CoffeeVending.Models.DTO;
using CoffeeVending.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoffeeVending.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _service;

        public OrderController(IOrderService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Order> Get()
        {
            var orders = _service.GetOrders();
            return orders;
        }
    }
}