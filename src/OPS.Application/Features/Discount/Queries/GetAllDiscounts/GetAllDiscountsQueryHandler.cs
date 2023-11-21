using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Discount;

namespace OPS.Application.Features.Discount.Queries.GetAllDiscounts
{
    public class GetAllDiscountsQueryHandler : IRequestHandler<GetAllDiscountsQuery, List<DiscountDto>>
    {
        private readonly IDiscountRepository _discountRepository;
        private readonly IMapper _mapper;

        public GetAllDiscountsQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }

        public async Task<List<DiscountDto>> Handle(GetAllDiscountsQuery request, CancellationToken cancellationToken)
        {
            var discounts = await _discountRepository.GetAllAsync();
            var data = _mapper.Map<List<DiscountDto>>(discounts);

            return data;
        }
    }
}