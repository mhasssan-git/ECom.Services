
using Common.Core;
using ProductCatalogService.Core.Enum;

namespace ProductCatalogService.Core.Entity
{
    public class ProductCatalog : Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public EPriceUnit PriceUnit { get; set; }
        public Guid Thumbnail { get; set; }
        public List<Guid> ProductImages { get; set; }
    }
}
