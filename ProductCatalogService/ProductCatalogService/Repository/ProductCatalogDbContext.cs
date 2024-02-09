using Microsoft.EntityFrameworkCore;
using ProductCatalogService.Core.Entity;

namespace ProductCatalogService.Repository
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):
            base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<ProductDescription>();
            modelBuilder.Entity<ProductDescriptionItem>();
            modelBuilder.Entity<ProductImage>();
        }
    }
}
