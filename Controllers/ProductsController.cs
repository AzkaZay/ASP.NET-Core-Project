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
                Reference = "CAKE001",
                Name = "Chocolate Cake",
                Description = "Bento Birthday Cake",
                UnitPrice = 25.00m,
                Available = true,
                PreparationLeadTimeHours = 24,

            };

            return View(product);
        }
    }
}
