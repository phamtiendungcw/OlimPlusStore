﻿using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Category;

namespace OPS.Application.Features.Category.Queries.GetCategoryDetails
{
    public class GetCategoryDetailsQueryHandler : IRequestHandler<GetCategoryDetailsQuery, CategoryDetailDto>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryDetailsQueryHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<CategoryDetailDto> Handle(GetCategoryDetailsQuery request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id);
            var data = _mapper.Map<CategoryDetailDto>(category);

            return data;
        }
    }
}