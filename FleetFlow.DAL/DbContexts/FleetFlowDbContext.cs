using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FleetFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.DAL.DbContexts
{
    public class FleetFlowDbContext : DbContext
    {
        public FleetFlowDbContext()
        {
            
        }

        public FleetFlowDbContext(DbContextOptions<FleetFlowDbContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; User Id=postgres; Password=root; Database=FleetFlowDb;");
        }


        public DbSet<Address> Addresses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>()
        }
    }
}