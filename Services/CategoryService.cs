using Microsoft.EntityFrameworkCore;
using PatisserieCD.Data;
using PatisserieCD.Models;

namespace PatisserieCD.Services;

public class CategoryService : ICategoryService
{
    private readonly PatisserieDbContext _context;

    public CategoryService(PatisserieDbContext context) 
    {
        _context = context;
    }

    public List<Category> GetCategories()
    {
        return _context.Categories.ToList();
    }
   public Category GetCategoryById(int id)
    {
        return _context.Categories
            .Include(c => c.Products)
            .FirstOrDefault(c => c.Id == id);
    }
}