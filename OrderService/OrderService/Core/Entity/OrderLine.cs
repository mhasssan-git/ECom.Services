using Common.Core;

namespace OrderService.Core.Entity
{
    public class OrderLine : Entity<Guid>
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public Order Order { get; set; }

    }
}
