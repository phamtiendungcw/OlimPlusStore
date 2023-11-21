using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Shipping : BaseEntity
    {
        public string ShippingMethod { get; set; } = string.Empty;
        public decimal ShippingCost { get; set; }
    }
}