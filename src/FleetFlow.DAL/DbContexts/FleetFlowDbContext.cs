using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Enums;
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
        public DbSet<ProductCategory> ProductCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent API relations
            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Product)
                .WithMany(p => p.Inventories)
                .HasForeignKey(i => i.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Location)
                .WithMany()
                .HasForeignKey(i => i.LocationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Merchant)
                .WithMany(m => m.Inventories)
                .HasForeignKey(i => i.MerchantId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Merchant>()
                .HasOne(m => m.Address)
                .WithMany(a => a.Merchants)
                .HasForeignKey(m => m.AddressId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany()
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithMany(a => a.Orders)
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>()
                .HasOne(item => item.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(item => item.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>()
                .HasOne(item => item.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(item => item.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);
            #endregion

            #region Seed
            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory() { Id = 1, Name = "Laptops", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new ProductCategory() { Id = 2, Name = "Accesories", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new ProductCategory() { Id = 3, Name = "Jewellery", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new ProductCategory() { Id = 4, Name = "Medicines", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new ProductCategory() { Id = 5, Name = "Telephones", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new ProductCategory() { Id = 6, Name = "Toys", CreatedAt = DateTime.UtcNow, UpdatedAt = null } 
                );

            modelBuilder.Entity<Location>().HasData(
                new Location() { Id = 1, Code = "a1", Type = LocationType.Shelf, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 2, Code = "a2", Type = 0, Description = "In the beginning of entry", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 3, Code = "i7", Type = LocationType.Cart, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 4, Code = "i9", Type = LocationType.Shelf, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 5, Code = "m1", Type = LocationType.Cart, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 6, Code = "m2", Type = LocationType.Shelf, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Mukhammadkarim", LastName = "Tukhtaboyev", Email = "dotnetgo@icloud.com", Phone = "+998 991239999", Role = UserRole.Admin, Password = "12345678", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 2, FirstName = "Jamshid", LastName = "Ma'ruf", Email = "wonderboy1w3@gmail.com", Phone = "+998 991231999", Role = UserRole.User, Password = "124tBghM_78", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 3, FirstName = "Kabeer", LastName = "Solutions", Email = "kabeersolutions@gmail.com", Phone = "+998 991232999", Role = UserRole.Packer, Password = "4tBghM_78", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 4, FirstName = "Muzaffar", LastName = "Nurillayev", Email = "nurillaewmuzaffar@gmail.com", Phone = "+998 995030110", Role = UserRole.Admin, Password = "15tBghM678", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 5, FirstName = "Azim", LastName = "Ochilov", Email = "azimochilov@icloud.com", Phone = "+998 991233999", Role = UserRole.Merchant, Password = "14tBghM_2345678", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 6, FirstName = "Abdulloh", LastName = "Ahmadjonov", Email = "abdulloh@icloud.com", Phone = "+998 991236999", Role = UserRole.User, Password = "1tBghM5678", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 7, FirstName = "Komron", LastName = "Rahmonov", Email = "komron2052@gmail.com", Phone = "+998 991234999", Role = UserRole.Picker, Password = "1234tBghM_", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 8, FirstName = "Nozimjon", LastName = "Usmonaliyev", Email = "nozimjon@gmail.com", Phone = "+998 991235999", Role = UserRole.Driver, Password = "1234tBghM_78", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 9, FirstName = "AlJavhar", LastName = "Boyaliyev", Email = "aljavhar@gmail.com", Phone = "+998 902344545", Role = UserRole.Admin, Password = "15tBghM678", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new User() { Id = 10, FirstName = "Muhammad", LastName = "Rahimboyev", Email = "muhammad@gmail.com", Phone = "+998 937770202", Role = UserRole.Admin, Password = "15tBghM678", CreatedAt = DateTime.UtcNow, UpdatedAt = null}
                );

            modelBuilder.Entity<Address>().HasData(
                new Address() { Id = 1, State = "Uzbekistan", City = "Navoi", District = "Nurata", Street = "Medicals", ZipCode = "210100", Latitude = 45.3412, Longitude = 32.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Address() { Id = 2, State = "Uzbekistan", City = "Andijan", District = "Paxtachi", Street = "Programmers", ZipCode = "213422", Latitude = 42.3412, Longitude = 20.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Address() { Id = 3, State = "Uzbekistan", City = "Bukhara", District = "Nurata", Street = "Merchants", ZipCode = "643224", Latitude = 44.3412, Longitude = 35.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Address() { Id = 4, State = "Uzbekistan", City = "Kharezm", District = "Nurata", Street = "Policians", ZipCode = "100250", Latitude = 47.3412, Longitude = 27.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );

            modelBuilder.Entity<Merchant>().HasData(
                new Merchant() { Id = 1, Name = "Rocket Logistics", AddressId = 1, Phone = "4444", Email = "RocketLogisticts@gmail.com", Website = "rLogistics.com", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Merchant() { Id = 2, Name = "Giant Delivery", AddressId = 2, Phone = "777 9 777", Email = "giant.delivery@gmail.com", Website = "giantdelivery.com", CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Merchant() { Id = 3, Name = "Ameer Logistics", AddressId = 4, Phone = "2020", Email = "ameerLogistics@gmail.com", Website = "ameerlogistics.com", CreatedAt = DateTime.UtcNow, UpdatedAt = null}
                );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "HP-Victus", Serial = "a1B5", Price = 630, Weight = 2.2M, CategoryId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Product() { Id = 2, Name = "MacBook-Pro", Serial = "AKJ-12445", Price = 2000, Weight = 1.2M, CategoryId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Product() { Id = 3, Name = "Iphone-14", Serial = "KLKJL-324342", Price = 1500, Weight = 0.1M, CategoryId = 5, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Product() { Id = 4, Name = "Spintronics", Serial = "MMMLW-11234", Price = 100, Weight = 4.2M, CategoryId = 6, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Product() { Id = 5, Name = "Trimol", Serial = "MML-32423", Price = 1, Weight = 0.002M, CategoryId = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
                new Product() { Id = 6, Name = "SmartWatch", Serial = "JJJO-23423", Price = 50, Weight = 0.1M, CategoryId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null}
                );

            modelBuilder.Entity<Inventory>().HasData(
                new Inventory() { Id = 1, ProductId = 6, Amount = 1000, LocationId = 1, MerchantId = 1, CreatedAt = DateTime.UtcNow.Date, UpdatedAt = null},
                new Inventory() { Id = 2, ProductId = 1, Amount = 50, LocationId = 1, MerchantId = 1, CreatedAt = DateTime.UtcNow.Date, UpdatedAt = null},
                new Inventory() { Id = 3, ProductId = 3, Amount = 100, LocationId = 2, MerchantId = 2, CreatedAt = DateTime.UtcNow.Date, UpdatedAt = null},
                new Inventory() { Id = 4, ProductId = 5, Amount = 100000, LocationId = 3, MerchantId = 3, CreatedAt = DateTime.UtcNow.Date, UpdatedAt = null},
                new Inventory() { Id = 5, ProductId = 2, Amount = 100, LocationId = 3, MerchantId = 3, CreatedAt = DateTime.UtcNow.Date, UpdatedAt = null}
                );
            modelBuilder.Entity<Order>().HasData(
                new Order() { Id = 1, UserId = 1, AddressId = 2, Status = OrderStatus.Pending, CreatedAt = DateTime.UtcNow, UpdatedAt = null}
                );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem() { Id = 1, OrderId = 1, ProductId = 3, Amount = 1, InventoryId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new OrderItem() { Id = 2, OrderId = 1, ProductId = 6, Amount = 4, InventoryId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new OrderItem() { Id = 3, OrderId = 1, ProductId = 2, Amount = 2, InventoryId = 5, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );
            #endregion
        }
    }
}