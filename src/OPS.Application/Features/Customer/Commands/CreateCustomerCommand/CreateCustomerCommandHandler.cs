using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;

namespace OPS.Application.Features.Customer.Commands.CreateCustomerCommand;

public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, int>
{
    private readonly ICustomerRepository _customerRepository;
    private readonly IMapper _mapper;

    public CreateCustomerCommandHandler(ICustomerRepository customerRepository, IMapper mapper)
    {
        _customerRepository = customerRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        var customerToCreate = _mapper.Map<Domain.Customer>(request);
        await _customerRepository.CreateAsync(customerToCreate);

        return customerToCreate.Id;
    }
}