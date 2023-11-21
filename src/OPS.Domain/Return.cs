using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Return : BaseEntity
    {
        public DateTime ReturnDate { get; set; }
        public string Reason { get; set; } = string.Empty;
        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}