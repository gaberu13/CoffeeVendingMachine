using CoffeeVending.Models.DTO;

namespace CoffeeVending.Service.Interfaces
{
    public interface ICoffeeVendingService
    {
        dynamic GetCoffeeVending();

        void CreateOrder(OrderDTO order);
    }
}
