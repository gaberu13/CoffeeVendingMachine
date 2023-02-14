using CoffeeVending.Models;

namespace CoffeeVending.Service.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetOrders();
    }
}
