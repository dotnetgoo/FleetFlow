using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AuthorizeMigaration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "DiscountId",
                table: "Products");

            migrationBuilder.AddColumn<long>(
                name: "RoleId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

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

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "DeletedBy", "IsDeleted", "Name", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2485), null, false, "User", null, null },
                    { 2L, new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2488), null, false, "Admin", null, null },
                    { 3L, new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2490), null, false, "Merchant", null, null },
                    { 4L, new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2492), null, false, "Driver", null, null },
                    { 5L, new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2493), null, false, "Picker", null, null },
                    { 6L, new DateTime(2023, 5, 25, 11, 1, 5, 375, DateTimeKind.Utc).AddTicks(2495), null, false, "Packer", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 5, 513, DateTimeKind.Utc).AddTicks(8010), "$2a$11$bcV/CPv6Nopv62Yj6Nx.NOIO/KZYrygvuPZioXKkFGqUKAcyFppV2", 2L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 5, 656, DateTimeKind.Utc).AddTicks(4351), "$2a$11$GyupecFW6Stwq9S2hTmKLu/jCmJmdh3MIhnvou2ITl987TQMrPSlS", 3L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 5, 805, DateTimeKind.Utc).AddTicks(3466), "$2a$11$cdCwCKikpGLJEpeGpUztXOrCPTc7wpefI98GoWhyVo7.VkO/0OzjK", 4L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 5, 946, DateTimeKind.Utc).AddTicks(4272), "$2a$11$VeiDqyFrfFalk.8Y1RLj2O.oIK/7MvI1Y5U.MnJqDbX4aMPZH55yu", 5L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 6, 89, DateTimeKind.Utc).AddTicks(2152), "$2a$11$L7h6BY4zrSzbK6LBtCaeH.kh8GGH0175GwJqMlxdsfCtlUIBSiN5C", 6L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 6, 231, DateTimeKind.Utc).AddTicks(1697), "$2a$11$hFFssmza0ZI0uBJKQVYjqe9DnIK4FyCeKImXU1BMSGtU7n62uEgcy", 1L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 6, 376, DateTimeKind.Utc).AddTicks(1192), "$2a$11$M1VNVmr295ybALKuKshQ6eqyHL3SBruxhRQmeMjyw2M89GAViJB4K", 2L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 6, 520, DateTimeKind.Utc).AddTicks(9526), "$2a$11$uw0mLbHSI/FZ76AHOFZA8.lDCdPnFNZbVT24/4stDq84GJ/2GUeZm", 3L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 6, 664, DateTimeKind.Utc).AddTicks(5581), "$2a$11$KYG7Knu3Fv/4dKSWUMiNk.eudOLCOwHO3s1.p9TNP2yHQXIKV4Maq", 4L });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password", "RoleId" },
                values: new object[] { new DateTime(2023, 5, 25, 11, 1, 6, 804, DateTimeKind.Utc).AddTicks(7001), "$2a$11$82.RpByzX9CC8rA6hi.IA.IBSzflfehU/j7L3xxCkthCJ3GViEJS6", 5L });

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "Users",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 10, 713, DateTimeKind.Utc).AddTicks(5955), "$2a$11$0oAviWJXYMGc3QFJPKyEueTW0YozNevw8IliowUjnuJxGlE5JryLK", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 10, 856, DateTimeKind.Utc).AddTicks(9885), "$2a$11$OhoXo.aJ00jiozP8fng9ee1e7RAO2DdF95BvcYCBvLQfOBPnRKE8.", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 10, 999, DateTimeKind.Utc).AddTicks(6034), "$2a$11$EuyXaqaT5b/8xo.hNWgEk.hcA4suREJNtqoyZ9qSdpu/61Jy16cl6", 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 140, DateTimeKind.Utc).AddTicks(3088), "$2a$11$E0lV3vLkFMDIsptN3nLhN.8SHsZ4mpwaHw/W7Dz2J8yqqsX1p3t5W", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 280, DateTimeKind.Utc).AddTicks(1979), "$2a$11$rW3WJPnhCKI.SMSxjVqwZ.b.5jyCTvBC3GJnUgMUDN/.Tq/MFA5wy", 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 425, DateTimeKind.Utc).AddTicks(3373), "$2a$11$amK/9r9SZZfPcAl.2IgjOuxtXocuSh85dHWAC5a/dEuFGH.uyvESW", 1 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 569, DateTimeKind.Utc).AddTicks(1915), "$2a$11$5y11Qw8m8lF9IqEtVBDJAOGGsChMwqGABwQkmB7jbxP5RxZpauwdG", 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 707, DateTimeKind.Utc).AddTicks(7764), "$2a$11$0ZE3JjZQ5jKJiG0szWMwzeCDCOaGfYXcOKy6v3gIgvfX7Qsi2sutK", 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 848, DateTimeKind.Utc).AddTicks(6265), "$2a$11$XNRqZoqOlpmN2G/i2C/.DOBZ/SkKicTJzMRUw1QbT8gJB7D3k42fG", 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password", "Role" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 15, 11, 990, DateTimeKind.Utc).AddTicks(8905), "$2a$11$aZmOTYrH3aEJL0TyNsgrYu1W8VKupsQI1.V53HlRcaMJqxC47ivwO", 0 });
        }
    }
}
