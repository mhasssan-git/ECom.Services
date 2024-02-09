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

            modelBuilder.Entity<Product>()
                .HasOne(a => a.ProductDescription)
                .WithOne(a => a.Product)
                .HasForeignKey<ProductDescription>(a=>a.ProductId);
            modelBuilder.Entity<Product>()
                .HasMany(a => a.ProductImages)
                .WithOne(a => a.Product)
                .HasForeignKey(a => a.ProductId);
            modelBuilder.Entity<ProductDescription>()
                .HasMany(a => a.ProductImages)
                .WithOne(a => a.ProductDescription)
                .HasForeignKey(a => a.ProductId);

        }
    }
}
