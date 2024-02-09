namespace ProductCatalogService.Core.Entity;

public class ProductDescription
{
    public Guid ProductId { get; set; }
    public string Description { get; set; }
    public string SKU { get; set; }
    public string Brand{get; set; }
    public List<ProductDescriptionItem>  ProductDescriptionItems { get; set; }
    public List<ProductImage> Images { get; set; }
}