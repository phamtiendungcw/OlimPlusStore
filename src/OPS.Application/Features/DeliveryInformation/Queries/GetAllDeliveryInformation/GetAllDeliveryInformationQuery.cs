using MediatR;
using OPS.Application.DTO.Delivery;

namespace OPS.Application.Features.DeliveryInformation.Queries.GetAllDeliveryInformation
{
    public record GetAllDeliveryInformationQuery : IRequest<List<DeliveryInformationDto>>;
}
