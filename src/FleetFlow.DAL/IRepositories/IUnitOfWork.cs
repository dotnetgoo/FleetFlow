using FleetFlow.Domain.Entities;

namespace FleetFlow.DAL.IRepositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Address> Addresses { get; }
        IRepository<Inventory> Inventories { get; }
        IRepository<Location> Locations { get; }
        IRepository<Merchant> Merchants { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        IRepository<Product> Products { get; }
        IRepository<Cart> Carts { get; }
        Task<bool> SaveChangesAsync();
    }
}