using OPS.Domain.Common;

namespace OPS.Domain
{
    public class PaymentInformation : BaseEntity
    {
        public int OwnerId { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string ExpiryDate { get; set; } = string.Empty;
        public string CVV { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
    }
}