using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class Invoice : BaseEntity
    {
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }

        [ForeignKey("Order")] public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}