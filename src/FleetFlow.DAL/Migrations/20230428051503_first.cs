using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
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
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Merchants_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
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
                    UserId1 = table.Column<long>(type: "bigint", nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
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
                    MerchantId = table.Column<long>(type: "bigint", nullable: false),
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
                        name: "FK_Inventories_Merchants_MerchantId",
                        column: x => x.MerchantId,
                        principalTable: "Merchants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
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
                    InventoryId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_Inventories_InventoryId",
                        column: x => x.InventoryId,
                        principalTable: "Inventories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                columns: new[] { "Id", "City", "CreatedAt", "District", "Latitude", "Longitude", "State", "Street", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "Navoi", new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(954), "Nurata", 45.341200000000001, 32.323999999999998, "Uzbekistan", "Medicals", null, "210100" },
                    { 2L, "Andijan", new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(957), "Paxtachi", 42.341200000000001, 20.324000000000002, "Uzbekistan", "Programmers", null, "213422" },
                    { 3L, "Bukhara", new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(960), "Nurata", 44.341200000000001, 35.323999999999998, "Uzbekistan", "Merchants", null, "643224" },
                    { 4L, "Kharezm", new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1043), "Nurata", 47.341200000000001, 27.324000000000002, "Uzbekistan", "Policians", null, "100250" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Code", "CreatedAt", "Description", "Type", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, "a1", new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(688), "In the middle", 0, null },
                    { 2L, "a2", new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(690), "In the beginning of entry", 0, null },
                    { 3L, "i7", new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(692), "In the middle", 1, null },
                    { 4L, "i9", new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(693), "In the middle", 0, null },
                    { 5L, "m1", new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(694), "In the middle", 1, null },
                    { 6L, "m2", new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(696), "In the middle", 0, null }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(547), "Laptops", null },
                    { 2L, new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(549), "Accesories", null },
                    { 3L, new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(550), "Jewellery", null },
                    { 4L, new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(552), "Medicines", null },
                    { 5L, new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(553), "Telephones", null },
                    { 6L, new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(554), "Toys", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "FirstName", "LastName", "Password", "Phone", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 4, 28, 5, 15, 2, 110, DateTimeKind.Utc).AddTicks(6970), "dotnetgo@icloud.com", "Mukhammadkarim", "Tukhtaboyev", "$2a$11$ttOx9ksYwwWX9BLwCS.sMuxm.XkxDfwJPG0XJWIEhNTdgOww1trBu", "+998 991239999", 0, null },
                    { 2L, new DateTime(2023, 4, 28, 5, 15, 2, 252, DateTimeKind.Utc).AddTicks(2018), "wonderboy1w3@gmail.com", "Jamshid", "Ma'ruf", "$2a$11$G4OCuDzeANhaPSvL/9UAQODDQNglFUtYEuPYzrLVvZL1PNJTago7C", "+998 991231999", 1, null },
                    { 3L, new DateTime(2023, 4, 28, 5, 15, 2, 394, DateTimeKind.Utc).AddTicks(115), "kabeersolutions@gmail.com", "Kabeer", "Solutions", "$2a$11$CqaRF/0B44.RDR.dZ3uLVuG4s7r4z.3vO0B0k4hGp2.b6oUWpBn5i", "+998 991232999", 5, null },
                    { 4L, new DateTime(2023, 4, 28, 5, 15, 2, 534, DateTimeKind.Utc).AddTicks(5557), "nurillaewmuzaffar@gmail.com", "Muzaffar", "Nurillayev", "$2a$11$JiMBT6vhTdJC/8cYfQrfDe.JG6I52VKyF2DV1qGXAMBpuRPCCpiTq", "+998 995030110", 0, null },
                    { 5L, new DateTime(2023, 4, 28, 5, 15, 2, 676, DateTimeKind.Utc).AddTicks(4669), "azimochilov@icloud.com", "Azim", "Ochilov", "$2a$11$hdNy4mGNchO9Nx28tCiQNeg0iR7ITcNEFDxMStBCRxTGNixBIDArW", "+998 991233999", 2, null },
                    { 6L, new DateTime(2023, 4, 28, 5, 15, 2, 817, DateTimeKind.Utc).AddTicks(3593), "abdulloh@icloud.com", "Abdulloh", "Ahmadjonov", "$2a$11$q9s9mz7B2nYsxKCGKnNzOeMnf0WANSitKheuh4Wv0acn5j2pD7kee", "+998 991236999", 1, null },
                    { 7L, new DateTime(2023, 4, 28, 5, 15, 2, 960, DateTimeKind.Utc).AddTicks(6494), "komron2052@gmail.com", "Komron", "Rahmonov", "$2a$11$kvJwfKwNzBy/LZBPD9NtC.wnleNru65C1a7jc6Jsp.Vp5TYaLkQYm", "+998 991234999", 4, null },
                    { 8L, new DateTime(2023, 4, 28, 5, 15, 3, 102, DateTimeKind.Utc).AddTicks(4372), "nozimjon@gmail.com", "Nozimjon", "Usmonaliyev", "$2a$11$H.cfml/R3F1WX31K1A3n0uDYZ9ZsvoD1qWcY4/NaGDiva/AryDrDW", "+998 991235999", 3, null },
                    { 9L, new DateTime(2023, 4, 28, 5, 15, 3, 244, DateTimeKind.Utc).AddTicks(3156), "aljavhar@gmail.com", "AlJavhar", "Boyaliyev", "$2a$11$FjOO23gw.ObrkJZv8z72oenV/OZoNGTt5DeErG9td5SL35klhBPDC", "+998 902344545", 0, null },
                    { 10L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(311), "muhammad@gmail.com", "Muhammad", "Rahimboyev", "$2a$11$1U14.ph3iNpAB1TRmHvhqO/nitYLazLq9wjbp0TKBgPAwalLithG.", "+998 937770202", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Email", "Name", "Phone", "UpdatedAt", "Website" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1069), "RocketLogisticts@gmail.com", "Rocket Logistics", "4444", null, "rLogistics.com" },
                    { 2L, 2L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1071), "giant.delivery@gmail.com", "Giant Delivery", "777 9 777", null, "giantdelivery.com" },
                    { 3L, 4L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1073), "ameerLogistics@gmail.com", "Ameer Logistics", "2020", null, "ameerlogistics.com" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedAt", "Status", "UpdatedAt", "UserId", "UserId1" },
                values: new object[] { 1L, 2L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1234), 0, null, 1L, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Name", "Price", "Serial", "UpdatedAt", "Weight" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1161), "HP-Victus", 630m, "a1B5", null, 2.2m },
                    { 2L, 1L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1164), "MacBook-Pro", 2000m, "AKJ-12445", null, 1.2m },
                    { 3L, 5L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1166), "Iphone-14", 1500m, "KLKJL-324342", null, 0.1m },
                    { 4L, 6L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1169), "Spintronics", 100m, "MMMLW-11234", null, 4.2m },
                    { 5L, 4L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1173), "Trimol", 1m, "MML-32423", null, 0.002m },
                    { 6L, 2L, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1175), "SmartWatch", 50m, "JJJO-23423", null, 0.1m }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "Amount", "CreatedAt", "LocationId", "MerchantId", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1000, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 1L, 1L, 6L, null },
                    { 2L, 50, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 1L, 1L, 1L, null },
                    { 3L, 100, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 2L, 2L, 3L, null },
                    { 4L, 100000, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3L, 3L, 5L, null },
                    { 5L, 100, new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3L, 3L, 2L, null }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Amount", "CreatedAt", "InventoryId", "OrderId", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1L, 1, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1254), 3L, 1L, 3L, null },
                    { 2L, 4, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1256), 1L, 1L, 6L, null },
                    { 3L, 2, new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1258), 5L, 1L, 2L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_LocationId",
                table: "Inventories",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MerchantId",
                table: "Inventories",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchants_AddressId",
                table: "Merchants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_InventoryId",
                table: "OrderItems",
                column: "InventoryId");

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
                name: "IX_Orders_UserId1",
                table: "Orders",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
