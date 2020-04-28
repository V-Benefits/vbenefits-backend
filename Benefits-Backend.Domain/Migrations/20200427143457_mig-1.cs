using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSetting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSetting", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffId = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    NationalId = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    LandlineNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "historicalMetlifeData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UpdatedON = table.Column<DateTime>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: false),
                    CERT = table.Column<int>(nullable: false),
                    OldBalance = table.Column<float>(nullable: false),
                    Contribution = table.Column<float>(nullable: false),
                    Income = table.Column<float>(nullable: false),
                    Withdrawals = table.Column<float>(nullable: false),
                    NewBalance = table.Column<float>(nullable: false),
                    UpdatedCERT = table.Column<int>(nullable: false),
                    UpdatedOldBalance = table.Column<float>(nullable: false),
                    UpdatedContribution = table.Column<float>(nullable: false),
                    UpdatedIncome = table.Column<float>(nullable: false),
                    UpdatedWithdrawals = table.Column<float>(nullable: false),
                    UpdatedNewBalance = table.Column<float>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Band = table.Column<string>(nullable: true),
                    CC = table.Column<string>(nullable: true),
                    Tenure = table.Column<float>(nullable: false),
                    SubBand = table.Column<string>(nullable: true),
                    HiringDate = table.Column<DateTime>(nullable: false),
                    Vesting = table.Column<float>(nullable: false),
                    SepRound = table.Column<float>(nullable: false),
                    EligibilityBasedOnLastRound = table.Column<bool>(nullable: false),
                    VestedBalance = table.Column<float>(nullable: false),
                    MaxLoanAmount = table.Column<float>(nullable: false),
                    ProrateContribution = table.Column<float>(nullable: false),
                    BalanceAsOf28FebSimpleformula = table.Column<float>(nullable: false),
                    UpdatedStaffId = table.Column<int>(nullable: false),
                    UpdatedName = table.Column<string>(nullable: true),
                    UpdatedBand = table.Column<string>(nullable: true),
                    UpdatedCC = table.Column<string>(nullable: true),
                    UpdatedTenure = table.Column<float>(nullable: false),
                    UpdatedSubBand = table.Column<string>(nullable: true),
                    UpdatedHiringDate = table.Column<DateTime>(nullable: false),
                    UpdatedVesting = table.Column<float>(nullable: false),
                    UpdatedSepRound = table.Column<float>(nullable: false),
                    UpdatedEligibilityBasedOnLastRound = table.Column<bool>(nullable: false),
                    UpdatedVestedBalance = table.Column<float>(nullable: false),
                    UpdatedMaxLoanAmount = table.Column<float>(nullable: false),
                    UpdatedProrateContribution = table.Column<float>(nullable: false),
                    UpdatedBalanceAsOf28FebSimpleformula = table.Column<float>(nullable: false)
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
                    OldBalance = table.Column<float>(nullable: false),
                    Contribution = table.Column<float>(nullable: false),
                    Income = table.Column<float>(nullable: false),
                    Withdrawals = table.Column<float>(nullable: false),
                    NewBalance = table.Column<float>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Band = table.Column<string>(nullable: true),
                    CC = table.Column<string>(nullable: true),
                    Tenure = table.Column<float>(nullable: false),
                    SubBand = table.Column<string>(nullable: true),
                    HiringDate = table.Column<DateTime>(nullable: false),
                    Vesting = table.Column<float>(nullable: false),
                    SepRound = table.Column<float>(nullable: false),
                    EligibilityBasedOnLastRound = table.Column<bool>(nullable: false),
                    VestedBalance = table.Column<float>(nullable: false),
                    MaxLoanAmount = table.Column<float>(nullable: false),
                    ProrateContribution = table.Column<float>(nullable: false),
                    BalanceAsOf28FebSimpleformula = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_metlifeData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PensionEnrollmentRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Band = table.Column<string>(nullable: true),
                    NumberOfMonthsToEnrollment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionEnrollmentRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VestingRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VestingRulesPercentage = table.Column<int>(nullable: false),
                    FromYear = table.Column<int>(nullable: false),
                    ToYear = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VestingRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppSeetingHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    OldValue = table.Column<string>(nullable: true),
                    NewValue = table.Column<string>(nullable: true),
                    ChangedById = table.Column<int>(nullable: false),
                    ChangedOn = table.Column<DateTime>(nullable: false),
                    AppSettingId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSeetingHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSeetingHistory_AppSetting_AppSettingId",
                        column: x => x.AppSettingId,
                        principalTable: "AppSetting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppSeetingHistory_Employees_ChangedById",
                        column: x => x.ChangedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PensionEnrollmentRulesHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BandBefore = table.Column<string>(nullable: true),
                    NumberOfMonthsToEnrollmentBefore = table.Column<int>(nullable: false),
                    BandAfter = table.Column<string>(nullable: true),
                    NumberOfMonthsToEnrollmentAfter = table.Column<int>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionEnrollmentRulesHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PensionEnrollmentRulesHistories_Employees_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PensionRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WithdrawalAmmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BeginingBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CurrentyearContribution = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VestingPercent = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    LastRoundWithdrawal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ProratedNewContribution = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CurrentAvailableBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MaxWithdrawalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    YearsOfService = table.Column<string>(nullable: false),
                    RequestedById = table.Column<int>(nullable: false),
                    RequestedOn = table.Column<DateTime>(type: "date", nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    isApproved = table.Column<bool>(nullable: false),
                    ApprovedOn = table.Column<DateTime>(nullable: false),
                    RejectedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PensionRequests_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "VestingRulesHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromYearBefore = table.Column<int>(nullable: false),
                    ToYearBefore = table.Column<int>(nullable: false),
                    VestingPercentageBefore = table.Column<int>(nullable: false),
                    FromYearAfter = table.Column<int>(nullable: false),
                    ToYearAfter = table.Column<int>(nullable: false),
                    VestingPercentageAfter = table.Column<int>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VestingRulesHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VestingRulesHistories_Employees_UpdatedById",
                        column: x => x.UpdatedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "FullName", "LandlineNumber", "MobileNumber", "NationalId", "StaffId" },
                values: new object[] { 1, new DateTime(1991, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed.Almokadem@vodafone.com", "Mohamed AlMokadem", "00226799126", "01015925905", "0000200230979239", "26018" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "FullName", "LandlineNumber", "MobileNumber", "NationalId", "StaffId" },
                values: new object[] { 2, new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hager@vodafone.com", "Hager Ahmed", "00226799126", "010133344555", "0000200230979239", "26782" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "FullName", "LandlineNumber", "MobileNumber", "NationalId", "StaffId" },
                values: new object[] { 3, new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mona@vodafone.com", "Mona Fawzy", "00224456126", "010133234588", "0000200230559449", "28896" });

            migrationBuilder.CreateIndex(
                name: "IX_AppSeetingHistory_AppSettingId",
                table: "AppSeetingHistory",
                column: "AppSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSeetingHistory_ChangedById",
                table: "AppSeetingHistory",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_PensionEnrollmentRulesHistories_UpdatedById",
                table: "PensionEnrollmentRulesHistories",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_PensionRequests_RequestedById",
                table: "PensionRequests",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneProgramRequests_RequestById",
                table: "PhoneProgramRequests",
                column: "RequestById");

            migrationBuilder.CreateIndex(
                name: "IX_VestingRulesHistories_UpdatedById",
                table: "VestingRulesHistories",
                column: "UpdatedById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSeetingHistory");

            migrationBuilder.DropTable(
                name: "historicalMetlifeData");

            migrationBuilder.DropTable(
                name: "metlifeData");

            migrationBuilder.DropTable(
                name: "PensionEnrollmentRules");

            migrationBuilder.DropTable(
                name: "PensionEnrollmentRulesHistories");

            migrationBuilder.DropTable(
                name: "PensionRequests");

            migrationBuilder.DropTable(
                name: "PhoneProgramRequests");

            migrationBuilder.DropTable(
                name: "VestingRules");

            migrationBuilder.DropTable(
                name: "VestingRulesHistories");

            migrationBuilder.DropTable(
                name: "AppSetting");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
