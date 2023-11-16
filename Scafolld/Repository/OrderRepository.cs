using Common.Core.Interface;
using Common.Repository;
using Microsoft.EntityFrameworkCore;
using OrderService.Core.Entity;
using OrderService.Core.Interface;

namespace OrderService.Repository
{
    public class OrderRepository:DbRepository<Order,Guid>, IOrderRepository
    {
        public OrderRepository(OrderDbContext context) : base(context)
        {
        }
    }
}
