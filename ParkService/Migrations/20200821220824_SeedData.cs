using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkService.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Crater Lake", "Oregon" },
                    { 25, "Yellowstone", "Wyoming" },
                    { 24, "Wind Cave", "South Dakota" },
                    { 23, "White Sands", "New Mexico" },
                    { 22, "Voyageurs", "Minnesota" },
                    { 21, "Theodore Roosevelt Park", "North Dakota" },
                    { 20, "Pinnacles", "California" },
                    { 19, "Petrified Forest", "Arizona" },
                    { 18, "Mount Rainier", "Washington" },
                    { 17, "Mesa Verde", "Colorado" },
                    { 16, "Mammoth Cave", "Kentucky" },
                    { 15, "Kobuk Valley", "Alaska" },
                    { 26, "Yosemite", "California" },
                    { 14, "Joshua Tree", "California" },
                    { 12, "Volcano Park", "Hawaii" },
                    { 11, "Great Smoky Mountains", "North Carolina" },
                    { 10, "Great Basin", "Nevada" },
                    { 9, "Grand Teton", "Arizona" },
                    { 8, "Glacier Park", "Montana" },
                    { 7, "Gateway Arch", "Missouri" },
                    { 6, "Everglade", "Florida" },
                    { 5, "Death Valley", "California" },
                    { 4, "Big Bend", "Texas" },
                    { 3, "Long Beach", "Washington" },
                    { 2, "Yoakam Point", "Oregon" },
                    { 13, "Isla Royale", "Michigan" },
                    { 27, "Zion", "Utah" }
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

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 27);
        }
    }
}
