using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class testfive : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RatePlanRules",
                columns: new[] { "Id", "Band", "BundleType", "Number", "RatePlan" },
                values: new object[,]
                {
                    { 1, "Contractor", "Employee Line", 1, "Flex 65" },
                    { 2, "G2", "Employee Line", 2, "Red 150" },
                    { 3, "H1", "Employee Line", 2, "Red 150" },
                    { 4, "H2", "Employee Line", 2, "Red 150" },
                    { 5, "G1", "Employee Line", 3, "Red 300" },
                    { 6, "F", "Employee Line", 4, "Red 500" },
                    { 7, "E", "Employee Line", 5, "Red 800" },
                    { 8, "H", "Employee Data", 4, "20 GB" },
                    { 9, "G", "Employee Data", 1, "20 GB" },
                    { 10, "Contractors", "Employee Data", 1, "20 GB" },
                    { 11, "F", "Employee Data", 2, "40 GB" },
                    { 14, "E", "Employee Data", 2, "40 GB" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 14);
        }
    }
}
