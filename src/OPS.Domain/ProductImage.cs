using OPS.Domain.Common;

namespace OPS.Domain
{
    public class ProductImage : BaseEntity
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}