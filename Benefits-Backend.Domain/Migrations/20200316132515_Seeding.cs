using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "MobileNumber", "Name", "NationalId", "StaffId" },
                values: new object[] { 1, "agamy@pragimtech.com", null, "Agamy", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
