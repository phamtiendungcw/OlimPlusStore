using OPS.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPS.Domain
{
    public class Review : BaseEntity
    {
        public int Rating { get; set; }
        public string Comment { get; set; }

        [ForeignKey("Product")] public int ProductId { get; set; }
        [ForeignKey("Customer")] public int CustomerId { get; set; }

        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public List<ReviewFeedback> ReviewFeedbacks { get; set; }
    }
}