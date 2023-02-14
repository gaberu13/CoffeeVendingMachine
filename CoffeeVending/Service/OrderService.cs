using CoffeeVending.Data;
using CoffeeVending.Models.DTO;
using CoffeeVending.Service.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeVending.Service
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public dynamic GetOrders()
        {
            var orders = _context.Orders.Include(x => x.Coffee).ToList();
            return orders;
        }
    }
}
