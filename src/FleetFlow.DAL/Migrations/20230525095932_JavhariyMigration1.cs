using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class JavhariyMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 30, 897, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 57, DateTimeKind.Utc).AddTicks(8808), "$2a$11$CAcXtRNH3Og50iPC3l01PeWQUuupouCZ60zvO4UyVDwFCeecw5h2S" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 211, DateTimeKind.Utc).AddTicks(5522), "$2a$11$/2nXxJFIAOhwDAf0q3H14.ycNfOjMvvuY7lVY7ZdxCSXWOQhhjShu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 373, DateTimeKind.Utc).AddTicks(257), "$2a$11$rK8Yduo.GG2rP2u2KQDPk.ReMybj85jItpiKKOca2zzWgC6xQbG8G" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 528, DateTimeKind.Utc).AddTicks(4436), "$2a$11$nkclhYaKkWS0Bw3xzDo/CekDm6ygZ4slwykdF92b2yf7aGdMXDtpa" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 684, DateTimeKind.Utc).AddTicks(8180), "$2a$11$aUr.tEsxhRgBr5M/C1sUq.7Aikl2by76Dl2c1C9xT8HUTVluvdYsK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 831, DateTimeKind.Utc).AddTicks(7950), "$2a$11$nuM0m84eLUKsyaQwUsyqHOipH9GSQVjkAtNyEAK/dNH.KOGFLYhpq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 31, 983, DateTimeKind.Utc).AddTicks(4967), "$2a$11$Sd9aLQOGSwhc1ebgVu7E4ey6mCuJyz3s.4cj1z3o/w5VrEJ8tiLq." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 32, 130, DateTimeKind.Utc).AddTicks(674), "$2a$11$CuN/N8BrmA8N00fSmhDy.eslJGZriz.ozEmiNHcCvFPMYrORYC3Bq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 32, 278, DateTimeKind.Utc).AddTicks(3585), "$2a$11$ydpNIn6KYPu2Wz33rGQt7.yvsCasIRkODBxY2XswOOSHSx1y3bpbq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 59, 32, 429, DateTimeKind.Utc).AddTicks(4490), "$2a$11$rLapytjBdX61f7rJyCayPu/A80uuNb5b.ieh/Selnp9URXrkEPk1O" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 52, 402, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 52, 553, DateTimeKind.Utc).AddTicks(1132), "$2a$11$YmmohWTLlL4Y0EMkJGtFMuHR1./ljElPPKBHpOc.6MFDk38k6uR8." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 52, 710, DateTimeKind.Utc).AddTicks(3283), "$2a$11$iP/WLD3rnTlofTKIaXmB.ukTYLQwSFv.PueRUUGP1hylvZkufOt4C" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 52, 872, DateTimeKind.Utc).AddTicks(2696), "$2a$11$nzlK5LWhuvwj2ODesLFMnO/disXnD6U075VMKJSOt2i5rd6eNJXhC" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 24, DateTimeKind.Utc).AddTicks(1052), "$2a$11$84mncbTPYiBW/4ERJBW0zOG13/ZI6CeQY/dckZB2aspDZKrnRydwm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 176, DateTimeKind.Utc).AddTicks(7454), "$2a$11$dq.9hJ.EXHxBFUhQUROGiOzPy3pDHMPI45aTGP8Bg8xJ/oWtYc3Qm" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 337, DateTimeKind.Utc).AddTicks(5062), "$2a$11$ZA0wLB8XDKCGPSwjNeTk6eOgZ8ieMm316AGxxix10rAslzN4U4uAe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 489, DateTimeKind.Utc).AddTicks(876), "$2a$11$33TfCrUK5Ww6g1RpozKvpe.YLAkgigh1Ka1H3ZJCJFDrY3bH.M3tG" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 645, DateTimeKind.Utc).AddTicks(5707), "$2a$11$DNO.h.e1qbfoLwNczRjTq.GInctXjoSWdhjocgTTuF1yVc/V/0kvO" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 800, DateTimeKind.Utc).AddTicks(3866), "$2a$11$WDeJgi/hFlw23NZ6Ahh8ue8B/ILTsvPPc12RJCT13YbBdp5TXUIKi" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 56, 53, 948, DateTimeKind.Utc).AddTicks(441), "$2a$11$HN7eQIoc7GFcNsSI9AmhvOOPTioAUFRdb7qLW/K6PUZdrtmjpmFBu" });
        }
    }
}
