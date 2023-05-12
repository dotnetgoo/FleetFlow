using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ShoirMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 18, 520, DateTimeKind.Utc).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 18, 656, DateTimeKind.Utc).AddTicks(4612), "$2a$11$VSHkoRKmMAeoZt3b1DlY6O7mfojHHVpy5grgGc9FLaGzQnWyHbJju" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 18, 793, DateTimeKind.Utc).AddTicks(5389), "$2a$11$SB1U2Ha5dkXvLG8lUmTJYusRueaVhV9v4P9vMnfY5r2CTeqr1vKE6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 18, 922, DateTimeKind.Utc).AddTicks(7667), "$2a$11$cRUQjZ4kPgiAQDRsrpxQ6O4v1x1AR2wm2PunalwlXm0kiEqtLwctC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 51, DateTimeKind.Utc).AddTicks(8134), "$2a$11$2wN1Iz2pBZ5C5h9dGc2CmeBJBkJci0yahzeUlxMoOl3VHgfbx62de" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 180, DateTimeKind.Utc).AddTicks(5105), "$2a$11$0pvhTEwtyKC3J/yz10eE/ODfdBe6WAKIKyRKXl0hKo.JAFt3GVmmO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 310, DateTimeKind.Utc).AddTicks(1297), "$2a$11$lVEtqlQ7xNaFDqXvyvKd1OIXlVPD8A5qEsQ.PbqED9bOSwtiNuZra" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 438, DateTimeKind.Utc).AddTicks(3466), "$2a$11$q.6CeOechahjgxsvGnWwwOY5hAtNafqkpacOQHF/Ccs6gtkvQPkOW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 568, DateTimeKind.Utc).AddTicks(3882), "$2a$11$DkZPWtckjMlzZF9w6hRHHejPU4lyW9VyE0Tcjdfps1TrPM1.uVtqi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 700, DateTimeKind.Utc).AddTicks(1829), "$2a$11$0.k/1APdi3WlDwn.TmhGmeLD2jXHJRsCFF.dJMI7.lMR2KEUChh3W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 11, 4, 50, 19, 829, DateTimeKind.Utc).AddTicks(5511), "$2a$11$YYbuNlap2VsmvWkuiSFdl.AueGKs.34mcrLvawL15fhpAnFMExIcq" });
        }
    }
}
