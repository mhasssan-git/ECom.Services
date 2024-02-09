using Common.Core;
using ProductCatalogService.Core.Enum;

namespace ProductCatalogService.Core.Entity
{
    public class Product : Entity<Guid>
    {
        public string Name { get; set; }
        public Price Price { get; set; }
        public EPriceUnit PriceUnit { get; set; }
        public ProductDescription ProductDescription { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }

    public class Price
    {
        public decimal BasePrice { get; set; }
        public decimal Discount { get; set; }
    }
}
