using AutoMapper;
using OPS.Application.DTO.Address;
using OPS.Application.Features.Address.Commands.CreateAddressCommand;
using OPS.Domain;

namespace OPS.Application.MappingProfiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<Address, AddressDetailDto>();
            CreateMap<CreateAddressCommand, Address>();
        }
    }
}