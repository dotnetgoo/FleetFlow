using AutoMapper;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs;

namespace FleetFlow.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product,ProductForCreationDto>().ReverseMap();
            CreateMap<Product,ProductForResultDto>().ReverseMap();

            CreateMap<Address, AddressForCreationDto>().ReverseMap();
            CreateMap<Address, AddressForResultDto>().ReverseMap();

            CreateMap<Merchant, MerchantForCreationDto>().ReverseMap();
            CreateMap<Merchant, MerchantForResultDto>().ReverseMap();

            CreateMap<Location, LocationForCreationDto>().ReverseMap();
            CreateMap<Location, LocationForResultDto>().ReverseMap();
                    
            CreateMap<User, UserForCreationDto>().ReverseMap();
            CreateMap<User, UserForResultDto>().ReverseMap();
            CreateMap<User, UserForUpdateDto>().ReverseMap();

            
            
        }
    }
}
