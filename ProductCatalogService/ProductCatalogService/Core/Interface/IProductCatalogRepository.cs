using Common.Core.Interface;
using ProductCatalogService.Core.Entity;

namespace OrderService.Core.Interface
{
    public interface IProductCatalogRepository:IRepository<ProductCatalog,Guid>
    {
    }
}
