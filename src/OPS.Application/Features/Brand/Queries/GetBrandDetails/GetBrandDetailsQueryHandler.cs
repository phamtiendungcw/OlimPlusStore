using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Brand;

namespace OPS.Application.Features.Brand.Queries.GetBrandDetails
{
    public class GetBrandDetailsQueryHandler : IRequestHandler<GetBrandDetailsQuery, BrandDetailDto>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;

        public GetBrandDetailsQueryHandler(IBrandRepository brandRepository, IMapper mapper)
        {
            _brandRepository = brandRepository;
            _mapper = mapper;
        }

        public async Task<BrandDetailDto> Handle(GetBrandDetailsQuery request, CancellationToken cancellationToken)
        {
            var brand = await _brandRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<BrandDetailDto>(brand);

            return data;
        }
    }
}