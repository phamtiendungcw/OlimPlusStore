using OPS.Domain.Common;

namespace OPS.Domain
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Product> Products { get; set; }
    }
}