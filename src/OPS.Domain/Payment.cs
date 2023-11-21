using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public int PaymentInformationId { get; set; }

        public PaymentInformation PaymentInformation { get; set; }
    }
}