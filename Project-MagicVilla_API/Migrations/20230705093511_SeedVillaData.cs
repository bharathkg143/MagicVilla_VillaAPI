using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_MagicVilla_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqrft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5448), "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.", "https://th.bing.com/th?id=OIP.1YM53mG10H_U25iPjop83QHaEo&w=316&h=197&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2", "Royal Villa", 10, 10000.0, 50, new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5457) },
                    { 2, new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5464), "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.", "https://th.bing.com/th?id=OIP.aj48y9KXH2xOZ46X9NvKJQHaEo&w=316&h=197&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2", "Forest Villa", 20, 20000.0, 100, new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5465) },
                    { 3, new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5466), "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.", "https://th.bing.com/th?id=OIP.Vt3kGu4X6WQlmH91GpJpzgHaFH&w=300&h=207&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2", "Beach Villa", 5, 30000.0, 200, new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5467) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
