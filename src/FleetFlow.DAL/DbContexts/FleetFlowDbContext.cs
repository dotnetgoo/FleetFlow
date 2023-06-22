using FleetFlow.Domain.Entities;
using FleetFlow.Domain.Entities.Addresses;
using FleetFlow.Domain.Entities.Attachments;
using FleetFlow.Domain.Entities.Authorizations;
using FleetFlow.Domain.Entities.Bonuses;
using FleetFlow.Domain.Entities.Orders;
using FleetFlow.Domain.Entities.Orders.Feedbacks;
using FleetFlow.Domain.Entities.Products;
using FleetFlow.Domain.Entities.StaffPermissions;
using FleetFlow.Domain.Entities.Staffs;
using FleetFlow.Domain.Entities.UserQuestions;
using FleetFlow.Domain.Entities.Users;
using FleetFlow.Domain.Entities.Warehouses;
using FleetFlow.Shared.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FleetFlow.DAL.DbContexts
{
    public class FleetFlowDbContext : DbContext
    {
        public FleetFlowDbContext(DbContextOptions<FleetFlowDbContext> options)
            : base(options)
        {
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<InventoryLog> InventoryLogs { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<OrderAction> OrderActions { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackAttachment> FeedbackAttachments { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<StaffPermission> StaffPermissions { get; set; }
        public DbSet<Bonus> Bonuses { get; set; }
        public DbSet<BonusSetting> BonusSettings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent API relations

            modelBuilder.Entity<ProductInventory>()
                .HasOne(pia => pia.Product)
                .WithMany()
                .HasForeignKey(pia => pia.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProductInventory>()
                .HasOne(pia => pia.Location)
                .WithMany()
                .HasForeignKey(pia => pia.LocationId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ProductInventory>()
                .HasOne(pia => pia.Inventory)
                .WithMany()
                .HasForeignKey(pia => pia.InventoryId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Inventory>()
                .HasOne(i => i.Address)
                .WithMany()
                .HasForeignKey(i => i.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Address)
                .WithMany()
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Order>(o => o.PaymentId)
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

            modelBuilder.Entity<OrderAction>()
                .HasOne(action => action.Order)
                .WithMany(order => order.Actions)
                .HasForeignKey(action => action.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Feedback>()
                .HasOne(f => f.Order)
                .WithMany(o => o.Feedbacks)
                .HasForeignKey(f => f.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FeedbackAttachment>()
                .HasOne(fa => fa.Feedback)
                .WithMany(f => f.Attachments)
                .HasForeignKey(fa => fa.FeedbackId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FeedbackAttachment>()
                .HasOne(fa => fa.Attachment)
                .WithMany()
                .HasForeignKey(fa => fa.AttachmentId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Discount>()
                .HasOne(discount => discount.Product)
                .WithMany(product => product.Discounts)
                .HasForeignKey(discount => discount.ProductId)
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
                new Location() { Id = 1, Code = 1, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 2, Code = 2, Description = "In the beginning of entry", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 3, Code = 3, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 4, Code = 4, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 5, Code = 5, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Location() { Id = 6, Code = 6, Description = "In the middle", CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );

            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Name = "User", CreatedAt = DateTime.UtcNow, IsDeleted = false, UpdatedBy = null, DeletedBy = null, UpdatedAt = null },
                new Role() { Id = 2, Name = "Admin", CreatedAt = DateTime.UtcNow, IsDeleted = false, UpdatedBy = null, DeletedBy = null, UpdatedAt = null },
                new Role() { Id = 3, Name = "Merchant", CreatedAt = DateTime.UtcNow, IsDeleted = false, UpdatedBy = null, DeletedBy = null, UpdatedAt = null },
                new Role() { Id = 4, Name = "Driver", CreatedAt = DateTime.UtcNow, IsDeleted = false, UpdatedBy = null, DeletedBy = null, UpdatedAt = null },
                new Role() { Id = 5, Name = "Picker", CreatedAt = DateTime.UtcNow, IsDeleted = false, UpdatedBy = null, DeletedBy = null, UpdatedAt = null },
                new Role() { Id = 6, Name = "Packer", CreatedAt = DateTime.UtcNow, IsDeleted = false, UpdatedBy = null, DeletedBy = null, UpdatedAt = null }
                );

            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, FirstName = "Mukhammadkarim", LastName = "Tukhtaboyev", Email = "dotnetgo@icloud.com", Phone = "+998 991239999", RoleId = 2, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 2, FirstName = "Jamshid", LastName = "Ma'ruf", Email = "wonderboy1w3@gmail.com", Phone = "+998 991231999", RoleId = 3, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 3, FirstName = "Kabeer", LastName = "Solutions", Email = "kabeersolutions@gmail.com", Phone = "+998 991232999", RoleId = 4, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 4, FirstName = "Muzaffar", LastName = "Nurillayev", Email = "nurillaewmuzaffar@gmail.com", Phone = "+998 995030110", RoleId = 5, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 5, FirstName = "Azim", LastName = "Ochilov", Email = "azimochilov@icloud.com", Phone = "+998 991233999", RoleId = 6, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 6, FirstName = "Abdulloh", LastName = "Ahmadjonov", Email = "abdulloh@icloud.com", Phone = "+998 991236999", RoleId = 1, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 7, FirstName = "Komron", LastName = "Rahmonov", Email = "komron2052@gmail.com", Phone = "+998 991234999", RoleId = 2, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 8, FirstName = "Nozimjon", LastName = "Usmonaliyev", Email = "nozimjon@gmail.com", Phone = "+998 991235999", RoleId = 3, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 9, FirstName = "AlJavhar", LastName = "Boyaliyev", Email = "aljavhar@gmail.com", Phone = "+998 902344545", RoleId = 4, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new User() { Id = 10, FirstName = "Muhammad", LastName = "Rahimboyev", Email = "muhammad@gmail.com", Phone = "+998 937770202", RoleId = 5, Password = PasswordHelper.Hash("12345678"), CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );

            //modelBuilder.Entity<Address>().HasData(
            //    new Address() { Id = 2, Latitude = 42.3412, Longitude = 20.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Address() { Id = 3, Latitude = 44.3412, Longitude = 35.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Address() { Id = 4, Latitude = 47.3412, Longitude = 27.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Address() { Id = 1, Latitude = 45.3412, Longitude = 32.324, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
            //    );

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id = 1, Name = "HP-Victus", Serial = "a1B5", Price = 630, Weight = 2.2M, CategoryId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Product() { Id = 2, Name = "MacBook-Pro", Serial = "AKJ-12445", Price = 2000, Weight = 1.2M, CategoryId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Product() { Id = 3, Name = "Iphone-14", Serial = "KLKJL-324342", Price = 1500, Weight = 0.1M, CategoryId = 5, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Product() { Id = 4, Name = "Spintronics", Serial = "MMMLW-11234", Price = 100, Weight = 4.2M, CategoryId = 6, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Product() { Id = 5, Name = "Trimol", Serial = "MML-32423", Price = 1, Weight = 0.002M, CategoryId = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Product() { Id = 6, Name = "SmartWatch", Serial = "JJJO-23423", Price = 50, Weight = 0.1M, CategoryId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );

            //modelBuilder.Entity<Inventory>().HasData(
            //    new Inventory() { Id = 1, Name = "Shayxon", Description = "Eng katta va asosiy filial", AddressId = 1, OwnerId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Inventory() { Id = 2, Name = "Chilonzor", Description = "Chilonzor filial", AddressId = 1, OwnerId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Inventory() { Id = 3, Name = "Xadra", Description = "Xadra filial", AddressId = 2, OwnerId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Inventory() { Id = 4, Name = "Shodlik", Description = "Eng shinam filial", AddressId = 3, OwnerId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Inventory() { Id = 5, Name = "Charxiy", Description = "Eng kichik filial", AddressId = 1, OwnerId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
            //    );

            //modelBuilder.Entity<Order>().HasData(
            //    new Order() { Id = 1, UserId = 1, DistrictId = 1, AddressId = 1, Status = OrderStatus.Shipped, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Order() { Id = 2, UserId = 3, DistrictId = 1, AddressId = 2, PaymentStatus = PaymentStatus.Paid, Status = OrderStatus.Shipped, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Order() { Id = 3, UserId = 4, DistrictId = 1, AddressId = 1, PaymentStatus = PaymentStatus.Paid, Status = OrderStatus.Shipped, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Order() { Id = 4, UserId = 3, DistrictId = 1, AddressId = 2, PaymentStatus = PaymentStatus.Paid, Status = OrderStatus.Shipped, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Order() { Id = 5, UserId = 2, DistrictId = 1, AddressId = 1, PaymentStatus = PaymentStatus.Paid, Status = OrderStatus.Shipped, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new Order() { Id = 6, UserId = 4, DistrictId = 1, AddressId = 2, PaymentStatus = PaymentStatus.Paid, Status = OrderStatus.Shipped, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
            //    );

            //modelBuilder.Entity<ProductInventory>().HasData(
            //    new ProductInventory() { Id = 1, ProductId = 1, Amount = 1, InventoryId = 1, LocationId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new ProductInventory() { Id = 2, ProductId = 2, Amount = 2, InventoryId = 2, LocationId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new ProductInventory() { Id = 3, ProductId = 3, Amount = 3, InventoryId = 3, LocationId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new ProductInventory() { Id = 4, ProductId = 4, Amount = 4, InventoryId = 4, LocationId = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
            //    new ProductInventory() { Id = 5, ProductId = 5, Amount = 5, InventoryId = 5, LocationId = 5, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
            //    );

            //modelBuilder.Entity<InventoryLog>().HasData(
            //    new InventoryLog() { Id = 1, ProductId = 1, Amount = 1, OwnerId = 1, Type = InventoryLogType.Added, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
            //    new InventoryLog() { Id = 2, ProductId = 2, Amount = 2, OwnerId = 1, Type = InventoryLogType.Added, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
            //    new InventoryLog() { Id = 3, ProductId = 3, Amount = 3, OwnerId = 1, Type = InventoryLogType.Added, CreatedAt = DateTime.UtcNow, UpdatedAt = null},

            //    new InventoryLog() { Id = 4, ProductId = 4, Amount = 4, OwnerId = 1, Type = InventoryLogType.Removed, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
            //    new InventoryLog() { Id = 5, ProductId = 5, Amount = 5, OwnerId = 1, Type = InventoryLogType.Removed, CreatedAt = DateTime.UtcNow, UpdatedAt = null},
            //    new InventoryLog() { Id = 6, ProductId = 6, Amount = 6, OwnerId = 1, Type = InventoryLogType.Removed, CreatedAt = DateTime.UtcNow, UpdatedAt = null}
            //    );

            //modelBuilder.Entity<Attachment>().HasData(
            //    new Attachment() { Id = 1, CreatedAt = DateTime.UtcNow, FileName = "s", FilePath = "s" });

            //modelBuilder.Entity<Payment>().HasData(
            //    new Payment() { UserId = 3, Id = 1, Amount = 6130, OrderId = 2,CreatedAt = DateTime.UtcNow, Status = PaymentStatus.Paid, FileId = 1 },
            //    new Payment() { UserId = 4, Id = 2, Amount = 11620, OrderId = 3, CreatedAt = DateTime.UtcNow, Status = PaymentStatus.Paid, FileId = 1 },
            //    new Payment() { UserId = 3, Id = 3, Amount = 9630, OrderId = 4, CreatedAt = DateTime.UtcNow, Status = PaymentStatus.Paid, FileId = 1 },
            //    new Payment() { UserId = 2, Id = 4, Amount = 7260, OrderId = 5, CreatedAt = DateTime.UtcNow, Status = PaymentStatus.Paid, FileId = 1 },
            //    new Payment() { UserId = 4, Id = 5, Amount = 2000, OrderId = 6, CreatedAt = DateTime.UtcNow, Status = PaymentStatus.Paid, FileId = 1 });

            //modelBuilder.Entity<OrderItem>().HasData(
            //    new OrderItem() { Id = 4, OrderId = 2, ProductId = 1, Amount = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 5, OrderId = 2, ProductId = 2, Amount = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 6, OrderId = 2, ProductId = 3, Amount = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 7, OrderId = 3, ProductId = 4, Amount = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 8, OrderId = 3, ProductId = 3, Amount = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 9, OrderId = 3, ProductId = 2, Amount = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 10, OrderId = 3, ProductId = 1, Amount = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 11, OrderId = 4, ProductId = 2, Amount = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 12, OrderId = 4, ProductId = 1, Amount = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 13, OrderId = 4, ProductId = 3, Amount = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 14, OrderId = 5, ProductId = 3, Amount = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 15, OrderId = 5, ProductId = 1, Amount = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null, },
            //    new OrderItem() { Id = 16, OrderId = 6, ProductId = 2, Amount = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null, }
            //);

            //modelBuilder.Entity<Question>().HasData(
            //    new Question() { Id = 1, IsDeleted = false, CreatedAt = DateTime.UtcNow, IsAnswered = true, Message = "Hello .NET N6 group", UserId = 1 ,UpdatedAt = null}
            //    );

            modelBuilder.Entity<Staff>().HasData(
                new Staff() { Id = 1, UserId = 1, RoleId = 1, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Staff() { Id = 2, UserId = 2, RoleId = 2, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Staff() { Id = 3, UserId = 3, RoleId = 3, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Staff() { Id = 4, UserId = 4, RoleId = 4, CreatedAt = DateTime.UtcNow, UpdatedAt = null },
                new Staff() { Id = 5, UserId = 5, RoleId = 5, CreatedAt = DateTime.UtcNow, UpdatedAt = null }
                );
            #endregion
        }
    }
}