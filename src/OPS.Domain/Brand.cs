using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IList<Product> Products { get; set; }

    }
}