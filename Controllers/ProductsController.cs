using Microsoft.AspNetCore.Mvc;
using PatisserieCD.Models;
using PatisserieCD.Services;

namespace PatisserieCD.Controllers;

public class ProductsController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductsController(
        IProductService productService,
        ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
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

    public IActionResult Create()
    {
        var categories = _categoryService.GetCategories();

        ViewBag.Categories = categories;

        return View();
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Categories = _categoryService.GetCategories();

            return View(product);
        }

        _productService.AddProduct(product);

        return RedirectToAction("Index");
    }
}