using MediatR;
using OPS.Application.DTO.Brand;

namespace OPS.Application.Features.Brand.Queries.GetBrandDetails
{
    public record GetBrandDetailsQuery(int Id) : IRequest<BrandDetailDto>;
}