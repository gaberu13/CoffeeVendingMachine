using CoffeeVending.Data;
using CoffeeVending.Models;
using CoffeeVending.Models.DTO;
using CoffeeVending.Service.Interfaces;

namespace CoffeeVending.Service
{
    public class CoffeeVendingService : ICoffeeVendingService
    {
        private readonly ApplicationDbContext _context;

        public CoffeeVendingService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(OrderDTO order)
        {
            var newOrder = new Order();

            newOrder.CoffeeId = order.CoffeeId;
            newOrder.Suger = order.Suger;
            newOrder.Creamer = order.Creamer;
            newOrder.Caramelle = order.Caramelle;
            newOrder.Milk = order.Milk;
            newOrder.Decofe = order.Decofe;


            _context.Orders.Add(newOrder);
            _context.SaveChanges();
        }

        public List<Coffee> GetCoffeeVending()
        {
            var coffees = _context.Coffees.ToList();
            return coffees;
        }
    }
}
