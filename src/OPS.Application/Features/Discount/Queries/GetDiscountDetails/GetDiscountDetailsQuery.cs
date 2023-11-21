using MediatR;
using OPS.Application.DTO.Discount;

namespace OPS.Application.Features.Discount.Queries.GetDiscountDetails
{
    public record GetDiscountDetailsQuery(int Id) : IRequest<DiscountDetailDto>;
}