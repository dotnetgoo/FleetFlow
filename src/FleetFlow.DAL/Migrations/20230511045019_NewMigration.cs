using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    State = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    Street = table.Column<string>(type: "text", nullable: true),
                    ZipCode = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<double>(type: "double precision", nullable: false),
                    Longitude = table.Column<double>(type: "double precision", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: true),
                    Serial = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Weight = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    PaymentStatus = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CartId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    LocationId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    Amount = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CreatedAt", "DeletedBy", "District", "IsDeleted", "Latitude", "Longitude", "State", "Street", "UpdatedAt", "UpdatedBy", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "Navoi", new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6388), null, "Nurata", false, 45.341200000000001, 32.323999999999998, "Uzbekistan", "Medicals", null, null, "210100" },
                    { 2L, "Andijan", new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6392), null, "Paxtachi", false, 42.341200000000001, 20.324000000000002, "Uzbekistan", "Programmers", null, null, "213422" },
                    { 3L, "Bukhara", new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6395), null, "Nurata", false, 44.341200000000001, 35.323999999999998, "Uzbekistan", "Merchants", null, null, "643224" },
                    { 4L, "Kharezm", new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6397), null, "Nurata", false, 47.341200000000001, 27.324000000000002, "Uzbekistan", "Policians", null, null, "100250" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedBy", "Description", "IsDeleted", "Type", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, "a1", new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2574), null, "In the middle", false, 0, null, null },
                    { 2L, "a2", new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2576), null, "In the beginning of entry", false, 0, null, null },
                    { 3L, "i7", new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2577), null, "In the middle", false, 1, null, null },
                    { 4L, "i9", new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2579), null, "In the middle", false, 0, null, null },
                    { 5L, "m1", new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2580), null, "In the middle", false, 1, null, null },
                    { 6L, "m2", new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2582), null, "In the middle", false, 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2307), null, false, "Laptops", null, null },
                    { 2L, new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2309), null, false, "Accesories", null, null },
                    { 3L, new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2311), null, false, "Jewellery", null, null },
                    { 4L, new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2312), null, false, "Medicines", null, null },
                    { 5L, new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2314), null, false, "Telephones", null, null },
                    { 6L, new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2315), null, false, "Toys", null, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "Role", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 11, 4, 50, 18, 656, DateTimeKind.Utc).AddTicks(4612), null, "dotnetgo@icloud.com", "Mukhammadkarim", false, "Tukhtaboyev", "$2a$11$VSHkoRKmMAeoZt3b1DlY6O7mfojHHVpy5grgGc9FLaGzQnWyHbJju", "+998 991239999", 0, null, null },
                    { 2L, new DateTime(2023, 5, 11, 4, 50, 18, 793, DateTimeKind.Utc).AddTicks(5389), null, "wonderboy1w3@gmail.com", "Jamshid", false, "Ma'ruf", "$2a$11$SB1U2Ha5dkXvLG8lUmTJYusRueaVhV9v4P9vMnfY5r2CTeqr1vKE6", "+998 991231999", 1, null, null },
                    { 3L, new DateTime(2023, 5, 11, 4, 50, 18, 922, DateTimeKind.Utc).AddTicks(7667), null, "kabeersolutions@gmail.com", "Kabeer", false, "Solutions", "$2a$11$cRUQjZ4kPgiAQDRsrpxQ6O4v1x1AR2wm2PunalwlXm0kiEqtLwctC", "+998 991232999", 5, null, null },
                    { 4L, new DateTime(2023, 5, 11, 4, 50, 19, 51, DateTimeKind.Utc).AddTicks(8134), null, "nurillaewmuzaffar@gmail.com", "Muzaffar", false, "Nurillayev", "$2a$11$2wN1Iz2pBZ5C5h9dGc2CmeBJBkJci0yahzeUlxMoOl3VHgfbx62de", "+998 995030110", 0, null, null },
                    { 5L, new DateTime(2023, 5, 11, 4, 50, 19, 180, DateTimeKind.Utc).AddTicks(5105), null, "azimochilov@icloud.com", "Azim", false, "Ochilov", "$2a$11$0pvhTEwtyKC3J/yz10eE/ODfdBe6WAKIKyRKXl0hKo.JAFt3GVmmO", "+998 991233999", 2, null, null },
                    { 6L, new DateTime(2023, 5, 11, 4, 50, 19, 310, DateTimeKind.Utc).AddTicks(1297), null, "abdulloh@icloud.com", "Abdulloh", false, "Ahmadjonov", "$2a$11$lVEtqlQ7xNaFDqXvyvKd1OIXlVPD8A5qEsQ.PbqED9bOSwtiNuZra", "+998 991236999", 1, null, null },
                    { 7L, new DateTime(2023, 5, 11, 4, 50, 19, 438, DateTimeKind.Utc).AddTicks(3466), null, "komron2052@gmail.com", "Komron", false, "Rahmonov", "$2a$11$q.6CeOechahjgxsvGnWwwOY5hAtNafqkpacOQHF/Ccs6gtkvQPkOW", "+998 991234999", 4, null, null },
                    { 8L, new DateTime(2023, 5, 11, 4, 50, 19, 568, DateTimeKind.Utc).AddTicks(3882), null, "nozimjon@gmail.com", "Nozimjon", false, "Usmonaliyev", "$2a$11$DkZPWtckjMlzZF9w6hRHHejPU4lyW9VyE0Tcjdfps1TrPM1.uVtqi", "+998 991235999", 3, null, null },
                    { 9L, new DateTime(2023, 5, 11, 4, 50, 19, 700, DateTimeKind.Utc).AddTicks(1829), null, "aljavhar@gmail.com", "AlJavhar", false, "Boyaliyev", "$2a$11$0.k/1APdi3WlDwn.TmhGmeLD2jXHJRsCFF.dJMI7.lMR2KEUChh3W", "+998 902344545", 0, null, null },
                    { 10L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(5511), null, "muhammad@gmail.com", "Muhammad", false, "Rahimboyev", "$2a$11$YYbuNlap2VsmvWkuiSFdl.AueGKs.34mcrLvawL15fhpAnFMExIcq", "+998 937770202", 0, null, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedBy", "IsDeleted", "PaymentStatus", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 1L, 2L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7035), null, false, 0, 1, null, null, 1L });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedBy", "IsDeleted", "Name", "Price", "Serial", "UpdatedAt", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6448), null, false, "HP-Victus", 630m, "a1B5", null, null, 2.2m },
                    { 2L, 1L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6451), null, false, "MacBook-Pro", 2000m, "AKJ-12445", null, null, 1.2m },
                    { 3L, 5L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6453), null, false, "Iphone-14", 1500m, "KLKJL-324342", null, null, 0.1m },
                    { 4L, 6L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6456), null, false, "Spintronics", 100m, "MMMLW-11234", null, null, 4.2m },
                    { 5L, 4L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6460), null, false, "Trimol", 1m, "MML-32423", null, null, 0.002m },
                    { 6L, 2L, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6462), null, false, "SmartWatch", 50m, "JJJO-23423", null, null, 0.1m }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedBy", "IsDeleted", "LocationId", "ProductId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, 1000, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 1L, 6L, null, null },
                    { 2L, 50, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 1L, 1L, null, null },
                    { 3L, 100, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 2L, 3L, null, null },
                    { 4L, 100000, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 3L, 5L, null, null },
                    { 5L, 100, new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 3L, 2L, null, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedBy", "IsDeleted", "OrderId", "ProductId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7062), null, false, 1L, 3L, null, null },
                    { 2L, 4, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7065), null, false, 1L, 6L, null, null },
                    { 3L, 2, new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7066), null, false, 1L, 2L, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_LocationId",
                table: "Inventories",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
