using Common.Core;

namespace ProductCatalogService.Core.Entity;

public class ProductImage : Entity<Guid>
{
    public Guid ProductId { get; set; }
    public bool IsThumbnail { get; set; }
    public bool IsDefault { get; set; }
}