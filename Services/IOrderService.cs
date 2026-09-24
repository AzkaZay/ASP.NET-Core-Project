using PatisserieCD.Models;

namespace PatisserieCD.Services;

public interface IOrderService
{
    List<Order> GetOrders();
    Order? GetOrderById(int id);
    void AddOrder(Order order);
}