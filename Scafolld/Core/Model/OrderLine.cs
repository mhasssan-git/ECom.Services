using Common.Core;

namespace OrderService.Core.Model
{
    public class OrderLineModel: Model
    {
          
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
         

    }
}
