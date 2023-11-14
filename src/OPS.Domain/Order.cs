using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class Order : BaseEntity
    {
        public List<Product> OrderedProducts { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentMethod { get; set; }

        [ForeignKey("Customer")] public int CustomerId { get; set; } // ID của khách hàng
        [ForeignKey("Invoice")] public int? InvoiceId { get; set; }
        [ForeignKey("Return")] public int? ReturnId { get; set; }
        [ForeignKey("Shipping")] public int ShippingId { get; set; }

        public Customer Customer { get; set; }
        public Invoice Invoice { get; set; }
        public Return Return { get; set; }
        public Shipping Shipping { get; set; }
    }
}