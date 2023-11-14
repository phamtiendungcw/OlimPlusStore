using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }

        [ForeignKey("PaymentInformation")] public int PaymentInformationId { get; set; }
        public PaymentInformation PaymentInformation { get; set; }
    }
}