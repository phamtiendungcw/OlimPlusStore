using MediatR;
using OPS.Application.DTO.Category;

namespace OPS.Application.Features.Category.Queries.GetAllCategories
{
    public record GetAllCategoriesQuery : IRequest<List<CategoryDto>>;
}
