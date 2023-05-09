using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewInitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Merchants_MerchantId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Inventories_InventoryId",
                table: "OrderItems");

            migrationBuilder.DropTable(
                name: "Merchants");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_InventoryId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_Inventories_MerchantId",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "MerchantId",
                table: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Orders",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1404));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PaymentStatus" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(850), 0 });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 12, 57, 313, DateTimeKind.Utc).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 57, 548, DateTimeKind.Utc).AddTicks(6164), "$2a$11$lYk00t.e2v4aOPb8hrEYE.E5Z7XDuXuIn904d6rVf4Xq8WZjaVWu6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 57, 812, DateTimeKind.Utc).AddTicks(2910), "$2a$11$ZV2belDMq4Ws2OB8zCDXb.gXmuYScLhcHHAzzaVmsUrUqPTn4NN02" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 58, 63, DateTimeKind.Utc).AddTicks(235), "$2a$11$sucjWdxZMKShnXsgxBWnGuuRS1a0yxOpbQoWcQSicnbSQaqAIphh." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 58, 352, DateTimeKind.Utc).AddTicks(7460), "$2a$11$gMWCfyJ/gQbBfw/mAlOVAeHTNSeIUdj/bllMetY8.3qqF14Cr3G3G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 58, 604, DateTimeKind.Utc).AddTicks(2870), "$2a$11$g.8TsGVpSPlAZ7l1Nhg9MeJ1IUKnH5nuV9eOVOu9Mt5HJyA5RjAsu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 58, 976, DateTimeKind.Utc).AddTicks(3051), "$2a$11$B/ZVn8ZFeMSNzPUbNIRxaeU/RUU5Jmd4agnG4dg29G8OK7TA8L5hO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 59, 260, DateTimeKind.Utc).AddTicks(2202), "$2a$11$1qFAqZTjgZ2boyRocrdS8ebUDTY6OsyIJdq1v0NUQKz2Y0/uM6NuS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 59, 502, DateTimeKind.Utc).AddTicks(3867), "$2a$11$4xrd/ptUJTfWsfiGAGEiheQO1fPIcbUKAbkEaiGhytIS4P0Erlcwq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 12, 59, 799, DateTimeKind.Utc).AddTicks(7281), "$2a$11$DMrMExEp6X/r.kRL99zgSuUp5tmcUyLy/cXHVEZ9jOo704w1GJdSa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 4, 9, 13, 0, 104, DateTimeKind.Utc).AddTicks(153), "$2a$11$qT.R9pfv4xYDFZOym..GROmElS1Z.lQB0rsEpTF97CWgRQRuWjM6i" });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Orders");

            migrationBuilder.AddColumn<long>(
                name: "InventoryId",
                table: "OrderItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "MerchantId",
                table: "Inventories",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Merchants",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedBy = table.Column<long>(type: "bigint", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedBy = table.Column<long>(type: "bigint", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true)
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

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "MerchantId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 1L });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "MerchantId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 1L });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "MerchantId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 2L });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "MerchantId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3L });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "MerchantId" },
                values: new object[] { new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Utc), 3L });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.InsertData(
                table: "Merchants",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedBy", "Email", "IsDeleted", "Name", "Phone", "UpdatedAt", "UpdatedBy", "Website" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5232), null, "RocketLogisticts@gmail.com", false, "Rocket Logistics", "4444", null, null, "rLogistics.com" },
                    { 2L, 2L, new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5234), null, "giant.delivery@gmail.com", false, "Giant Delivery", "777 9 777", null, null, "giantdelivery.com" },
                    { 3L, 4L, new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5236), null, "ameerLogistics@gmail.com", false, "Ameer Logistics", "2020", null, null, "ameerlogistics.com" }
                });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "InventoryId" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5508), 3L });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "InventoryId" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5510), 1L });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "InventoryId" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5512), 5L });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 541, DateTimeKind.Utc).AddTicks(1046), "$2a$11$BJS80olKrNwdqHsADXq9VueLSha2RdHMDmhl1tAanIg5U0JchXdza" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 692, DateTimeKind.Utc).AddTicks(4920), "$2a$11$k.BUUCWPcqimpca9f0OMF.HUNoIEzpI76FnOdMu/7x19IAXezQQOu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 842, DateTimeKind.Utc).AddTicks(5938), "$2a$11$JoTK2bqQvNdOj5kmaJoTsuTpGgtbj3VkO.NdI6VHvfFhKdpmhNe4a" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 990, DateTimeKind.Utc).AddTicks(3177), "$2a$11$nVcKs4WVHwTzZ0VQU7DVQeY2VJyW.VGxSzO5crEK8g9ZQ66m1fFWK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 141, DateTimeKind.Utc).AddTicks(1871), "$2a$11$7XcUUSKLO9HWFz5XVcWTVORu6XLwrN3TFnzaXNCXbSqbnEQIHi9P." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 290, DateTimeKind.Utc).AddTicks(1148), "$2a$11$H0UB5Dg7Cy3HEnOnaqouTOdQ7C2piSbv62atT/bhsN6.kJ0oC.Cma" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 444, DateTimeKind.Utc).AddTicks(5139), "$2a$11$JRiCzZpBScMcFAQsiuCV5.VNWgR24tCqpYoNi3ZFTyxCXG6GF.wVS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 603, DateTimeKind.Utc).AddTicks(4548), "$2a$11$VavZHHurT76YpbbwgR2ElO5VpxxIvr8SxIzR/0m.lmRUzNrs8LHBG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 753, DateTimeKind.Utc).AddTicks(2946), "$2a$11$iWJDE8YzgR7Ctea12ApUcO5Ug9B8c/jLOyIx4J3/HtOkIHurY7lcq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(4706), "$2a$11$oQlTPpfM.ZdwmAcOLdEpYumoruH2P2mZxXFYL8HKNvd/SDQMJzUUC" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_InventoryId",
                table: "OrderItems",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_MerchantId",
                table: "Inventories",
                column: "MerchantId");

            migrationBuilder.CreateIndex(
                name: "IX_Merchants_AddressId",
                table: "Merchants",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Merchants_MerchantId",
                table: "Inventories",
                column: "MerchantId",
                principalTable: "Merchants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventories_Products_ProductId",
                table: "Inventories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Inventories_InventoryId",
                table: "OrderItems",
                column: "InventoryId",
                principalTable: "Inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
