using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string SKU { get; set; } = string.Empty;
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int InventoryItemId { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public InventoryItem InventoryItem { get; set; }
        public ICollection<ProductImage> ImageProducts { get; set; }
    }
}