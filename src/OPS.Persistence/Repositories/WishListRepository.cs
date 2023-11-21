using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class WishListRepository : GenericRepository<WishList>, IWishListRepository
    {
        public WishListRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}