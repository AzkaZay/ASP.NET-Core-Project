using Microsoft.AspNetCore.Mvc;
using PatisserieCD.Models;
using PatisserieCD.Services;

namespace PatisserieCD.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly IOrderService _orderService;
    public OrdersController(IOrderService orderService)
    {
        _orderService = orderService;
    }
    [HttpGet]
    public IActionResult GetOrders()
    {
        var orders = _orderService.GetOrders();

        return Ok(orders);
    }
    [HttpGet("{id}")]
    public IActionResult GetOrder(int id)
    {
        var order = _orderService.GetOrderById(id);

        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }
    [HttpPost]
    public IActionResult CreateOrder(Order order)
    {
        _orderService.AddOrder(order);

        return Ok(order);
    }
}