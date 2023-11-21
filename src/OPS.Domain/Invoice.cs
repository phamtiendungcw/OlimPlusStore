using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Invoice : BaseEntity
    {
        public DateTime InvoiceDate { get; set; }
        public decimal TotalAmount { get; set; }
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}