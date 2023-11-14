using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Address CustomerAddress { get; set; }
        public PaymentInformation PaymentInfo { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}