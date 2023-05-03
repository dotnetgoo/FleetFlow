using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
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
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "PaymentStatus" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7164), 0 });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 42, 328, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 42, 627, DateTimeKind.Utc).AddTicks(6338), "$2a$11$NNFZCBhBHBQKvT6DZMtnuu/S9H1a3Ib4GFQjE/yMhOoruhZHVEHrq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 42, 869, DateTimeKind.Utc).AddTicks(5678), "$2a$11$ys/0tAE41M.lR.6wUWUq5ODZtQntDj/QXgGCg4OdeIQ7idP0/4ZAK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 43, 108, DateTimeKind.Utc).AddTicks(8401), "$2a$11$ry8jjWAcZYVJoA.r3C79NO.zk7tu6WEPxXEefuMvtmc5Nj3qJOaL6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 43, 415, DateTimeKind.Utc).AddTicks(863), "$2a$11$OKZxMHGffy0C2pVhJHc7.eXfEotTSeHhPWOC17MdJUFlHLWIo9DTq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 43, 679, DateTimeKind.Utc).AddTicks(9385), "$2a$11$AhQVdECFOh5AD3wTJPXPseoNCML/N8L1wvsyJnSn2PyPM1V.obZ7C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 44, 3, DateTimeKind.Utc).AddTicks(3333), "$2a$11$h17aRt/4Uj5xe2PXJG.ToOy7UlI1v8SmyQ8RgvICzKslwsauvYLF6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 44, 229, DateTimeKind.Utc).AddTicks(7788), "$2a$11$5TeFWJpl3vIwE0mFRFvNauP15gPmdsUfIDd9ze1X7Mm43Bf58Dy26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 44, 599, DateTimeKind.Utc).AddTicks(6346), "$2a$11$A403fugTgSUjgkwryniTxu9jgpt62dq8XG/jVzgURkw4lCiLg6tc2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 44, 862, DateTimeKind.Utc).AddTicks(4572), "$2a$11$MZXb7aYCNMMpHpsjkMv1N.8VjH1ZtUCsc.k5ILcUR2HBNmj73AoN." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 2, 11, 26, 45, 113, DateTimeKind.Utc).AddTicks(6371), "$2a$11$T/VrWsLxW258ttFHwmYrBOBvK54WaQRFge7BDfhL9zTiQK5d.TyHq" });

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
