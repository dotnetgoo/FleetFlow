using FleetFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.DAL.DbContexts
{
    public class FleetFlowDbContext : DbContext
    {
        public FleetFlowDbContext(DbContextOptions<FleetFlowDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}