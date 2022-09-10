using Microsoft.EntityFrameworkCore.Migrations;

namespace Park_Lookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Washington state", "Bridle Trails State Park", "State park" },
                    { 2, "Washington state", "Lake Sammamish State Park", "State park" },
                    { 3, "Washington state", "Saint Edward State Park", "State park" },
                    { 4, "Washington state", "Bear Creek Park", "State park" },
                    { 5, "Washington state", "Olympic National Park", "National park" },
                    { 6, "Washington state", "Mount Rainier National Park", "National park" },
                    { 7, "Washington state", "North Cascades National Park", "National park" },
                    { 8, "Oregon state", "Crater Lake National Park", "National park" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 8);
        }
    }
}
