using Common.Repository;
using Microsoft.EntityFrameworkCore;
using ProductCatalogService.Core.Entity;
using ProductCatalogService.Core.Interface;

namespace ProductCatalogService.Repository
{
    public class ProductRepository:DbRepository<Product, Guid>, IProductRepository
    {
        public ProductRepository(ProductDbContext context) : base(context)
        {
             
        }
    }
}
