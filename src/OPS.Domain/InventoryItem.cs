using OPS.Domain.Common;

namespace OPS.Domain
{
    public class InventoryItem : BaseEntity
    {
        public int ProductId { get; set; } // ID của sản phẩm
        public int Quantity { get; set; } // Số lượng tồn kho

        public Product Product { get; set; }
    }
}