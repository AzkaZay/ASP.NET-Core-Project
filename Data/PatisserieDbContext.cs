using PatisserieCD.Models;
using Microsoft.EntityFrameworkCore;

namespace PatisserieCD.Data;

public class PatisserieDbContext : DbContext
{
    public PatisserieDbContext(DbContextOptions<PatisserieDbContext> options) : base(options)
    {

    }

    public DbSet<Product> Products { get ; set; }
}
