using Common.Core.Interface;
using OrderService.Core.Entity;

namespace OrderService.Core.Interface
{
    public interface IOrderRepository:IRepository<Order,Guid>
    {
    }
}
