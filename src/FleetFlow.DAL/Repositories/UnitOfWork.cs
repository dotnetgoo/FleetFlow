using FleetFlow.DAL.DbContexts;
using FleetFlow.DAL.IRepositories;
using FleetFlow.Domain.Entities;

namespace FleetFlow.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FleetFlowDbContext dbContext;

        public UnitOfWork(FleetFlowDbContext dbContext)
        {
            this.dbContext = dbContext;

            Users = new Repository<User>(dbContext);
            Addresses = new Repository<Address>(dbContext);
            Inventories = new Repository<Inventory>(dbContext);
            Locations = new Repository<Location>(dbContext);
            Merchants = new Repository<Merchant>(dbContext);
            Orders = new Repository<Order>(dbContext);
            OrderItems = new Repository<OrderItem>(dbContext);
            Products = new Repository<Product>(dbContext);
            Carts = new Repository<Cart>(dbContext);
        }

        public IRepository<User> Users { get; private set; }
        public IRepository<Address> Addresses { get; private set; }
        public IRepository<Inventory> Inventories { get; private set; }
        public IRepository<Location> Locations { get; private set; }
        public IRepository<Merchant> Merchants { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<OrderItem> OrderItems { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Cart> Carts { get; private set; }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await dbContext.SaveChangesAsync() >= 0;
        }
    }
}