using PatisserieCD.Models;

namespace PatisserieCD.Services;
public interface IProductService
{
    List<Product> GetProducts();

    Product? GetProductById(int id);
}
