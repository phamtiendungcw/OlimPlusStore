using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;

namespace OPS.Application.Features.Category.Commands.CreateCategoryCommand
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryToCreate = _mapper.Map<Domain.Category>(request);
            await _categoryRepository.CreateAsync(categoryToCreate);

            return categoryToCreate.Id;
        }
    }
}