using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetFlow.DAL.Migrations
{
    /// <inheritdoc />
    public partial class JavharMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Feedbacks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
