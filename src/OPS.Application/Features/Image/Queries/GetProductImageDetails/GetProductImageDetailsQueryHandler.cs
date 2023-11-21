using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Image;

namespace OPS.Application.Features.Image.Queries.GetProductImageDetails
{
    public class GetProductImageDetailsQueryHandler : IRequestHandler<GetProductImageDetailsQuery, ProductImageDetailDto>
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;

        public GetProductImageDetailsQueryHandler(IProductImageRepository productImageRepository, IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        public async Task<ProductImageDetailDto> Handle(GetProductImageDetailsQuery request, CancellationToken cancellationToken)
        {
            var productImage = await _productImageRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<ProductImageDetailDto>(productImage);

            return data;
        }
    }
}