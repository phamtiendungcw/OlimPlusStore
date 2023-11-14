using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class ReviewFeedback : BaseEntity
    {
        public string Feedback { get; set; }

        [ForeignKey("Review")] public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}