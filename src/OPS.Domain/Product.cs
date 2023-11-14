using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double AverageRating { get; set; }
        public string SKU { get; set; }

        [ForeignKey("Brand")] public int BrandId { get; set; }
        [ForeignKey("Category")] public int CategoryId { get; set; }
        [ForeignKey("InventoryItem")] public int InventoryItemId { get; set; }

        public Brand Brand { get; set; }
        public Category Category { get; set; }
        public InventoryItem InventoryItem { get; set; }
    }
}