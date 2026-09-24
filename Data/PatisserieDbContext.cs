using PatisserieCD.Models;
using Microsoft.EntityFrameworkCore;

namespace PatisserieCD.Data;

public class PatisserieDbContext : DbContext
{
    public PatisserieDbContext(DbContextOptions<PatisserieDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
}
