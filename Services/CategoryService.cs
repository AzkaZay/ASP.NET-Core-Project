using PatisserieCD.Data;
using PatisserieCD.Models;

namespace PatisserieCD.Services
{
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
    }
}
