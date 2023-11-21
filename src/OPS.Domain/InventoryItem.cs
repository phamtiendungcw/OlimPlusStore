using OPS.Domain.Common;

namespace OPS.Domain
{
    public class InventoryItem : BaseEntity
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}