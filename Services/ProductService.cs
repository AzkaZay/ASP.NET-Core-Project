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

    public Product GetProduct()
    {
        return _context.Products.First();
    }
}