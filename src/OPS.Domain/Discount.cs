using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Discount : BaseEntity
    {
        public string CouponCode { get; set; } = string.Empty;
        public decimal DiscountPercentage { get; set; }
    }
}