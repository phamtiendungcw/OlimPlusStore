﻿using AutoMapper;
using MediatR;
using OPS.Application.Contracts.Persistence;
using OPS.Application.DTO.Address;

namespace OPS.Application.Features.Address.Queries.GetAllAddresses
{
    public class GetAllAddressesQueryHandler : IRequestHandler<GetAllAddressesQuery, List<AddressDto>>
    {
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public GetAllAddressesQueryHandler(IAddressRepository addressRepository, IMapper mapper)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public async Task<List<AddressDto>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
        {
            var addresses = await _addressRepository.GetAllAsync();
            var data = _mapper.Map<List<AddressDto>>(addresses);

            return data;
        }
    }
}