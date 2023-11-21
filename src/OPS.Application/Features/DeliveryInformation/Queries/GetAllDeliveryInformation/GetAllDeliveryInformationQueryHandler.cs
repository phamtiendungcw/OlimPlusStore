using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Delivery;

namespace OPS.Application.Features.DeliveryInformation.Queries.GetAllDeliveryInformation
{
    public class
        GetAllDeliveryInformationQueryHandler : IRequestHandler<GetAllDeliveryInformationQuery,
            List<DeliveryInformationDto>>
    {
        private readonly IDeliveryInformationRepository _deliveryInformationRepository;
        private readonly IMapper _mapper;

        public GetAllDeliveryInformationQueryHandler(IDeliveryInformationRepository deliveryInformationRepository,
            IMapper mapper)
        {
            _deliveryInformationRepository = deliveryInformationRepository;
            _mapper = mapper;
        }

        public async Task<List<DeliveryInformationDto>> Handle(GetAllDeliveryInformationQuery request,
            CancellationToken cancellationToken)
        {
            var deliveries = await _deliveryInformationRepository.GetAllAsync();
            var data = _mapper.Map<List<DeliveryInformationDto>>(deliveries);

            return data;
        }
    }
}