using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class ReturnRepository : GenericRepository<Return>, IReturnRepository
    {
        public ReturnRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}