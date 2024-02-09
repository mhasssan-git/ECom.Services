using ProductCatalogService.Core.Model;

namespace ProductCatalogService.Core.Service
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetProductList();
        public Task<ProductDetailsModel> GetProductDetail(Guid productId);
    }
}
