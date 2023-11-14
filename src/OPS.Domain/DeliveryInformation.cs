using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class DeliveryInformation : BaseEntity
    {
        public DateTime DeliveryDate { get; set; }

        [ForeignKey("Address")] public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}