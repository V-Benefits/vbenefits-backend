using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class testthree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "SIMCardRequests",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "Contractor", 1, "Flex 65" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "G2", 2, "Red 150" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 3,
                column: "Band",
                value: "H1");

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "H2", 2, "Red 150" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "G1", 3, "Red 300" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "F", 4, "Red 500" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "E", 5, "Red 800" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SIMCardRequests");

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "E", 5, "Red 800" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "F", 4, "Red 500" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 3,
                column: "Band",
                value: "G2");

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "G1", 3, "Red 300" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "H1", 2, "Red 150" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "H2", 2, "Red 150" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Band", "Number", "RatePlan" },
                values: new object[] { "Contractor", 1, "Flex 65" });
        }
    }
}
