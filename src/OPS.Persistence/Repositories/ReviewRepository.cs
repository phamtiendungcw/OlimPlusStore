using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}