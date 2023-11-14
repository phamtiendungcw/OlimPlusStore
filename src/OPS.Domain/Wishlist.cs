using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class WishList : BaseEntity
    {
        [ForeignKey("Customer")] public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}