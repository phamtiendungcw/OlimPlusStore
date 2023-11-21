using OPS.Domain.Common;

namespace OPS.Domain
{
    public class WishList : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}