using OPS.Domain.Common;

namespace OPS.Domain
{
    public class ReviewFeedBack : BaseEntity
    {
        public int ReviewFeedBackId { get; set; }
        public string Feedback { get; set; } = string.Empty;

        public Review RelatedReview { get; set; }
    }
}