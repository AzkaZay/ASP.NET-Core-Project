using Microsoft.AspNetCore.Mvc;
using PatisserieCD.Services;

namespace PatisserieCD.Controllers;
public class CategoriesController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    public IActionResult Index()
    {
        var categories = _categoryService.GetCategories();

        return View(categories);
    }
}
