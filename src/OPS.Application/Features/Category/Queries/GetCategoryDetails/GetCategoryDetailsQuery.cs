using MediatR;
using OPS.Application.DTO.Category;

namespace OPS.Application.Features.Category.Queries.GetCategoryDetails
{
    public record GetCategoryDetailsQuery(int Id) : IRequest<CategoryDetailDto>;
}