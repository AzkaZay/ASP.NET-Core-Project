using Microsoft.AspNetCore.Mvc;

namespace PatisserieCD.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
