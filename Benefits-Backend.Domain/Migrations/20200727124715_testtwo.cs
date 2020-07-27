using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class testtwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatePlanType",
                table: "SIMCardRequests");

            migrationBuilder.DropColumn(
                name: "VodafoneMobileNumber",
                table: "SIMCardRequests");

            migrationBuilder.AddColumn<string>(
                name: "FamilyOrFriendFirstName",
                table: "SIMCardRequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "SIMCardRequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RatePlan",
                table: "SIMCardRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "RatePlanRules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 1,
                column: "Number",
                value: 5);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 2,
                column: "Number",
                value: 4);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 3,
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Number", "RatePlan" },
                values: new object[] { 3, "Red 300" });

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 5,
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 6,
                column: "Number",
                value: 2);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 7,
                column: "Number",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilyOrFriendFirstName",
                table: "SIMCardRequests");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "SIMCardRequests");

            migrationBuilder.DropColumn(
                name: "RatePlan",
                table: "SIMCardRequests");

            migrationBuilder.DropColumn(
                name: "Number",
                table: "RatePlanRules");

            migrationBuilder.AddColumn<string>(
                name: "RatePlanType",
                table: "SIMCardRequests",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VodafoneMobileNumber",
                table: "SIMCardRequests",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "RatePlanRules",
                keyColumn: "Id",
                keyValue: 4,
                column: "RatePlan",
                value: " Red 500");
        }
    }
}
