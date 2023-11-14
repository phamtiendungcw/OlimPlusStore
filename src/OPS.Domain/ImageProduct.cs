using OPS.Domain.Common;

namespace OPS.Domain
{
    public class ImageProduct : BaseEntity
    {
        public Product Product { get; set; }
        public string ImageUrl { get; set; }
        public string AltText { get; set; }
    }
}