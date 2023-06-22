using AutoMapper;
using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Bonuses;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.StaffPermissions;
using FleetFlow.Domain.Entities.Staffs;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Service.DTOs.Address;
using FleetFlow.Service.DTOs.Bonuses;
using FleetFlow.Service.DTOs.Carts;
using FleetFlow.Service.DTOs.Discounts;
using FleetFlow.Service.DTOs.Inventories;
using FleetFlow.Service.DTOs.InventoryLogs;
using FleetFlow.Service.DTOs.Location;
using FleetFlow.Service.DTOs.Orders;
using FleetFlow.Service.DTOs.Payments;
using FleetFlow.Service.DTOs.Permissions;
using FleetFlow.Service.DTOs.Product;
using FleetFlow.Service.DTOs.Products;
using FleetFlow.Service.DTOs.Questions;
using FleetFlow.Service.DTOs.RolePermissions;
using FleetFlow.Service.DTOs.Roles;
using FleetFlow.Service.DTOs.StaffPermissions;
using FleetFlow.Service.DTOs.Staffs;
using FleetFlow.Service.DTOs.User;

namespace FleetFlow.Service.Mappers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Product, ProductForCreationDto>().ReverseMap();
            CreateMap<Product, ProductForResultDto>().ReverseMap();

            CreateMap<ProductCategory, ProductCategoryCreationDto>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryUpdateDto>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryResultDto>().ReverseMap();

            CreateMap<Address, AddressForCreationDto>().ReverseMap();
            CreateMap<Address, AddressForResultDto>().ReverseMap();
            CreateMap<Address, AddressAddDto>().ReverseMap();

            CreateMap<Discount, DiscountResultDto>().ReverseMap();
            CreateMap<Discount, DiscountUpdateDto>().ReverseMap();
            CreateMap<Discount, DiscountCreationDto>().ReverseMap();

            CreateMap<User, UserForCreationDto>().ReverseMap();
            CreateMap<User, UserForResultDto>().ReverseMap();
            CreateMap<User, UserForUpdateDto>().ReverseMap();

            CreateMap<Cart, CartResultDto>().ReverseMap();
            CreateMap<CartItem, CartItemResultDto>().ReverseMap();
            CreateMap<CartItem, CartItemUpdateDto>().ReverseMap();

            CreateMap<Order, OrderResultDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemForResultDto>().ReverseMap();

            CreateMap<Answer, AnswerForCreationDto>().ReverseMap();
            CreateMap<Question, QuestionForCreationDto>().ReverseMap();

            CreateMap<Location, LocationForCreationDto>().ReverseMap();
            CreateMap<Location, LocationForResultDto>().ReverseMap();

            CreateMap<ProductInventory, ProductInventoryCreationDto>().ReverseMap();
            CreateMap<ProductInventory, ProductInventoryUpdateDto>().ReverseMap();
            CreateMap<ProductInventory, ProductInventoryResultDto>().ReverseMap();


            CreateMap<Inventory, InventoryForCreationDto>().ReverseMap();
            CreateMap<Inventory, InventoryForResultDto>().ReverseMap();
            CreateMap<Inventory, InventoryForUpdateDto>().ReverseMap();
            CreateMap<InventoryLogForCreationDto, InventoryForUpdateDto>().ReverseMap();

            CreateMap<InventoryLog, InventoryLogForCreationDto>().ReverseMap();
            CreateMap<InventoryLog, InventoryLogForResultDto>().ReverseMap();

            CreateMap<Role, RoleResultDto>().ReverseMap();
            CreateMap<Role, RoleCreationDto>().ReverseMap();
            CreateMap<Role, RoleUpdateDto>().ReverseMap();

            CreateMap<RolePermission, RolePermissionForResultDto>().ReverseMap();
            CreateMap<RolePermission, RolePermissionForCreateDto>().ReverseMap();
            CreateMap<RolePermission, RolePermissionForUpdateDto>().ReverseMap();

            CreateMap<Permission, PermissionForResultDto>().ReverseMap();
            CreateMap<Permission, PermissionForCreationDto>().ReverseMap();
            CreateMap<Permission, PermissionForUpdateDto>().ReverseMap();

            CreateMap<Staff, StaffForCreationDto>().ReverseMap();
            CreateMap<Staff, StaffForUpdateDto>().ReverseMap();
            CreateMap<Staff, StaffForResultDto>().ReverseMap();

            CreateMap<StaffPermission, StaffPermissionsForCreationDto>().ReverseMap();
            CreateMap<StaffPermission, StaffPermissionForResultDto>().ReverseMap();

            CreateMap<Payment, PaymentResultDto>().ReverseMap();
            CreateMap<Payment, PaymentCreationDto>().ReverseMap();

            CreateMap<OrderAction, OrderActionCreationDto>().ReverseMap();
            CreateMap<Order, OrderResultDto>().ReverseMap();
            CreateMap<OrderItem, OrderItemForResultDto>().ReverseMap();
            CreateMap<Order, OrderItemForResultDto>().ReverseMap();

            CreateMap<Region, RegionResultDto>().ReverseMap();
            CreateMap<District, DistrictResultDto>().ReverseMap();

            CreateMap<Bonus, BonusResultDto>().ReverseMap();
            CreateMap<BonusSetting, BonusSettingCreationDto>().ReverseMap();
            CreateMap<BonusSetting, BonusSettingUpdateDto>().ReverseMap();
            CreateMap<BonusSetting, BonusSettingResultDto>().ReverseMap();
        }
    }
}
