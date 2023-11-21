using OPS.Domain.Common;

namespace OPS.Domain
{
    public class ImageSlide : BaseEntity
    {
        public string ImageUrl { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;
    }
}