using Microsoft.EntityFrameworkCore;
using PatisserieCD.Data;
using PatisserieCD.Models;

namespace PatisserieCD.Services;
public class OrderService : IOrderService
{
    private readonly PatisserieDbContext _context;

    public OrderService(PatisserieDbContext context)
    {
        _context = context;
    }
    public List<Order> GetOrders()
    {
        return _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.OrderItems)
            .ToList();
    }
    public Order? GetOrderById(int id)
    {
        return _context.Orders
            .Include(o => o.Customer)
            .Include(o => o.OrderItems)
            .FirstOrDefault(o => o.Id == id);
    }
    public void AddOrder(Order order)
    {
        _context.Orders.Add(order);
        _context.SaveChanges();
    }
}