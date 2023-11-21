using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;

        public Address? CustomerAddress { get; set; }
        public PaymentInformation? PaymentInfo { get; set; }
        public ICollection<Order>? OrderHistory { get; set; }
    }
}