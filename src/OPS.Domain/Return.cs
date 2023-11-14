using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class Return : BaseEntity
    {
        public DateTime ReturnDate { get; set; }
        public string Reason { get; set; }

        [ForeignKey("Order")] public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}