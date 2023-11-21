using MediatR;

namespace OPS.Application.Features.Brand.Commands.CreateBrandCommand
{
    public class CreateBrandCommand : IRequest<int>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}