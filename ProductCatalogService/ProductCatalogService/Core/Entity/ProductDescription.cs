using Common.Core;

namespace ProductCatalogService.Core.Entity;

public class ProductDescription:Entity<Guid>

{
    public Guid ProductId { get; set; }
    public string Description { get; set; }
    public string SKU { get; set; }
    public string Brand{get; set; }
    public List<ProductDescriptionItem>  ProductDescriptionItems { get; set; }
    public List<ProductImage> ProductImages { get; set; }
    public Product Product { get; set; }
}