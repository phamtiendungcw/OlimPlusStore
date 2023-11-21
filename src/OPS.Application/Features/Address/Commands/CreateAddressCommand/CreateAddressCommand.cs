using MediatR;

namespace OPS.Application.Features.Address.Commands.CreateAddressCommand
{
    public class CreateAddressCommand : IRequest<int>
    {
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
    }
}
