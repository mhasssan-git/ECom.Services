using OrderService.Core.Model;

namespace OrderService.Core.Service
{
    public interface IOrderService
    {
        public Task<OrderModel> GetOrderByCustomerId(Guid userId);
        public Task CreateOrderAsync(OrderModel orderModel);
        public void UpdateOrderAsync(Guid orderId, OrderModel orderModel);
        public Task DeleteOrderAsync(int orderId);
    }
}
