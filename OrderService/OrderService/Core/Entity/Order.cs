using Common.Core;

namespace OrderService.Core.Entity
{
    public class Order : Entity<Guid>
    {
        public List<OrderLine> OrderLines { get; set; }
        public Guid CustomerId { get; set; }
    }
}
