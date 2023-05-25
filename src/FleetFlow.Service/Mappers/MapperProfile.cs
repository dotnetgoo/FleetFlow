using AutoMapper;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.DTOs.Feedbacks;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.DTOs.User;
using Location = FleetFlow.Domain.Entities.Warehouses.Location;

namespace FleetFlow.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductForCreationDto>().ReverseMap();
            CreateMap<Product, ProductForResultDto>().ReverseMap();

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

            CreateMap<Feedback, FeedbackResultDto>().ReverseMap();
            CreateMap<Feedback, FeedbackCreationDto>().ReverseMap();

            CreateMap<Discount, DiscountResultDto>().ReverseMap();
            CreateMap<Discount, DiscountCreationDto>().ReverseMap();
            CreateMap<Discount, DiscountUpdateDto>().ReverseMap();

            CreateMap<Inventory, InventoryCreationDto>().ReverseMap();
            CreateMap<Inventory, InventoryForResultDto>().ReverseMap();
            CreateMap<Inventory, InventoryForUpdateDto>().ReverseMap();

            CreateMap<InventoryLog, InventoryLogForCreationDto>().ReverseMap();
            CreateMap<InventoryLog, InventoryLogForResultDto>().ReverseMap();
        }
    }
}
