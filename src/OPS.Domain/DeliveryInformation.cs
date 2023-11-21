using OPS.Domain.Common;

namespace OPS.Domain
{
    public class DeliveryInformation : BaseEntity
    {
        public int AddressId { get; set; }
        public DateTime DeliveryDate { get; set; }

        public Address Address { get; set; }
    }
}