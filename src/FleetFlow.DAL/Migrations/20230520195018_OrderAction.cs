using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class OrderAction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 16, 993, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 132, DateTimeKind.Utc).AddTicks(3456), "$2a$11$UtqH.wqxYtKKbTAgV/3EtueOAl..hPRwVcY9W6uHqVUALWBbyC/1O" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 274, DateTimeKind.Utc).AddTicks(7374), "$2a$11$bbH8Jwi5TYCbL4H9lyiTTuMTxxJuh0JnCtKakGhGrMuPQAG7CkWBa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 414, DateTimeKind.Utc).AddTicks(9346), "$2a$11$kcMOjfBwgfi/inMDVhwzwuCrRZzFzvAUJOD5KsU9doon6f9F9/9nS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 556, DateTimeKind.Utc).AddTicks(8130), "$2a$11$m7MxCrLYP2LYUAb2wDZlIeqzjHPuUGq4sMAuXYrcYhyjlFIlI2AWi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 696, DateTimeKind.Utc).AddTicks(5360), "$2a$11$Hb54qZ2c9BXlJhb9.erDMeafL0BCAzHlP9CtjlxjDMLbDrbDwFv3S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 839, DateTimeKind.Utc).AddTicks(4174), "$2a$11$a/Ntv5e3wDOImBQZDnOas.Px.ScNXsgme3tCoFqC1yuNd47zRpJEW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 17, 978, DateTimeKind.Utc).AddTicks(6920), "$2a$11$yaGbIGbjd0Lg3FxJmuv9W.yYp8wU/rCsR9B/Omv2x2MF../y1e1g." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 18, 121, DateTimeKind.Utc).AddTicks(2050), "$2a$11$7N6w6AQO9RN1YhDb9XEeoeKB9KEucA511apQovI.dt4qk556IpPES" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 18, 260, DateTimeKind.Utc).AddTicks(3441), "$2a$11$me0s0ME5vX.zU4MdxQ5KI.oe8Z.j5BY90/DuifpIzhF31oJQDV7HG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 20, 19, 50, 18, 405, DateTimeKind.Utc).AddTicks(6448), "$2a$11$Dw64c4fvFxbxkEYDPlU.9.hBefrHf6r0VtCUjGKgblxCDVtwtoPRa" });

            migrationBuilder.CreateIndex(
                name: "IX_OrderActions_OrderId",
                table: "OrderActions",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderActions");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 34, 885, DateTimeKind.Utc).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 35, 69, DateTimeKind.Utc).AddTicks(4460), "$2a$11$5lu/H0t7tr8qq68BiB8w6OpBE0ja/eVJUT3I7dmsU8WvL07pawrZ2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 35, 253, DateTimeKind.Utc).AddTicks(5710), "$2a$11$ynojTLGQSLS9jx8EBYiSQeK8AoWN2bhHchqy56q46hUjQxKy6S7yy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 35, 436, DateTimeKind.Utc).AddTicks(8660), "$2a$11$/DxXXjO/Gc7.QV0R8lpF0uU2Qza39VgoUOOPDL13hUVftlsxgkPKy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 35, 620, DateTimeKind.Utc).AddTicks(3270), "$2a$11$Y/vdm1dWjgFFGw9JWzuy6e8mOfYwy2SK6NV0PyvG9zvO7mkbMVSdW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 35, 804, DateTimeKind.Utc).AddTicks(690), "$2a$11$qgz4Ty599y56n/zVa9SVtedZdFstZ5mopyq07R1UQL3EMk8KmHkfW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 35, 987, DateTimeKind.Utc).AddTicks(3010), "$2a$11$xkb/UjFTRGKLyOWSNxb.JO7U61k.0oiGX1vGuGBVasxungWesXEme" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 36, 170, DateTimeKind.Utc).AddTicks(8910), "$2a$11$tBst/WC3FQEAS/Lk4UNZKeYeeEJYxdNrWMrLR/8W0MTD0H0oeu.nO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 36, 353, DateTimeKind.Utc).AddTicks(9700), "$2a$11$amI7JOEqsNVw80nbWOtopePna.P0xqqsLHnhpjr4xOi8lL8worDMa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 36, 536, DateTimeKind.Utc).AddTicks(7660), "$2a$11$tZM9AgVy.fX2B7m0O8c7tewxeGguTNXtjaZiyQsUxrjkRWxSn4uyO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 17, 14, 12, 36, 720, DateTimeKind.Utc).AddTicks(4410), "$2a$11$iTN4v9Oi1TPNuXWkN6MBKeAeLNDlpHepknk8t/q3OujKfLf5o/ZG." });
        }
    }
}
