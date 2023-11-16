using Common.Core;

namespace OrderService.Core.Model
{
    public class ProductDetailsModel: Model
    {
        public string ProductName { get; set; }
        public string ProductDetails { get; set; }
        public decimal Price { get; set; }
        public List<Guid> ProductImage { get; set; }

    }
}
