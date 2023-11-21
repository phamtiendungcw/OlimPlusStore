using MediatR;
using OPS.Application.DTO.Delivery;

namespace OPS.Application.Features.DeliveryInformation.Queries.GetDeliveryInformationDetails
{
    public record GetDeliveryInformationDetailsQuery(int Id) : IRequest<DeliveryInformationDetailDto>;
}