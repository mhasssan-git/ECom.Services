using Microsoft.EntityFrameworkCore;
using OrderService.Core.Entity;

namespace OrderService.Repository
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options):
            base(options)
        {
            
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(c => c.OrderLines)
                .WithOne(a => a.Order)
                .HasForeignKey(a=>a.OrderId);
        }
    }
}
