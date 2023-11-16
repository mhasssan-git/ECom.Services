using Common.Core;

namespace OrderService.Core.Model
{
    public class ProductModel : Model
    {
        public string ProductName { get; set; }
        public Guid Thumbnail { get; set; }
        public decimal Price { get; set; }

    }
}
