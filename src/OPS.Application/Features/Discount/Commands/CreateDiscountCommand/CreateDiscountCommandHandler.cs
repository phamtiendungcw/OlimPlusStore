using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;

namespace OPS.Application.Features.Discount.Commands.CreateDiscountCommand
{
    public class CreateDiscountCommandHandler : IRequestHandler<CreateDiscountCommand, int>
    {
        private readonly IDiscountRepository _discountRepository;
        private readonly IMapper _mapper;

        public CreateDiscountCommandHandler(IDiscountRepository discountRepository, IMapper mapper)
        {
            _discountRepository = discountRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateDiscountCommand request, CancellationToken cancellationToken)
        {
            var discountToCreate = _mapper.Map<Domain.Discount>(request);
            await _discountRepository.CreateAsync(discountToCreate);

            return discountToCreate.Id;
        }
    }
}