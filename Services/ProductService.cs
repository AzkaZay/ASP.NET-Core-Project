using PatisserieCD.Models;

namespace PatisserieCD.Services;

public class ProductService : IProductService
{
    public Product GetProduct()
    {
        return new Product
        {
            Id = 1,
            Name = "Chocolate Cake",
            Price = 25.00m
        };
    }
}
