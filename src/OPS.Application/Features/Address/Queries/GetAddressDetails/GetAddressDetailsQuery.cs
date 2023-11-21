using MediatR;
using OPS.Application.DTO.Address;

namespace OPS.Application.Features.Address.Queries.GetAddressDetails
{
    public record GetAddressDetailsQuery(int Id) : IRequest<AddressDetailDto>;
}