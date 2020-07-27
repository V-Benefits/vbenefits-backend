using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessLineRequests");

            migrationBuilder.CreateTable(
                name: "SIMCardRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(nullable: false),
                    RequestedById = table.Column<int>(nullable: false),
                    RequestedOn = table.Column<DateTime>(nullable: false),
                    RequestFor = table.Column<string>(nullable: true),
                    RequestType = table.Column<string>(nullable: true),
                    RatePlanType = table.Column<string>(nullable: true),
                    VodafoneMobileNumber = table.Column<string>(nullable: true),
                    NationalIdImage = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    SimSerialNumber = table.Column<string>(nullable: true),
                    DataSimPlan = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SIMCardRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SIMCardRequests_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SIMCardRequests_RequestedById",
                table: "SIMCardRequests",
                column: "RequestedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SIMCardRequests");

            migrationBuilder.CreateTable(
                name: "BusinessLineRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    DataSimPlan = table.Column<string>(type: "text", nullable: true),
                    NationalIdImage = table.Column<string>(type: "text", nullable: true),
                    RatePlanType = table.Column<string>(type: "text", nullable: true),
                    RequestFor = table.Column<string>(type: "text", nullable: true),
                    RequestType = table.Column<string>(type: "text", nullable: true),
                    RequestedById = table.Column<int>(type: "integer", nullable: false),
                    RequestedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SimSerialNumber = table.Column<string>(type: "text", nullable: true),
                    StaffId = table.Column<int>(type: "integer", nullable: false),
                    VodafoneMobileNumber = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessLineRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessLineRequests_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLineRequests_RequestedById",
                table: "BusinessLineRequests",
                column: "RequestedById");
        }
    }
}
