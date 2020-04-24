using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class addmetlifeandhistoricalDatatables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "historicalMetlifeData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CERT = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OldBalance = table.Column<float>(nullable: false),
                    Contribution = table.Column<float>(nullable: false),
                    Income = table.Column<float>(nullable: false),
                    Withdrawals = table.Column<float>(nullable: false),
                    NewBalance = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicalMetlifeData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "metlifeData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CERT = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    OldBalance = table.Column<float>(nullable: false),
                    Contribution = table.Column<float>(nullable: false),
                    Income = table.Column<float>(nullable: false),
                    Withdrawals = table.Column<float>(nullable: false),
                    NewBalance = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_metlifeData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneProgramRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestFor = table.Column<string>(nullable: true),
                    RequestById = table.Column<int>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneProgramRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneProgramRequests_Employees_RequestById",
                        column: x => x.RequestById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProgramRequests_RequestById",
                table: "PhoneProgramRequests",
                column: "RequestById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "historicalMetlifeData");

            migrationBuilder.DropTable(
                name: "metlifeData");

            migrationBuilder.DropTable(
                name: "PhoneProgramRequests");
        }
    }
}
