using Microsoft.AspNetCore.Mvc;
using PatisserieCD.Models;

namespace PatisserieCD.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product
            {
                Id = 1,
                Name = "Chocolate Cake",
                Price = 25.00m
            };

            return View(product);
        }
    }
}
