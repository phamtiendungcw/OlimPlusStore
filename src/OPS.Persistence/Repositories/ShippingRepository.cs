using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class ShippingRepository : GenericRepository<Shipping>, IShippingRepository
    {
        public ShippingRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}