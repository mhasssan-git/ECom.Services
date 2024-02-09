using AutoMapper;
using ProductCatalogService.Core.Entity;
using ProductCatalogService.Core.Interface;
using ProductCatalogService.Core.Model;
using ProductCatalogService.Core.Service;

namespace ProductCatalogService.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ProductModel>> GetPagedProductList(int page,int pageSize)
        {
            List<Product> products= await repository.GetPageListAsync(page,pageSize);
            return _mapper.Map<List<ProductModel>>(products);
        }

        //public async Task<ProductDetailsModel> GetProductDetail(Guid productId)
        //{
        //    var productEntity = await repository.GetEntityWithSpec(entity => entity != null
        //                                                                   && entity.Id == productId);
        //    ProductDetailsModel orderModel = _mapper.Map<ProductDetailsModel>(productEntity);
        //    return orderModel;
        //}


        //public async Task CreateProductAsync(OrderModel orderModel)
        //{
        //    Order entity = _mapper.Map<Order>(orderModel);
        //    await repository.CreatedAsync(entity);
        //}

        //public void UpdateOrderAsync(Guid orderId, OrderModel orderModel)
        //{
        //    Order entity = _mapper.Map<Order>(orderModel);
        //    repository.UpdateAsync(entity);
        //}

        //public Task DeleteOrderAsync(int orderId)
        //{
        //    throw new NotImplementedException();
        //}

        //public async Task DeleteOrderAsync(Guid orderId)
        //{
        //    await repository.RemoveAsync(orderId);
        //}


    }
}
