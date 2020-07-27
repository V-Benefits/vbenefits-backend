using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "RequestTypeLookup");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "RequestForLookups");

            migrationBuilder.InsertData(
                table: "RatePlanRules",
                columns: new[] { "Id", "Band", "RatePlan" },
                values: new object[,]
                {
                    { 1, "E", "Red 800" },
                    { 2, "F", "Red 500" },
                    { 3, "G2", "Red 150" },
                    { 4, "G1", " Red 500" },
                    { 5, "H1", "Red 150" },
                    { 6, "H2", "Red 150" },
                    { 7, "Contractor", "Flex 65" }
                });

            migrationBuilder.InsertData(
                table: "RequestForLookups",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, "Myself" },
                    { 2, "Family or friends ( deductible from salary)" }
                });

            migrationBuilder.InsertData(
                table: "RequestTypeLookup",
                columns: new[] { "Id", "RequestForId", "Value" },
                values: new object[,]
                {
                    { 2, 1, "New Line" },
                    { 3, 1, "New Data SIM" },
                    { 4, 1, "Change Line Rate Plan" },
                    { 5, 1, "Recharge Your Line" },
                    { 6, 1, "Change Your Data SIM" },
                    { 7, 1, "Recharge Your Data SIM" },
                    { 1, 2, "New Line" }
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
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RequestTypeLookup",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RequestForLookups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RequestForLookups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "RequestTypeLookup",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "RequestForLookups",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
