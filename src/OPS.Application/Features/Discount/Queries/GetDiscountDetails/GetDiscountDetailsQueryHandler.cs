using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Discount;

namespace OPS.Application.Features.Discount.Queries.GetDiscountDetails
{
    public class GetDiscountDetailsQueryHandler : IRequestHandler<GetDiscountDetailsQuery, DiscountDetailDto>
    {
        private readonly IDiscountRepository _discountRepository;
        private readonly IMapper _mapper;

        public GetDiscountDetailsQueryHandler(IDiscountRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }

        public async Task<DiscountDetailDto> Handle(GetDiscountDetailsQuery request, CancellationToken cancellationToken)
        {
            var discount = await _discountRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<DiscountDetailDto>(discount);

            return data;
        }
    }
}