using MediatR;
using OPS.Application.DTO.Image;

namespace OPS.Application.Features.Image.Queries.GetAllProductImages
{
    public record GetAllProductImagesQuery() : IRequest<List<ProductImageDto>>;
}