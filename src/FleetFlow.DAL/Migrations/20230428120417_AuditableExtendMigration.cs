using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuditableExtendMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Users",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Users",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Products",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "ProductCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ProductCategories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "ProductCategories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Orders",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Orders",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "OrderItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "OrderItems",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "OrderItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Merchants",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Merchants",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Merchants",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Locations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Locations",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Locations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Inventories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Inventories",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Inventories",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "DeletedBy",
                table: "Addresses",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Addresses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "UpdatedBy",
                table: "Addresses",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5198), null, false, null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5202), null, false, null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5204), null, false, null });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5206), null, false, null });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8187), null, false, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8189), null, false, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8191), null, false, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8192), null, false, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8194), null, false, null });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8195), null, false, null });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5232), null, false, null });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5234), null, false, null });

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5236), null, false, null });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5508), null, false, null });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5510), null, false, null });

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5512), null, false, null });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5485), null, false, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8052), null, false, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8054), null, false, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8056), null, false, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8057), null, false, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8060), null, false, null });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 384, DateTimeKind.Utc).AddTicks(8061), null, false, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5337), null, false, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5340), null, false, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5342), null, false, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5344), null, false, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5347), null, false, null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(5350), null, false, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 541, DateTimeKind.Utc).AddTicks(1046), null, false, "$2a$11$BJS80olKrNwdqHsADXq9VueLSha2RdHMDmhl1tAanIg5U0JchXdza", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 692, DateTimeKind.Utc).AddTicks(4920), null, false, "$2a$11$k.BUUCWPcqimpca9f0OMF.HUNoIEzpI76FnOdMu/7x19IAXezQQOu", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 842, DateTimeKind.Utc).AddTicks(5938), null, false, "$2a$11$JoTK2bqQvNdOj5kmaJoTsuTpGgtbj3VkO.NdI6VHvfFhKdpmhNe4a", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 15, 990, DateTimeKind.Utc).AddTicks(3177), null, false, "$2a$11$nVcKs4WVHwTzZ0VQU7DVQeY2VJyW.VGxSzO5crEK8g9ZQ66m1fFWK", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 141, DateTimeKind.Utc).AddTicks(1871), null, false, "$2a$11$7XcUUSKLO9HWFz5XVcWTVORu6XLwrN3TFnzaXNCXbSqbnEQIHi9P.", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 290, DateTimeKind.Utc).AddTicks(1148), null, false, "$2a$11$H0UB5Dg7Cy3HEnOnaqouTOdQ7C2piSbv62atT/bhsN6.kJ0oC.Cma", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 444, DateTimeKind.Utc).AddTicks(5139), null, false, "$2a$11$JRiCzZpBScMcFAQsiuCV5.VNWgR24tCqpYoNi3ZFTyxCXG6GF.wVS", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 603, DateTimeKind.Utc).AddTicks(4548), null, false, "$2a$11$VavZHHurT76YpbbwgR2ElO5VpxxIvr8SxIzR/0m.lmRUzNrs8LHBG", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 753, DateTimeKind.Utc).AddTicks(2946), null, false, "$2a$11$iWJDE8YzgR7Ctea12ApUcO5Ug9B8c/jLOyIx4J3/HtOkIHurY7lcq", null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "DeletedBy", "IsDeleted", "Password", "UpdatedBy" },
                values: new object[] { new DateTime(2023, 4, 28, 12, 4, 16, 906, DateTimeKind.Utc).AddTicks(4706), null, false, "$2a$11$oQlTPpfM.ZdwmAcOLdEpYumoruH2P2mZxXFYL8HKNvd/SDQMJzUUC", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "ProductCategories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Merchants");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Addresses");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Merchants",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 1, 968, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 110, DateTimeKind.Utc).AddTicks(6970), "$2a$11$ttOx9ksYwwWX9BLwCS.sMuxm.XkxDfwJPG0XJWIEhNTdgOww1trBu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 252, DateTimeKind.Utc).AddTicks(2018), "$2a$11$G4OCuDzeANhaPSvL/9UAQODDQNglFUtYEuPYzrLVvZL1PNJTago7C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 394, DateTimeKind.Utc).AddTicks(115), "$2a$11$CqaRF/0B44.RDR.dZ3uLVuG4s7r4z.3vO0B0k4hGp2.b6oUWpBn5i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 534, DateTimeKind.Utc).AddTicks(5557), "$2a$11$JiMBT6vhTdJC/8cYfQrfDe.JG6I52VKyF2DV1qGXAMBpuRPCCpiTq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 676, DateTimeKind.Utc).AddTicks(4669), "$2a$11$hdNy4mGNchO9Nx28tCiQNeg0iR7ITcNEFDxMStBCRxTGNixBIDArW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 817, DateTimeKind.Utc).AddTicks(3593), "$2a$11$q9s9mz7B2nYsxKCGKnNzOeMnf0WANSitKheuh4Wv0acn5j2pD7kee" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 2, 960, DateTimeKind.Utc).AddTicks(6494), "$2a$11$kvJwfKwNzBy/LZBPD9NtC.wnleNru65C1a7jc6Jsp.Vp5TYaLkQYm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 3, 102, DateTimeKind.Utc).AddTicks(4372), "$2a$11$H.cfml/R3F1WX31K1A3n0uDYZ9ZsvoD1qWcY4/NaGDiva/AryDrDW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 3, 244, DateTimeKind.Utc).AddTicks(3156), "$2a$11$FjOO23gw.ObrkJZv8z72oenV/OZoNGTt5DeErG9td5SL35klhBPDC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 4, 28, 5, 15, 3, 387, DateTimeKind.Utc).AddTicks(311), "$2a$11$1U14.ph3iNpAB1TRmHvhqO/nitYLazLq9wjbp0TKBgPAwalLithG." });
        }
    }
}
