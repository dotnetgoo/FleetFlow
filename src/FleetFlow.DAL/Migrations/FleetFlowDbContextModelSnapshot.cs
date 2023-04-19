﻿// <auto-generated />
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

            modelBuilder.Entity("FleetFlow.Domain.Entities.Address", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("District")
                        .HasColumnType("text");

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

                    b.Property<string>("ZipCode")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            City = "Navoi",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5712),
                            District = "Nurata",
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
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5715),
                            District = "Paxtachi",
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
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5718),
                            District = "Nurata",
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
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5721),
                            District = "Nurata",
                            Latitude = 47.341200000000001,
                            Longitude = 27.324000000000002,
                            State = "Uzbekistan",
                            Street = "Policians",
                            ZipCode = "100250"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Inventory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("LocationId")
                        .HasColumnType("bigint");

                    b.Property<long>("MerchantId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("MerchantId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1000,
                            CreatedAt = new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LocationId = 1L,
                            MerchantId = 1L,
                            ProductId = 6L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 50,
                            CreatedAt = new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LocationId = 1L,
                            MerchantId = 1L,
                            ProductId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 100,
                            CreatedAt = new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LocationId = 2L,
                            MerchantId = 2L,
                            ProductId = 3L
                        },
                        new
                        {
                            Id = 4L,
                            Amount = 100000,
                            CreatedAt = new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LocationId = 3L,
                            MerchantId = 3L,
                            ProductId = 5L
                        },
                        new
                        {
                            Id = 5L,
                            Amount = 100,
                            CreatedAt = new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            LocationId = 3L,
                            MerchantId = 3L,
                            ProductId = 2L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "a1",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5611),
                            Description = "In the middle",
                            Type = 0
                        },
                        new
                        {
                            Id = 2L,
                            Code = "a2",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5614),
                            Description = "In the beginning of entry",
                            Type = 0
                        },
                        new
                        {
                            Id = 3L,
                            Code = "i7",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5616),
                            Description = "In the middle",
                            Type = 1
                        },
                        new
                        {
                            Id = 4L,
                            Code = "i9",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5619),
                            Description = "In the middle",
                            Type = 0
                        },
                        new
                        {
                            Id = 5L,
                            Code = "m1",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5621),
                            Description = "In the middle",
                            Type = 1
                        },
                        new
                        {
                            Id = 6L,
                            Code = "m2",
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5623),
                            Description = "In the middle",
                            Type = 0
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Merchant", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Website")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Merchants");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AddressId = 1L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5748),
                            Email = "RocketLogisticts@gmail.com",
                            Name = "Rocket Logistics",
                            Phone = "4444",
                            Website = "rLogistics.com"
                        },
                        new
                        {
                            Id = 2L,
                            AddressId = 2L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5751),
                            Email = "giant.delivery@gmail.com",
                            Name = "Giant Delivery",
                            Phone = "777 9 777",
                            Website = "giantdelivery.com"
                        },
                        new
                        {
                            Id = 3L,
                            AddressId = 4L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5753),
                            Email = "ameerLogistics@gmail.com",
                            Name = "Ameer Logistics",
                            Phone = "2020",
                            Website = "ameerlogistics.com"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AddressId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

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
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5928),
                            Status = 0,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.OrderItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("InventoryId")
                        .HasColumnType("bigint");

                    b.Property<long>("OrderId")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Amount = 1,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5949),
                            InventoryId = 3L,
                            OrderId = 1L,
                            ProductId = 3L
                        },
                        new
                        {
                            Id = 2L,
                            Amount = 4,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5952),
                            InventoryId = 1L,
                            OrderId = 1L,
                            ProductId = 6L
                        },
                        new
                        {
                            Id = 3L,
                            Amount = 2,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5958),
                            InventoryId = 5L,
                            OrderId = 1L,
                            ProductId = 2L
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CategoryId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<string>("Serial")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

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
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5779),
                            Name = "HP-Victus",
                            Price = 630m,
                            Serial = "a1B5",
                            Weight = 2.2m
                        },
                        new
                        {
                            Id = 2L,
                            CategoryId = 1L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5782),
                            Name = "MacBook-Pro",
                            Price = 2000m,
                            Serial = "AKJ-12445",
                            Weight = 1.2m
                        },
                        new
                        {
                            Id = 3L,
                            CategoryId = 5L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5785),
                            Name = "Iphone-14",
                            Price = 1500m,
                            Serial = "KLKJL-324342",
                            Weight = 0.1m
                        },
                        new
                        {
                            Id = 4L,
                            CategoryId = 6L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5789),
                            Name = "Spintronics",
                            Price = 100m,
                            Serial = "MMMLW-11234",
                            Weight = 4.2m
                        },
                        new
                        {
                            Id = 5L,
                            CategoryId = 4L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5792),
                            Name = "Trimol",
                            Price = 1m,
                            Serial = "MML-32423",
                            Weight = 0.002m
                        },
                        new
                        {
                            Id = 6L,
                            CategoryId = 2L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5795),
                            Name = "SmartWatch",
                            Price = 50m,
                            Serial = "JJJO-23423",
                            Weight = 0.1m
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5271),
                            Name = "Laptops"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5273),
                            Name = "Accesories"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5276),
                            Name = "Jewellery"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5278),
                            Name = "Medicines"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5280),
                            Name = "Telephones"
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5281),
                            Name = "Toys"
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Salt")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5653),
                            Email = "dotnetgo@icloud.com",
                            FirstName = "Mukhammadkarim",
                            LastName = "Tukhtaboyev",
                            PasswordHash = "12345678",
                            Phone = "+998 991239999",
                            Role = 0
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5656),
                            Email = "wonderboy1w3@gmail.com",
                            FirstName = "Jamshid",
                            LastName = "Ma'ruf",
                            PasswordHash = "124tBghM_78",
                            Phone = "+998 991231999",
                            Role = 1
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5659),
                            Email = "kabeersolutions@gmail.com",
                            FirstName = "Kabeer",
                            LastName = "Solutions",
                            PasswordHash = "4tBghM_78",
                            Phone = "+998 991232999",
                            Role = 5
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5662),
                            Email = "nurillaewmuzaffar@gmail.com",
                            FirstName = "Muzaffar",
                            LastName = "Nurillayev",
                            PasswordHash = "15tBghM678",
                            Phone = "+998 995030110",
                            Role = 0
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5666),
                            Email = "azimochilov@icloud.com",
                            FirstName = "Azim",
                            LastName = "Ochilov",
                            PasswordHash = "14tBghM_2345678",
                            Phone = "+998 991233999",
                            Role = 2
                        },
                        new
                        {
                            Id = 6L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5669),
                            Email = "abdulloh@icloud.com",
                            FirstName = "Abdulloh",
                            LastName = "Ahmadjonov",
                            PasswordHash = "1tBghM5678",
                            Phone = "+998 991236999",
                            Role = 1
                        },
                        new
                        {
                            Id = 7L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5672),
                            Email = "komron2052@gmail.com",
                            FirstName = "Komron",
                            LastName = "Rahmonov",
                            PasswordHash = "1234tBghM_",
                            Phone = "+998 991234999",
                            Role = 4
                        },
                        new
                        {
                            Id = 8L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5676),
                            Email = "nozimjon@gmail.com",
                            FirstName = "Nozimjon",
                            LastName = "Usmonaliyev",
                            PasswordHash = "1234tBghM_78",
                            Phone = "+998 991235999",
                            Role = 3
                        },
                        new
                        {
                            Id = 9L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5679),
                            Email = "aljavhar@gmail.com",
                            FirstName = "AlJavhar",
                            LastName = "Boyaliyev",
                            PasswordHash = "15tBghM678",
                            Phone = "+998 902344545",
                            Role = 0
                        },
                        new
                        {
                            Id = 10L,
                            CreatedAt = new DateTime(2023, 4, 19, 10, 48, 39, 245, DateTimeKind.Utc).AddTicks(5681),
                            Email = "muhammad@gmail.com",
                            FirstName = "Muhammad",
                            LastName = "Rahimboyev",
                            PasswordHash = "15tBghM678",
                            Phone = "+998 937770202",
                            Role = 0
                        });
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Inventory", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Merchant", "Merchant")
                        .WithMany("Inventories")
                        .HasForeignKey("MerchantId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Product", "Product")
                        .WithMany("Inventories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Merchant");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Merchant", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Address", "Address")
                        .WithMany("Merchants")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Order", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Address", "Address")
                        .WithMany("Orders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.OrderItem", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.Inventory", "Inventory")
                        .WithMany()
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("FleetFlow.Domain.Entities.Product", "Product")
                        .WithMany("OrderItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Inventory");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Product", b =>
                {
                    b.HasOne("FleetFlow.Domain.Entities.ProductCategory", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Address", b =>
                {
                    b.Navigation("Merchants");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Merchant", b =>
                {
                    b.Navigation("Inventories");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.Product", b =>
                {
                    b.Navigation("Inventories");

                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("FleetFlow.Domain.Entities.User", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
