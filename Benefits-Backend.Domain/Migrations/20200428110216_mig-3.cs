using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppSetting",
                columns: new[] { "Id", "Key", "Name", "Value" },
                values: new object[] { 1, "MaxPercentWithdrawal", "Max Percent Withdrawal", "65" });

            migrationBuilder.InsertData(
                table: "PensionEnrollmentRules",
                columns: new[] { "Id", "Band", "NumberOfMonthsToEnrollment" },
                values: new object[,]
                {
                    { 1, "S", 0 },
                    { 2, "E", 3 },
                    { 3, "F", 3 },
                    { 4, "G", 24 },
                    { 5, "H", 24 }
                });

            migrationBuilder.InsertData(
                table: "VestingRules",
                columns: new[] { "Id", "FromYear", "ToYear", "VestingRulesPercentage" },
                values: new object[,]
                {
                    { 1, 2, 3, 50 },
                    { 2, 3, 4, 65 },
                    { 3, 4, 5, 85 },
                    { 4, 5, 0, 100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppSetting",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PensionEnrollmentRules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PensionEnrollmentRules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PensionEnrollmentRules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PensionEnrollmentRules",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PensionEnrollmentRules",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "VestingRules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "VestingRules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "VestingRules",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "VestingRules",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
