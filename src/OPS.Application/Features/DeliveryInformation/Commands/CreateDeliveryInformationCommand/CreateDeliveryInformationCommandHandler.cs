using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;

namespace OPS.Application.Features.DeliveryInformation.Commands.CreateDeliveryInformationCommand
{
    public class CreateDeliveryInformationCommandHandler : IRequestHandler<CreateDeliveryInformationCommand, int>
    {
        private readonly IDeliveryInformationRepository _deliveryInformationRepository;
        private readonly IMapper _mapper;

        public CreateDeliveryInformationCommandHandler(IDeliveryInformationRepository deliveryInformationRepository,
            IMapper mapper)
        {
            _deliveryInformationRepository = deliveryInformationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDeliveryInformationCommand request, CancellationToken cancellationToken)
        {
            var deliveryInformationToCreate = _mapper.Map<Domain.DeliveryInformation>(request);
            await _deliveryInformationRepository.CreateAsync(deliveryInformationToCreate);

            return deliveryInformationToCreate.Id;
        }
    }
}