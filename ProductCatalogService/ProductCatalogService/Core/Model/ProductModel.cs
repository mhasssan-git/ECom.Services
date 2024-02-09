namespace ProductCatalogService.Core.Model
{
    public class ProductModel : Model
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Guid Thumbnail { get; set; }
        public decimal Price { get; set; }

    }
}
