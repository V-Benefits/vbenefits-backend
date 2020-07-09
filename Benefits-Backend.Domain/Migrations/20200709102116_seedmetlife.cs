using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class seedmetlife : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "metlifeData",
                columns: new[] { "Id", "CERT", "Contribution", "Income", "Name", "NewBalance", "OldBalance", "Withdrawals" },
                values: new object[] { 5, 26018, 89238m, 9438m, "Mohamed AlMokadem", 237070m, 168140m, 0m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "metlifeData",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
