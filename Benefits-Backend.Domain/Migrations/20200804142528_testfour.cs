using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class testfour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.AddColumn<string>(
                name: "BundleType",
                table: "RatePlanRules",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BundleType",
                table: "RatePlanRules");

            migrationBuilder.InsertData(
                table: "RatePlanRules",
                columns: new[] { "Id", "Band", "Number", "RatePlan" },
                values: new object[,]
                {
                    { 1, "Contractor", 1, "Flex 65" },
                    { 2, "G2", 2, "Red 150" },
                    { 3, "H1", 2, "Red 150" },
                    { 4, "H2", 2, "Red 150" },
                    { 5, "G1", 3, "Red 300" },
                    { 6, "F", 4, "Red 500" },
                    { 7, "E", 5, "Red 800" }
                });
        }
    }
}
