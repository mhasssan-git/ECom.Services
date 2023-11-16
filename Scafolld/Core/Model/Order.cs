using Common.Core;

namespace OrderService.Core.Model
{
    public class OrderModel : Model
    {
        public List<OrderLineModel> OrderLines { get; set; }
        public Guid CustomerId { get; set; }
    }
}
