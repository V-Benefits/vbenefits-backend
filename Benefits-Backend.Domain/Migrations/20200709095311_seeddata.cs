using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class seeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "RoundDates",
                columns: new[] { "Id", "EndDate", "IsActive", "RoundName", "StartDate" },
                values: new object[] { 1, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "July 2020", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoundDates",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
