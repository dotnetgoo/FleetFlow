using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NullableAddressIdInOrderMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "Orders",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "AddressId",
                table: "Orders",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 49, 976, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9680));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 124, DateTimeKind.Utc).AddTicks(1670), "$2a$11$KcShO36Y96icQjlq99zEAewTrcWmbAVvTlYXH1eQnh2jo8MDaY4Di" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 272, DateTimeKind.Utc).AddTicks(7450), "$2a$11$.VxFX2nVzOjIkjADRXt/TObglHP/7TTWgyntHdrbMxv79fOUKhk26" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 421, DateTimeKind.Utc).AddTicks(7360), "$2a$11$llPR79jTFOfbmZ5.7ma/BePXhnPoNdNPhOH9oSIhfyVtcgqIzh7TS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 565, DateTimeKind.Utc).AddTicks(9580), "$2a$11$4USA3X530n8OAM0cy/o40OYrDzFhMkXgZSCXfairieQffLARvp0rC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 710, DateTimeKind.Utc).AddTicks(6940), "$2a$11$Z1EhO6F26Ei0wbXGxSNhc.KHBx2WXK8x8xJaGgutW1BC9o7QpUWuO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 852, DateTimeKind.Utc).AddTicks(2120), "$2a$11$X00MSKzeRgB9R6KfdjK2vukJDZpgYNrdv1LJvqwozyXNFoF9WB9H." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 50, 997, DateTimeKind.Utc).AddTicks(2710), "$2a$11$j7ezZ93/YGbuGzz9/c2j3.h4VKJHOIYmqEiRfHW3EQvxD1OeKc2n." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 51, 141, DateTimeKind.Utc).AddTicks(5890), "$2a$11$Av95YUJRZQwVsfbnauf1C.WPKyNmd5qHJTykrT7YEskURAbozMlrm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 51, 283, DateTimeKind.Utc).AddTicks(640), "$2a$11$i4Q/2jss23qI.GoU4qkl1O5sJIh0vJkBwxoKIrvCXIU8BOVG2u5ua" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 11, 52, 51, 423, DateTimeKind.Utc).AddTicks(9040), "$2a$11$V/Zr0.y2TcCI2ftAPKSZ1.biZDO4A.wAHLBQR8OmQuC22VrnKW9Mq" });
        }
    }
}
