using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Delivery;

namespace OPS.Application.Features.DeliveryInformation.Queries.GetDeliveryInformationDetails
{
    public class GetDeliveryInformationDetailsQueryHandler : IRequestHandler<GetDeliveryInformationDetailsQuery, DeliveryInformationDetailDto>
    {
        private readonly IDeliveryInformationRepository _deliveryInformationRepository;
        private readonly IMapper _mapper;

        public GetDeliveryInformationDetailsQueryHandler(IDeliveryInformationRepository deliveryInformationRepository,
            IMapper mapper)
        {
            _deliveryInformationRepository = deliveryInformationRepository;
            _mapper = mapper;
        }

        public async Task<DeliveryInformationDetailDto> Handle(GetDeliveryInformationDetailsQuery request, CancellationToken cancellationToken)
        {
            var deliveryInformation = await _deliveryInformationRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<DeliveryInformationDetailDto>(deliveryInformation);

            return data;
        }
    }
}