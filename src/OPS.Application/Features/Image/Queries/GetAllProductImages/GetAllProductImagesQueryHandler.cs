using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Image;

namespace OPS.Application.Features.Image.Queries.GetAllProductImages
{
    public class GetAllProductImagesQueryHandler : IRequestHandler<GetAllProductImagesQuery, List<ProductImageDto>>
    {
        private readonly IProductImageRepository _productImageRepository;
        private readonly IMapper _mapper;

        public GetAllProductImagesQueryHandler(IProductImageRepository productImageRepository, IMapper mapper)
        {
            _productImageRepository = productImageRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductImageDto>> Handle(GetAllProductImagesQuery request, CancellationToken cancellationToken)
        {
            var productImages = await _productImageRepository.GetAllAsync();
            var data = _mapper.Map<List<ProductImageDto>>(productImages);

            return data;
        }
    }
}