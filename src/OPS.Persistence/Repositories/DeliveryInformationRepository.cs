using OPS.Application.Contracts.Persistence;
using OPS.Domain;
using OPS.Persistence.DatabaseContext;
using OPS.Persistence.Repositories.Common;

namespace OPS.Persistence.Repositories
{
    public class DeliveryInformationRepository : GenericRepository<DeliveryInformation>, IDeliveryInformationRepository
    {
        public DeliveryInformationRepository(OlimPlusDatabaseContext context) : base(context)
        {
        }
    }
}
