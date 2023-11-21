using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class ReviewFeedBackRepository : GenericRepository<ReviewFeedBack>, IReviewFeedbackRepository
    {
        public ReviewFeedBackRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}
