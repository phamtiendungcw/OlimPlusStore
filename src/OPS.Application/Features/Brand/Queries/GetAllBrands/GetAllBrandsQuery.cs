using MediatR;
using OPS.Application.DTO.Brand;

namespace OPS.Application.Features.Brand.Queries.GetAllBrands
{
    public record GetAllBrandsQuery : IRequest<List<BrandDto>>;
}
