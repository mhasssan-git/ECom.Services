using OrderService.Core.Model;

namespace OrderService.Core.Service
{
    public interface IProductCatalogService
    {
        public Task<List<ProductModel>> GetProductList();
        public Task<ProductDetailsModel> GetProductDetail(Guid productId);
    }
}
