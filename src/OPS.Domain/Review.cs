using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Review : BaseEntity
    {
        public int Rating { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int ProductId { get; set; }
        public int CustomerId { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public ICollection<ReviewFeedBack> ReviewFeedBacks { get; set; }
    }
}