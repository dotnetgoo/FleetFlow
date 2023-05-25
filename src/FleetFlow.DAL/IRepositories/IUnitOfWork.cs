using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Entities.Warehouses;

namespace FleetFlow.DAL.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Address> Addresses { get; }
        IRepository<Inventory> Inventories { get; }
        IRepository<Location> Locations { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        IRepository<Product> Products { get; }
        IRepository<Cart> Carts { get; }
        IRepository<Role> Roles { get; }
        IRepository<RolePermission> RolePermissions { get; }
        IRepository<Permission> Permissions { get; }
        Task<bool> SaveChangesAsync();
    }
}