using System;
using FleetFlow.DAL.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    [DbContext(typeof(FleetFlowDbContext))]
    partial class FleetFlowDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FleetFlow.Domain.Entities.Addresses.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("District")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<string>("State")
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            City = "Navoi",
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7493),
                            District = "Nurata",
                            IsDeleted = false,
                            Latitude = 45.341200000000001,
                            Longitude = 32.323999999999998,
                            State = "Uzbekistan",
                            Street = "Medicals",
                            ZipCode = "210100"
                        },
                        new
                        {
                            Id = 2L,
                            City = "Andijan",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4971),
                            District = "Paxtachi",
                            IsDeleted = false,
                            Latitude = 42.341200000000001,
                            Longitude = 20.324000000000002,
                            State = "Uzbekistan",
                            Street = "Programmers",
                            ZipCode = "213422"
                        },
                        new
                        {
                            Id = 3L,
                            City = "Bukhara",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4973),
                            District = "Nurata",
                            IsDeleted = false,
                            Latitude = 44.341200000000001,
                            Longitude = 35.323999999999998,
                            State = "Uzbekistan",
                            Street = "Merchants",
                            ZipCode = "643224"
                        },
                        new
                        {
                            Id = 4L,
                            City = "Kharezm",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4975),
                            District = "Nurata",
                            IsDeleted = false,
                            Latitude = 47.341200000000001,
                            Longitude = 27.324000000000002,
                            State = "Uzbekistan",
                            Street = "Policians",
                            ZipCode = "100250"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Attachments.Attachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("FileName")
                        .HasColumnType("text");

                    b.Property<string>("FilePath")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Authorizations.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2485),
                            IsDeleted = false,
                            Name = "User"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2488),
                            IsDeleted = false,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2490),
                            IsDeleted = false,
                            Name = "Merchant"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2492),
                            IsDeleted = false,
                            Name = "Driver"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2493),
                            IsDeleted = false,
                            Name = "Picker"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2495),
                            IsDeleted = false,
                            Name = "Packer"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Cart", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.CartItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<long>("CartId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Feedbacks.Feedback", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .HasColumnType("text");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Feedbacks.FeedbackAttachment", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AttachmentId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("FeedbackId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AttachmentId");

                    b.HasIndex("FeedbackId");

                    b.ToTable("FeedbackAttachments");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long?>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AddressId = 2L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5147),
                            IsDeleted = false,
                            PaymentStatus = 0,
                            Status = 1,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.OrderAction", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderActions");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5159),
                            IsDeleted = false,
                            OrderId = 1L,
                            ProductId = 3L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 4,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5161),
                            IsDeleted = false,
                            OrderId = 1L,
                            ProductId = 6L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 2,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5162),
                            IsDeleted = false,
                            OrderId = 1L,
                            ProductId = 2L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.Discount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("FinishedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<decimal>("PercentageToCheapen")
                        .HasColumnType("numeric");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("State")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Serial")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Weight")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5008),
                            IsDeleted = false,
                            Name = "HP-Victus",
                            Price = 630m,
                            Serial = "a1B5",
                            Weight = 2.2m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5011),
                            IsDeleted = false,
                            Name = "MacBook-Pro",
                            Price = 2000m,
                            Serial = "AKJ-12445",
                            Weight = 1.2m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 5L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5013),
                            IsDeleted = false,
                            Name = "Iphone-14",
                            Price = 1500m,
                            Serial = "KLKJL-324342",
                            Weight = 0.1m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 6L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5081),
                            IsDeleted = false,
                            Name = "Spintronics",
                            Price = 100m,
                            Serial = "MMMLW-11234",
                            Weight = 4.2m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 4L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5084),
                            IsDeleted = false,
                            Name = "Trimol",
                            Price = 1m,
                            Serial = "MML-32423",
                            Weight = 0.002m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5086),
                            IsDeleted = false,
                            Name = "SmartWatch",
                            Price = 50m,
                            Serial = "JJJO-23423",
                            Weight = 0.1m
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2688),
                            IsDeleted = false,
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2690),
                            IsDeleted = false,
                            Name = "Accesories"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2692),
                            IsDeleted = false,
                            Name = "Jewellery"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2693),
                            IsDeleted = false,
                            Name = "Medicines"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2694),
                            IsDeleted = false,
                            Name = "Telephones"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2696),
                            IsDeleted = false,
                            Name = "Toys"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Users.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 5, 25, 11, 1, 5, 513, DateTimeKind.Utc).AddTicks(8010),
                            Email = "dotnetgo@icloud.com",
                            FirstName = "Mukhammadkarim",
                            IsDeleted = false,
                            LastName = "Tukhtaboyev",
                            Password = "$2a$11$j.bhnF.WVh1eMTQklgjVhuXFHb/cLjmyv6sMvxZCJ4N.EqX49jVzO",
                            Phone = "+998 991239999",
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 869, DateTimeKind.Utc).AddTicks(5286),
                            Email = "wonderboy1w3@gmail.com",
                            FirstName = "Jamshid",
                            IsDeleted = false,
                            LastName = "Ma'ruf",
                            Password = "$2a$11$4BjZs5rKPMCFut51K8EQ7eipFr8/RR/jGoBF0sGpBlukrqfYkQxmi",
                            Phone = "+998 991231999",
                            RoleId = 3L
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 8, DateTimeKind.Utc).AddTicks(5826),
                            Email = "kabeersolutions@gmail.com",
                            FirstName = "Kabeer",
                            IsDeleted = false,
                            LastName = "Solutions",
                            Password = "$2a$11$g1YdSmpGLXLZRnTXjNmc0OYNTTLLjRoGcNrzkhQuvOa3D/NyaiYya",
                            Phone = "+998 991232999",
                            RoleId = 4L
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 150, DateTimeKind.Utc).AddTicks(1224),
                            Email = "nurillaewmuzaffar@gmail.com",
                            FirstName = "Muzaffar",
                            IsDeleted = false,
                            LastName = "Nurillayev",
                            Password = "$2a$11$PbCk6UAesaUp2qbRcjc/L.mnAXSwpmBZE7eG.SfVXlNg8mOJyZ05K",
                            Phone = "+998 995030110",
                            RoleId = 5L
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 296, DateTimeKind.Utc).AddTicks(689),
                            Email = "azimochilov@icloud.com",
                            FirstName = "Azim",
                            IsDeleted = false,
                            LastName = "Ochilov",
                            Password = "$2a$11$WBY0rt7j6m9KD3/4a3xCUeaHSD/AbYANhP12M1dejRscBEMewVwSG",
                            Phone = "+998 991233999",
                            RoleId = 6L
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 437, DateTimeKind.Utc).AddTicks(9933),
                            Email = "abdulloh@icloud.com",
                            FirstName = "Abdulloh",
                            IsDeleted = false,
                            LastName = "Ahmadjonov",
                            Password = "$2a$11$rIqWQ8nNYtBO6Ku72tFYzOWoqIKvqJSAF8E/MMTXtCBcxRbHPlXm6",
                            Phone = "+998 991236999",
                            RoleId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 579, DateTimeKind.Utc).AddTicks(9672),
                            Email = "komron2052@gmail.com",
                            FirstName = "Komron",
                            IsDeleted = false,
                            LastName = "Rahmonov",
                            Password = "$2a$11$RW9jxivZ/k2CGFHggOcAdens0lDqI2kifHQkIofmfr8YkkHq43x8q",
                            Phone = "+998 991234999",
                            RoleId = 2L
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 719, DateTimeKind.Utc).AddTicks(5458),
                            Email = "nozimjon@gmail.com",
                            FirstName = "Nozimjon",
                            IsDeleted = false,
                            LastName = "Usmonaliyev",
                            Password = "$2a$11$COAJfXmqSWhVj1gUmwVjMOw0KKibWUqKzHaOIVfn9WgsFhlP/aEQO",
                            Phone = "+998 991235999",
                            RoleId = 3L
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 43, 860, DateTimeKind.Utc).AddTicks(1136),
                            Email = "aljavhar@gmail.com",
                            FirstName = "AlJavhar",
                            IsDeleted = false,
                            LastName = "Boyaliyev",
                            Password = "$2a$11$eVEYk/wmOj04qtOD8Sfx0uc.osNBGBwUP2e9quamUku7Fumpvl70C",
                            Phone = "+998 902344545",
                            RoleId = 4L
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4508),
                            Email = "muhammad@gmail.com",
                            FirstName = "Muhammad",
                            IsDeleted = false,
                            LastName = "Rahimboyev",
                            Password = "$2a$11$ohqLY7V0ZyvrIqEF2Z6gLur/exM6GvMCh2JtJf46MTIZereKhz0Tu",
                            Phone = "+998 937770202",
                            RoleId = 5L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Warehouses.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1000,
                            CreatedAt = new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 1L,
                            ProductId = 6L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 50,
                            CreatedAt = new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 1L,
                            ProductId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 100,
                            CreatedAt = new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 2L,
                            ProductId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            Amount = 100000,
                            CreatedAt = new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 3L,
                            ProductId = 5L
                        },
                        new
                        {
                            Id = 5L,
                            Amount = 100,
                            CreatedAt = new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc),
                            IsDeleted = false,
                            LocationId = 3L,
                            ProductId = 2L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Warehouses.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("DeletedBy")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "a1",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2877),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            Code = "a2",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2879),
                            Description = "In the beginning of entry",
                            IsDeleted = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 3L,
                            Code = "i7",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2881),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 4L,
                            Code = "i9",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2882),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 0
                        },
                        new
                        {
                            Id = 5L,
                            Code = "m1",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2884),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 1
                        },
                        new
                        {
                            Id = 6L,
                            Code = "m2",
                            CreatedAt = new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2885),
                            Description = "In the middle",
                            IsDeleted = false,
                            Type = 0
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.CartItem", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Cart", "Cart")
                        .WithMany("Items")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Feedbacks.Feedback", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Orders.Order", "Order")
                        .WithMany("Feedbacks")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Feedbacks.FeedbackAttachment", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Attachments.Attachment", "Attachment")
                        .WithMany()
                        .HasForeignKey("AttachmentId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Orders.Feedbacks.Feedback", "Feedback")
                        .WithMany("Attachments")
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Attachment");

                    b.Navigation("Feedback");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Order", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Addresses.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("FleetFlow.Domain.Entities.Users.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.OrderAction", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Orders.Order", "Order")
                        .WithMany("Actions")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.OrderItem", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Orders.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Products.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.Discount", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Products.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.Product", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Products.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Users.User", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Authorizations.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Warehouses.Inventory", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Warehouses.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Addresses.Address", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Cart", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Feedbacks.Feedback", b =>
                {
                    b.Navigation("Attachments");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Orders.Order", b =>
                {
                    b.Navigation("Actions");

                    b.Navigation("Feedbacks");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.Product", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Products.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Users.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
