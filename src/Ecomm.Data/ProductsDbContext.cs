using Ecomm.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Ecomm.Data
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ProductsDbContext(DbContextOptions<ProductsDbContext> dbContextOptions) : base(dbContextOptions) { }
    }
}
