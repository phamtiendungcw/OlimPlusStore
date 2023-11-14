using OPS.Domain.Common;

namespace OPS.Domain
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public Address UserAddress { get; set; }
        public PaymentInformation PaymentInfo { get; set; }
        public List<Order> OrderHistory { get; set; }
    }
}