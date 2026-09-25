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
        var customer = _context.Customers
            .FirstOrDefault(c => c.Id == order.CustomerId);

        if (customer == null)
        {
            throw new Exception("Customer not found.");
        }

        decimal total = 0;

        foreach (var item in order.OrderItems)
        {
            var product = _context.Products
                .FirstOrDefault(p => p.Id == item.ProductId);

            if (product == null)
            {
                throw new Exception("Product not found.");
            }

            item.UnitPrice = product.UnitPrice;

            total += product.UnitPrice * item.Quantity;
        }

        order.TotalAmount = total;
        order.OrderDate = DateTime.UtcNow;
        order.Status = OrderStatus.Pending;

        _context.Orders.Add(order);

        _context.SaveChanges();
    }
}