using Common.Core.Interface;
using ProductCatalogService.Core.Entity;

namespace ProductCatalogService.Core.Interface
{
    public interface IProductRepository:IRepository<Product,Guid>
    {
    }
}
