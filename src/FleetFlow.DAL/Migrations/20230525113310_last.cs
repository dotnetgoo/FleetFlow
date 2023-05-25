using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class last : Migration
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
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FilePath = table.Column<string>(type: "text", nullable: true),
                    FileName = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.Id);
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
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
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
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
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
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
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
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    PercentageToCheapen = table.Column<decimal>(type: "numeric", nullable: false),
                    State = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discounts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
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
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: true),
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
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Message = table.Column<string>(type: "text", nullable: true),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderActions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderActions_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
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

            migrationBuilder.CreateTable(
                name: "FeedbackAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FeedbackId = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentId = table.Column<long>(type: "bigint", nullable: false),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackAttachments_Attachments_AttachmentId",
                        column: x => x.AttachmentId,
                        principalTable: "Attachments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FeedbackAttachments_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CreatedAt", "DeletedBy", "District", "IsDeleted", "Latitude", "Longitude", "State", "Street", "UpdatedAt", "UpdatedBy", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "Navoi", new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5320), null, "Nurata", false, 45.341200000000001, 32.323999999999998, "Uzbekistan", "Medicals", null, null, "210100" },
                    { 2L, "Andijan", new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5323), null, "Paxtachi", false, 42.341200000000001, 20.324000000000002, "Uzbekistan", "Programmers", null, null, "213422" },
                    { 3L, "Bukhara", new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5325), null, "Nurata", false, 44.341200000000001, 35.323999999999998, "Uzbekistan", "Merchants", null, null, "643224" },
                    { 4L, "Kharezm", new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5326), null, "Nurata", false, 47.341200000000001, 27.324000000000002, "Uzbekistan", "Policians", null, null, "100250" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "Description", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3621), null, "In the middle", false, null, null, null },
                    { 2L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3626), null, "In the beginning of entry", false, null, null, null },
                    { 3L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3627), null, "In the middle", false, null, null, null },
                    { 4L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3628), null, "In the middle", false, null, null, null },
                    { 5L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3629), null, "In the middle", false, null, null, null },
                    { 6L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3630), null, "In the middle", false, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3422), null, false, "Laptops", null, null },
                    { 2L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3425), null, false, "Accesories", null, null },
                    { 3L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3426), null, false, "Jewellery", null, null },
                    { 4L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3427), null, false, "Medicines", null, null },
                    { 5L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3428), null, false, "Telephones", null, null },
                    { 6L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3429), null, false, "Toys", null, null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3654), null, false, "User", null, null },
                    { 2L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3657), null, false, "Admin", null, null },
                    { 3L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3659), null, false, "Merchant", null, null },
                    { 4L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3660), null, false, "Driver", null, null },
                    { 5L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3661), null, false, "Picker", null, null },
                    { 6L, new DateTime(2023, 5, 25, 11, 33, 9, 233, DateTimeKind.Utc).AddTicks(3663), null, false, "Packer", null, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "DeletedBy", "IsDeleted", "Name", "Price", "Serial", "UpdatedAt", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5372), null, false, "HP-Victus", 630m, "a1B5", null, null, 2.2m },
                    { 2L, 1L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5374), null, false, "MacBook-Pro", 2000m, "AKJ-12445", null, null, 1.2m },
                    { 3L, 5L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5376), null, false, "Iphone-14", 1500m, "KLKJL-324342", null, null, 0.1m },
                    { 4L, 6L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5378), null, false, "Spintronics", 100m, "MMMLW-11234", null, null, 4.2m },
                    { 5L, 4L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5382), null, false, "Trimol", 1m, "MML-32423", null, null, 0.002m },
                    { 6L, 2L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5383), null, false, "SmartWatch", 50m, "JJJO-23423", null, null, 0.1m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "Email", "FirstName", "IsDeleted", "LastName", "Password", "Phone", "RoleId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 25, 11, 33, 9, 359, DateTimeKind.Utc).AddTicks(8992), null, "dotnetgo@icloud.com", "Mukhammadkarim", false, "Tukhtaboyev", "$2a$11$ocg1IVmxYbBZ4Rgs82wm/O/DlcOrgMYea/OKIq8J4wt6AT.0xVd.i", "+998 991239999", 2L, null, null },
                    { 2L, new DateTime(2023, 5, 25, 11, 33, 9, 486, DateTimeKind.Utc).AddTicks(5424), null, "wonderboy1w3@gmail.com", "Jamshid", false, "Ma'ruf", "$2a$11$dstnWmZ9d1InMGY9my/r6.77O8kCh/Y.dy7xRLzbQAsFpXnIOrVxK", "+998 991231999", 3L, null, null },
                    { 3L, new DateTime(2023, 5, 25, 11, 33, 9, 614, DateTimeKind.Utc).AddTicks(6077), null, "kabeersolutions@gmail.com", "Kabeer", false, "Solutions", "$2a$11$jmJEsBqx1k6YZsL.Kjy4yO6pYYLKuzbqwe228ajObWRDMFBrbg14a", "+998 991232999", 4L, null, null },
                    { 4L, new DateTime(2023, 5, 25, 11, 33, 9, 740, DateTimeKind.Utc).AddTicks(2103), null, "nurillaewmuzaffar@gmail.com", "Muzaffar", false, "Nurillayev", "$2a$11$DRkhHsyb/Uv9bZUGh6Hd6uSoaEmcsdkD24xZfGcJpBGdTYXckoJze", "+998 995030110", 5L, null, null },
                    { 5L, new DateTime(2023, 5, 25, 11, 33, 9, 863, DateTimeKind.Utc).AddTicks(2888), null, "azimochilov@icloud.com", "Azim", false, "Ochilov", "$2a$11$olfwyrEvL84QO9yCZB1e4uPP8exkXMLNQpEun805ySeKBCz8IAkta", "+998 991233999", 6L, null, null },
                    { 6L, new DateTime(2023, 5, 25, 11, 33, 9, 986, DateTimeKind.Utc).AddTicks(3958), null, "abdulloh@icloud.com", "Abdulloh", false, "Ahmadjonov", "$2a$11$0UNovYjyvib/1tJojshyC.R36VQT4VZE1/ctmTWje8pU1EQYA05/6", "+998 991236999", 1L, null, null },
                    { 7L, new DateTime(2023, 5, 25, 11, 33, 10, 110, DateTimeKind.Utc).AddTicks(6463), null, "komron2052@gmail.com", "Komron", false, "Rahmonov", "$2a$11$2XSJu2XaILH3AZKl6Bb1Du6j5KvF3NYAMFtFAA87CWOoCPXKJtEtG", "+998 991234999", 2L, null, null },
                    { 8L, new DateTime(2023, 5, 25, 11, 33, 10, 236, DateTimeKind.Utc).AddTicks(9179), null, "nozimjon@gmail.com", "Nozimjon", false, "Usmonaliyev", "$2a$11$XdUCsX2vjiGvke83zOxBhujrI9jA/MJ5aKVadUULqbg/TSH66WYB.", "+998 991235999", 3L, null, null },
                    { 9L, new DateTime(2023, 5, 25, 11, 33, 10, 363, DateTimeKind.Utc).AddTicks(8016), null, "aljavhar@gmail.com", "AlJavhar", false, "Boyaliyev", "$2a$11$jy7agtwyKEjtD1o55ptKJewa3R3yx1wb6px8Zx0TM5gTXrBsbUIse", "+998 902344545", 4L, null, null },
                    { 10L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(4682), null, "muhammad@gmail.com", "Muhammad", false, "Rahimboyev", "$2a$11$XF3QbPHPk07Nk7DjsQVN2.FndurqHaV/AUnnZpnqha/G6NRalTCVK", "+998 937770202", 5L, null, null }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedBy", "IsDeleted", "LocationId", "ProductId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, 1000, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 1L, 6L, null, null },
                    { 2L, 50, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 1L, 1L, null, null },
                    { 3L, 100, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 2L, 3L, null, null },
                    { 4L, 100000, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 3L, 5L, null, null },
                    { 5L, 100, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Utc), null, false, 3L, 2L, null, null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedBy", "IsDeleted", "PaymentStatus", "Status", "UpdatedAt", "UpdatedBy", "UserId" },
                values: new object[] { 1L, 2L, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5467), null, false, 0, 1, null, null, 1L });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Amount", "CreatedAt", "DeletedBy", "IsDeleted", "OrderId", "ProductId", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5491), null, false, 1L, 3L, null, null },
                    { 2L, 4, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5492), null, false, 1L, 6L, null, null },
                    { 3L, 2, new DateTime(2023, 5, 25, 11, 33, 10, 487, DateTimeKind.Utc).AddTicks(5493), null, false, 1L, 2L, null, null }
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
                name: "IX_Discounts_ProductId",
                table: "Discounts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackAttachments_AttachmentId",
                table: "FeedbackAttachments",
                column: "AttachmentId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackAttachments_FeedbackId",
                table: "FeedbackAttachments",
                column: "FeedbackId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_OrderId",
                table: "Feedbacks",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_LocationId",
                table: "Inventories",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderActions_OrderId",
                table: "OrderActions",
                column: "OrderId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "FeedbackAttachments");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "OrderActions");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
