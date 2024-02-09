using ProductCatalogService.Core.Model;

namespace ProductCatalogService.Core.Service
{
    public interface IProductService
    {
         public Task<List<ProductModel>> GetPagedProductList(int page,int pageSize);
       // public Task<ProductDetailsModel> GetProductDetail(Guid productId);
    }
}
