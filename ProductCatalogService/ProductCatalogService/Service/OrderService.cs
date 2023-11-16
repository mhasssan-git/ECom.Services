using AutoMapper;
using Common.Core.Interface;
using OrderService.Core.Entity;
using OrderService.Core.Interface;
using OrderService.Core.Model;
using OrderService.Core.Service;

namespace OrderService.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            this.repository = repository;
            _mapper = mapper;
        }

        public async Task<OrderModel> GetOrderByCustomerId(Guid customerId)
        {
            var orderEntity = await repository.GetEntityWithSpec(entity => entity != null && entity.CustomerId == customerId);
            OrderModel orderModel = _mapper.Map<OrderModel>(orderEntity);
            return orderModel;
        }

        public async Task CreateOrderAsync(OrderModel orderModel)
        {
            Order entity = _mapper.Map<Order>(orderModel);
            await repository.CreatedAsync(entity);
        }

        public void UpdateOrderAsync(Guid orderId, OrderModel orderModel)
        {
            Order entity = _mapper.Map<Order>(orderModel);
            repository.UpdateAsync(entity);
        }

        public Task DeleteOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteOrderAsync(Guid orderId)
        {
            await repository.RemoveAsync(orderId);
        }
    }
}
