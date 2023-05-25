using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class DiscountsOneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discounts_ProductId",
                table: "Discounts");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 42, 589, DateTimeKind.Utc).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 42, 728, DateTimeKind.Utc).AddTicks(9000), "$2a$11$j.bhnF.WVh1eMTQklgjVhuXFHb/cLjmyv6sMvxZCJ4N.EqX49jVzO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 42, 869, DateTimeKind.Utc).AddTicks(5286), "$2a$11$4BjZs5rKPMCFut51K8EQ7eipFr8/RR/jGoBF0sGpBlukrqfYkQxmi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 8, DateTimeKind.Utc).AddTicks(5826), "$2a$11$g1YdSmpGLXLZRnTXjNmc0OYNTTLLjRoGcNrzkhQuvOa3D/NyaiYya" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 150, DateTimeKind.Utc).AddTicks(1224), "$2a$11$PbCk6UAesaUp2qbRcjc/L.mnAXSwpmBZE7eG.SfVXlNg8mOJyZ05K" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 296, DateTimeKind.Utc).AddTicks(689), "$2a$11$WBY0rt7j6m9KD3/4a3xCUeaHSD/AbYANhP12M1dejRscBEMewVwSG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 437, DateTimeKind.Utc).AddTicks(9933), "$2a$11$rIqWQ8nNYtBO6Ku72tFYzOWoqIKvqJSAF8E/MMTXtCBcxRbHPlXm6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 579, DateTimeKind.Utc).AddTicks(9672), "$2a$11$RW9jxivZ/k2CGFHggOcAdens0lDqI2kifHQkIofmfr8YkkHq43x8q" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 719, DateTimeKind.Utc).AddTicks(5458), "$2a$11$COAJfXmqSWhVj1gUmwVjMOw0KKibWUqKzHaOIVfn9WgsFhlP/aEQO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 43, 860, DateTimeKind.Utc).AddTicks(1136), "$2a$11$eVEYk/wmOj04qtOD8Sfx0uc.osNBGBwUP2e9quamUku7Fumpvl70C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 52, 44, 0, DateTimeKind.Utc).AddTicks(4508), "$2a$11$ohqLY7V0ZyvrIqEF2Z6gLur/exM6GvMCh2JtJf46MTIZereKhz0Tu" });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ProductId",
                table: "Discounts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Discounts_ProductId",
                table: "Discounts");

            migrationBuilder.AddColumn<long>(
                name: "DiscountId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 990, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 990, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 990, DateTimeKind.Utc).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 990, DateTimeKind.Utc).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 15, 10, 572, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "DiscountId" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(19), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "DiscountId" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(22), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "DiscountId" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(24), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "DiscountId" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(26), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "DiscountId" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(32), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "DiscountId" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 991, DateTimeKind.Utc).AddTicks(34), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 10, 713, DateTimeKind.Utc).AddTicks(5955), "$2a$11$0oAviWJXYMGc3QFJPKyEueTW0YozNevw8IliowUjnuJxGlE5JryLK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 10, 856, DateTimeKind.Utc).AddTicks(9885), "$2a$11$OhoXo.aJ00jiozP8fng9ee1e7RAO2DdF95BvcYCBvLQfOBPnRKE8." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 10, 999, DateTimeKind.Utc).AddTicks(6034), "$2a$11$EuyXaqaT5b/8xo.hNWgEk.hcA4suREJNtqoyZ9qSdpu/61Jy16cl6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 140, DateTimeKind.Utc).AddTicks(3088), "$2a$11$E0lV3vLkFMDIsptN3nLhN.8SHsZ4mpwaHw/W7Dz2J8yqqsX1p3t5W" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 280, DateTimeKind.Utc).AddTicks(1979), "$2a$11$rW3WJPnhCKI.SMSxjVqwZ.b.5jyCTvBC3GJnUgMUDN/.Tq/MFA5wy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 425, DateTimeKind.Utc).AddTicks(3373), "$2a$11$amK/9r9SZZfPcAl.2IgjOuxtXocuSh85dHWAC5a/dEuFGH.uyvESW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 569, DateTimeKind.Utc).AddTicks(1915), "$2a$11$5y11Qw8m8lF9IqEtVBDJAOGGsChMwqGABwQkmB7jbxP5RxZpauwdG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 707, DateTimeKind.Utc).AddTicks(7764), "$2a$11$0ZE3JjZQ5jKJiG0szWMwzeCDCOaGfYXcOKy6v3gIgvfX7Qsi2sutK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 848, DateTimeKind.Utc).AddTicks(6265), "$2a$11$XNRqZoqOlpmN2G/i2C/.DOBZ/SkKicTJzMRUw1QbT8gJB7D3k42fG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 990, DateTimeKind.Utc).AddTicks(8905), "$2a$11$aZmOTYrH3aEJL0TyNsgrYu1W8VKupsQI1.V53HlRcaMJqxC47ivwO" });

            migrationBuilder.CreateIndex(
                name: "IX_Discounts_ProductId",
                table: "Discounts",
                column: "ProductId",
                unique: true);
        }
    }
}
