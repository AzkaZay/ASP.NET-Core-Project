using PatisserieCD.Data;
using PatisserieCD.Models;

namespace PatisserieCD.Services;

public class ProductService : IProductService
{
    private readonly PatisserieDbContext _context;

    public ProductService(PatisserieDbContext context)
    {
        _context = context;
    }

    public List<Product> GetProducts()
    {
        return _context.Products.ToList();
    }
    public Product? GetProductById(int id)
    {
        return _context.Products.FirstOrDefault(p => p.Id == id);
    }
}