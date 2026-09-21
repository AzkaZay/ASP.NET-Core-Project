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
            var products = _productService.GetProducts();

            return View(products);
        }
        public IActionResult Details(int id)
        {
            var product = _productService.GetProductById(id);

            return View(product);
        }
    }
}
