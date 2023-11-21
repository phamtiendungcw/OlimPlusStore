using MediatR;
using OPS.Application.DTO.Address;

namespace OPS.Application.Features.Address.Queries.GetAllAddresses
{
    public record GetAllAddressesQuery : IRequest<List<AddressDto>>;
}