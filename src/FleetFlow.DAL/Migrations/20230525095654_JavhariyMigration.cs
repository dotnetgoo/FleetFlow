using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class JavhariyMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 118, DateTimeKind.Utc).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 118, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 118, DateTimeKind.Utc).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 118, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 118, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 118, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 117, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 117, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 117, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 117, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 117, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 30, 117, DateTimeKind.Utc).AddTicks(9379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 30, 273, DateTimeKind.Utc).AddTicks(6575), "$2a$11$Wgt7Vz78bUvWGqTU4IMbTOWvWxXEBdsR1Gx/gOxFpidusUUwk7qym" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 30, 433, DateTimeKind.Utc).AddTicks(2282), "$2a$11$oRPS8y1au9zBVn2nQj0j6.B9l1eaZD1scvW3mQ3.f4fw0fVy.A7AK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 30, 587, DateTimeKind.Utc).AddTicks(2340), "$2a$11$JH0ET4JFeo2gpgOdBGYg2.EhdiLGfoVtrpNabhKcKOa.1x0x5JRUe" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 30, 737, DateTimeKind.Utc).AddTicks(4974), "$2a$11$4CBowZ8Ta9uy0MSneUCzbOXm1BIqH3KnbIn7dCbIuk2GnTCjzwDEq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 30, 894, DateTimeKind.Utc).AddTicks(753), "$2a$11$Ot3uO7eWhmLd3RcR5LQ0luV1AP/YbwANyvR/HYHntRv8vXFxtgU0i" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 31, 52, DateTimeKind.Utc).AddTicks(4906), "$2a$11$MIAjpv4hdW0DioG6mIJBUeZT84qcL87snb3MWr1nc8OZc824qbkmK" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 31, 201, DateTimeKind.Utc).AddTicks(5977), "$2a$11$QhuQtdfNhc0UxzMWitQiLeROnILADtj2E/6ARhOYIXOgVvy2YZMu6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 31, 365, DateTimeKind.Utc).AddTicks(4930), "$2a$11$OMCO90R.jOu15Z0w3A1NYOYxGVJNnmz96sejvjQBizFl17OjeXyn2" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 31, 521, DateTimeKind.Utc).AddTicks(1721), "$2a$11$dCj0fw0bhi8gVnKEJ0I5AuPZjaRa1xezpdDUj6tAp7uiqbVvCPwJq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedAt", "Password" },
                values: new object[] { new DateTime(2023, 5, 25, 9, 45, 31, 674, DateTimeKind.Utc).AddTicks(5836), "$2a$11$kKsQTrCHA8G33PNHMpyqI.ySsJpNQbzs87Dygg7lKQIZGwUXXLCSS" });
        }
    }
}
