using Microsoft.AspNetCore.Mvc;
using PatisserieCD.Services;

namespace PatisserieCD.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var product = _productService.GetProduct();

            return View(product);
        }
    }
}
