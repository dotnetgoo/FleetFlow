using FleetFlow.Domain.Entities;

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
        Task<bool> SaveChangesAsync();
    }
}