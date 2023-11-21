using MediatR;
using OPS.Application.DTO.Discount;

namespace OPS.Application.Features.Discount.Queries.GetAllDiscounts
{
    public record GetAllDiscountsQuery : IRequest<List<DiscountDto>>;
}
