using OPS.Domain.Common;

namespace OPS.Domain
{
    public class OrderItem : BaseEntity
    {
        public Product? OrderedProduct { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; } = string.Empty;
    }
}