﻿using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;

namespace OPS.Application.Features.Address.Commands.CreateAddressCommand
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommand, int>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public CreateAddressCommandHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var addressToCreate = _mapper.Map<Domain.Address>(request);
            await _addressRepository.CreateAsync(addressToCreate);

            return addressToCreate.Id;
        }
    }
}