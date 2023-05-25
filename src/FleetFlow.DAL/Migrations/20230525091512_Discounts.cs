using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Discounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DiscountId",
                table: "Products",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Feedbacks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Feedbacks");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 24, 601, DateTimeKind.Utc).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 24, 818, DateTimeKind.Utc).AddTicks(754), "$2a$11$5kLLPOZTp3U3Drg/Gtx40OAUzj3Cjn3WvVQS8n0eEh7/VwpnwKLiW" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 25, 37, DateTimeKind.Utc).AddTicks(651), "$2a$11$ppyKTkwJcjA4Ph5rxt48F.7iRw/EmlLl56/YEDC0I2TjBIrLYjIGy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 25, 250, DateTimeKind.Utc).AddTicks(5039), "$2a$11$7/Z2vR4/HBzQXKBVVZTUf.ga.B8p5bp5fvcOVtQ9rR6Np36yAHapO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 25, 480, DateTimeKind.Utc).AddTicks(5551), "$2a$11$n.WwXujl8NzGyVbmmjT8C.jw1QGC/XDIfGUuwTzCL06OUZgDX8Eny" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 25, 696, DateTimeKind.Utc).AddTicks(3557), "$2a$11$dPi42HI6FgIVLamWFLbAv.xtcqXawYvXfM07T97qFi3UjU.DgC9M6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 25, 932, DateTimeKind.Utc).AddTicks(4815), "$2a$11$GExVxNZYmEHFviqJnLVGRuzR4q3WGb0j0XviEIxEbQuKX9Tq9Yj8C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 26, 150, DateTimeKind.Utc).AddTicks(3447), "$2a$11$GamzvpkO3TYpvYnEgqscP.KtqqB0OWzCSEp2.r.3/tozfAqBTXfui" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 26, 381, DateTimeKind.Utc).AddTicks(5029), "$2a$11$s6G7rCkOnvp8pdUt/8dug.0fahrMlFfptZb6j.6KJCGT755EX3keS" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 26, 602, DateTimeKind.Utc).AddTicks(1663), "$2a$11$SRKobWWfa.oAylpnRNc7SufYXIvJARCM5yLf3nH9G93sypBx.J1tK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 6, 0, 26, 841, DateTimeKind.Utc).AddTicks(4449), "$2a$11$fPQb58uN/quk2eYqpeTSIuylP97xQGjtB4Zcn52i57zCcKeZBzev6" });
        }
    }
}
