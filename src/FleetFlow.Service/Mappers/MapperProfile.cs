using AutoMapper;
using FleetFlow.Domain.Entities;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.DTOs.User;
using Location = FleetFlow.Domain.Entities.Location;

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

            CreateMap<Location, LocationForCreationDto>().ReverseMap();
            CreateMap<Location, LocationForResultDto>().ReverseMap();
                    
            CreateMap<User, UserForCreationDto>().ReverseMap();
            CreateMap<User, UserForResultDto>().ReverseMap();
            CreateMap<User, UserForUpdateDto>().ReverseMap();

            CreateMap<CartItem, CartItemResultDto>().ReverseMap();
            CreateMap<Order, OrderResultDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemForResultDto>().ReverseMap();
        }
    }
}
