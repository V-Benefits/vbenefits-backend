using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class testfi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 8,
                column: "Number",
                value: 1);

            migrationBuilder.InsertData(
                table: "RatePlanRules",
                columns: new[] { "Id", "Band", "BundleType", "Number", "RatePlan" },
                values: new object[] { 12, "E", "Employee Data", 2, "40 GB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 8,
                column: "Number",
                value: 4);

            migrationBuilder.InsertData(
                table: "RatePlanRules",
                columns: new[] { "Id", "Band", "BundleType", "Number", "RatePlan" },
                values: new object[] { 14, "E", "Employee Data", 2, "40 GB" });
        }
    }
}
