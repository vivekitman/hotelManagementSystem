using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName", "ShortName" },
                values: new object[] { 1, null, "Jordon", "JOR" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName", "ShortName" },
                values: new object[] { 2, null, "Kuwait", "KUW" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CountryCode", "CountryName", "ShortName" },
                values: new object[] { 3, null, "Bahrain", "BAH" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "City", "CountryId", "HotelName", "Rating", "Region" },
                values: new object[] { 1, "Amman", null, 1, "Kempinski", 5.0, null });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "City", "CountryId", "HotelName", "Rating", "Region" },
                values: new object[] { 2, "Kuwait City", null, 2, "Jumeirah", 4.5, null });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Address", "City", "CountryId", "HotelName", "Rating", "Region" },
                values: new object[] { 3, "Manama", null, 3, "Gulf Hotel", 4.0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
