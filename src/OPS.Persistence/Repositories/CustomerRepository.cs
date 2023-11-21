using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}