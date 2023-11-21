using MediatR;
using OPS.Application.DTO.Image;

namespace OPS.Application.Features.Image.Queries.GetProductImageDetails
{
    public record GetProductImageDetailsQuery(int Id) : IRequest<ProductImageDetailDto>;
}