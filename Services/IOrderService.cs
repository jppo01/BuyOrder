using BuyOrder.Models;

namespace BuyOrder.Services
{
    public interface IOrderService
    {
        List<Order> GetOrders();
    }
}