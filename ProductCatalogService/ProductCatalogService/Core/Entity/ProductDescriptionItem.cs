using Common.Core;

namespace ProductCatalogService.Core.Entity;

public class ProductDescriptionItem:Entity<Guid>
{
    public string item { get; set; }
    public Guid ProductDescriptionId { get; set; }
}