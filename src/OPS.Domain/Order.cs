using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Order : BaseEntity
    {
        public List<OrderItem>? OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public int CustomerId { get; set; }
        public int InvoiceId { get; set; }
        public int ReturnId { get; set; }
        public int ShippingId { get; set; }

        public User? User { get; set; }
        public Customer Customer { get; set; }
        public Invoice Invoice { get; set; }
        public Return? Return { get; set; }
        public Shipping Shipping { get; set; }
    }
}