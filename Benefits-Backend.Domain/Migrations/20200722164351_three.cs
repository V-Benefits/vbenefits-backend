using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatePlanTypeLookups_RequestTypeLookup_RequestTypeId",
                table: "RatePlanTypeLookups");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestTypeLookup_RequestForLookups_RequestForId",
                table: "RequestTypeLookup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestTypeLookup",
                table: "RequestTypeLookup");

            migrationBuilder.RenameTable(
                name: "RequestTypeLookup",
                newName: "RequestTypeLookups");

            migrationBuilder.RenameIndex(
                name: "IX_RequestTypeLookup_RequestForId",
                table: "RequestTypeLookups",
                newName: "IX_RequestTypeLookups_RequestForId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestTypeLookups",
                table: "RequestTypeLookups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RatePlanTypeLookups_RequestTypeLookups_RequestTypeId",
                table: "RatePlanTypeLookups",
                column: "RequestTypeId",
                principalTable: "RequestTypeLookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestTypeLookups_RequestForLookups_RequestForId",
                table: "RequestTypeLookups",
                column: "RequestForId",
                principalTable: "RequestForLookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatePlanTypeLookups_RequestTypeLookups_RequestTypeId",
                table: "RatePlanTypeLookups");

            migrationBuilder.DropForeignKey(
                name: "FK_RequestTypeLookups_RequestForLookups_RequestForId",
                table: "RequestTypeLookups");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RequestTypeLookups",
                table: "RequestTypeLookups");

            migrationBuilder.RenameTable(
                name: "RequestTypeLookups",
                newName: "RequestTypeLookup");

            migrationBuilder.RenameIndex(
                name: "IX_RequestTypeLookups_RequestForId",
                table: "RequestTypeLookup",
                newName: "IX_RequestTypeLookup_RequestForId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RequestTypeLookup",
                table: "RequestTypeLookup",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RatePlanTypeLookups_RequestTypeLookup_RequestTypeId",
                table: "RatePlanTypeLookups",
                column: "RequestTypeId",
                principalTable: "RequestTypeLookup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RequestTypeLookup_RequestForLookups_RequestForId",
                table: "RequestTypeLookup",
                column: "RequestForId",
                principalTable: "RequestForLookups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
