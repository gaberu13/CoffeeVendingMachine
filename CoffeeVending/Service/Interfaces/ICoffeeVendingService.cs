using CoffeeVending.Models;
using CoffeeVending.Models.DTO;

namespace CoffeeVending.Service.Interfaces
{
    public interface ICoffeeVendingService
    {
        List<Coffee> GetCoffeeVending();

        void CreateOrder(OrderDTO order);
    }
}
