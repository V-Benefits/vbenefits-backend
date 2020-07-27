using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class usedlines : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    NationalId = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    LandlineNumber = table.Column<string>(nullable: true),
                    NumberOfUsedLines = table.Column<int>(nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UpdatedON = table.Column<DateTime>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    CERT = table.Column<int>(nullable: false),
                    OldBalance = table.Column<float>(nullable: false),
                    Contribution = table.Column<float>(nullable: false),
                    Income = table.Column<float>(nullable: false),
                    Withdrawals = table.Column<float>(nullable: false),
                    NewBalance = table.Column<float>(nullable: false),
                    UpdatedName = table.Column<string>(nullable: true),
                    UpdatedCERT = table.Column<int>(nullable: false),
                    UpdatedOldBalance = table.Column<float>(nullable: false),
                    UpdatedContribution = table.Column<float>(nullable: false),
                    UpdatedIncome = table.Column<float>(nullable: false),
                    UpdatedWithdrawals = table.Column<float>(nullable: false),
                    UpdatedNewBalance = table.Column<float>(nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    CERT = table.Column<int>(nullable: false),
                    OldBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Contribution = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Withdrawals = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    NewBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Band = table.Column<string>(nullable: false),
                    NumberOfMonthsToEnrollment = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PensionEnrollmentRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RatePlanRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Band = table.Column<string>(nullable: false),
                    RatePlan = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatePlanRules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequestForLookups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestForLookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoundDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoundName = table.Column<string>(nullable: false),
                    StartDate = table.Column<DateTime>(type: "date", nullable: false),
                    EndDate = table.Column<DateTime>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoundDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SuccessFactor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Band = table.Column<string>(nullable: true),
                    CostCenter = table.Column<string>(nullable: true),
                    Tenure = table.Column<double>(nullable: false),
                    SubBand = table.Column<string>(nullable: true),
                    HiringDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuccessFactor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "URLsLookups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_URLsLookups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VestingRules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: false),
                    Key = table.Column<string>(nullable: false),
                    OldValue = table.Column<string>(nullable: false),
                    NewValue = table.Column<string>(nullable: false),
                    ChangedById = table.Column<int>(nullable: false),
                    ChangedOn = table.Column<DateTime>(type: "date", nullable: false),
                    AppSettingId = table.Column<int>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSeetingHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppSeetingHistory_AppSettings_AppSettingId",
                        column: x => x.AppSettingId,
                        principalTable: "AppSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppSeetingHistory_Employees_ChangedById",
                        column: x => x.ChangedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppSeetingHistory_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BusinessLineRequests",
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
                    table.PrimaryKey("PK_BusinessLineRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BusinessLineRequests_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalCardRequestForEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(nullable: false),
                    RequestedById = table.Column<int>(nullable: false),
                    RequestedOn = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    PersonalImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalCardRequestForEmployees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalCardRequestForEmployees_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalCardRequestForSpouses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(nullable: false),
                    RequestedById = table.Column<int>(nullable: false),
                    RequestedOn = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    SpouseName = table.Column<string>(nullable: true),
                    SpouseImage = table.Column<string>(nullable: true),
                    MarrigeCertificate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalCardRequestForSpouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalCardRequestForSpouses_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "medicalCardRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StaffId = table.Column<int>(nullable: false),
                    RequestedById = table.Column<int>(nullable: false),
                    RequestedOn = table.Column<DateTime>(nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    PersonalImage = table.Column<string>(nullable: true),
                    SpouseName = table.Column<string>(nullable: true),
                    SpouseImage = table.Column<string>(nullable: true),
                    MarrigeCertificate = table.Column<string>(nullable: true),
                    ChildName = table.Column<string>(nullable: true),
                    ChildImage = table.Column<string>(nullable: true),
                    BirthCertificate = table.Column<string>(nullable: true),
                    RequestType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicalCardRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicalCardRequests_Employees_RequestedById",
                        column: x => x.RequestedById,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PensionEnrollmentRulesHistories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BandBefore = table.Column<string>(nullable: false),
                    NumberOfMonthsToEnrollmentBefore = table.Column<int>(nullable: false),
                    BandAfter = table.Column<string>(nullable: false),
                    NumberOfMonthsToEnrollmentAfter = table.Column<int>(nullable: false),
                    UpdatedById = table.Column<int>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "date", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WithdrawalAmmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BeginingBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CurrentyearContribution = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VestingPercent = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    VestedBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    LastRoundWithdrawal = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    ProratedNewContribution = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CurrentAvailableBalance = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    MaxWithdrawalAmount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    isEligible = table.Column<bool>(nullable: false),
                    StaffId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Band = table.Column<string>(nullable: true),
                    CostCenter = table.Column<string>(nullable: true),
                    Tenure = table.Column<double>(nullable: false),
                    SubBand = table.Column<string>(nullable: true),
                    HiringDate = table.Column<DateTime>(nullable: false),
                    RequestedById = table.Column<int>(nullable: false),
                    RequestedOn = table.Column<DateTime>(type: "date", nullable: false),
                    isActive = table.Column<bool>(nullable: false),
                    isApproved = table.Column<bool>(nullable: false),
                    ApprovedOn = table.Column<DateTime>(nullable: false),
                    isRejected = table.Column<bool>(nullable: false),
                    RejectedOn = table.Column<DateTime>(nullable: false),
                    isEnrolled = table.Column<bool>(nullable: false),
                    NumberOfMonthsToEnroll = table.Column<double>(nullable: false),
                    isCanceled = table.Column<bool>(nullable: false),
                    Status = table.Column<string>(nullable: true)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RequestFor = table.Column<string>(nullable: false),
                    RequestById = table.Column<int>(nullable: false),
                    RequestDate = table.Column<DateTime>(type: "date", nullable: false)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
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

            migrationBuilder.CreateTable(
                name: "RequestTypeLookup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    RequestForId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypeLookup", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestTypeLookup_RequestForLookups_RequestForId",
                        column: x => x.RequestForId,
                        principalTable: "RequestForLookups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RatePlanTypeLookups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Key = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: false),
                    RequestTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatePlanTypeLookups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RatePlanTypeLookups_RequestTypeLookup_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestTypeLookup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppSettings",
                columns: new[] { "Id", "Key", "Name", "Value" },
                values: new object[] { 1, "MaxPercentWithdrawal", "Max Percent Withdrawal", "65" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "Email", "FullName", "LandlineNumber", "MobileNumber", "NationalId", "NumberOfUsedLines", "StaffId" },
                values: new object[,]
                {
                    { 1, new DateTime(1991, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mohamed.Almokadem@vodafone.com", "Mohamed AlMokadem", "00226799126", "01015925905", "0000200230979239", 0, 26018 },
                    { 2, new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hager@vodafone.com", "Hager Ahmed", "00226799126", "010133344555", "0000200230979239", 0, 26782 },
                    { 3, new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mona@vodafone.com", "Mona Fawzy", "00224456126", "010133234588", "0000200230559449", 0, 28896 }
                });

            migrationBuilder.InsertData(
                table: "PensionEnrollmentRules",
                columns: new[] { "Id", "Band", "NumberOfMonthsToEnrollment" },
                values: new object[,]
                {
                    { 5, "H", 24 },
                    { 4, "G", 24 },
                    { 3, "F", 3 },
                    { 1, "S", 0 },
                    { 2, "E", 3 }
                });

            migrationBuilder.InsertData(
                table: "RoundDates",
                columns: new[] { "Id", "EndDate", "IsActive", "RoundName", "StartDate" },
                values: new object[] { 1, new DateTime(2020, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "July 2020", new DateTime(2020, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "URLsLookups",
                columns: new[] { "Id", "Key", "Value" },
                values: new object[,]
                {
                    { 1, "PensionPolicyURL", "" },
                    { 2, "PensionPolicyFilePath", "" }
                });

            migrationBuilder.InsertData(
                table: "VestingRules",
                columns: new[] { "Id", "FromYear", "ToYear", "VestingRulesPercentage" },
                values: new object[,]
                {
                    { 3, 4, 5, 85 },
                    { 1, 2, 3, 50 },
                    { 2, 3, 4, 65 },
                    { 4, 5, 0, 100 }
                });

            migrationBuilder.InsertData(
                table: "metlifeData",
                columns: new[] { "Id", "CERT", "Contribution", "Income", "Name", "NewBalance", "OldBalance", "Withdrawals" },
                values: new object[,]
                {
                    { 4, 3, 89238m, 9438m, "Ziad", 237070m, 168140m, 0m },
                    { 3, 2, 85299.64m, 4233.76m, "Mona", 142326.80m, 52793.40m, 0m },
                    { 2, 30, 15439.77m, 1277.134m, "Abdallah Fekry Kenawy, Abdullah Mahmoud", 33200.45m, 25658.55m, 9175m },
                    { 1, 20, 85299.64m, 4233.757m, "MAHMOUD, ASHRAF", 142326.8m, 52793.4m, 0m },
                    { 5, 26018, 89238m, 9438m, "Mohamed AlMokadem", 237070m, 168140m, 0m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppSeetingHistory_AppSettingId",
                table: "AppSeetingHistory",
                column: "AppSettingId");

            migrationBuilder.CreateIndex(
                name: "IX_AppSeetingHistory_ChangedById",
                table: "AppSeetingHistory",
                column: "ChangedById");

            migrationBuilder.CreateIndex(
                name: "IX_AppSeetingHistory_EmployeeId",
                table: "AppSeetingHistory",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessLineRequests_RequestedById",
                table: "BusinessLineRequests",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_medicalCardRequestForEmployees_RequestedById",
                table: "medicalCardRequestForEmployees",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_medicalCardRequestForSpouses_RequestedById",
                table: "medicalCardRequestForSpouses",
                column: "RequestedById");

            migrationBuilder.CreateIndex(
                name: "IX_medicalCardRequests_RequestedById",
                table: "medicalCardRequests",
                column: "RequestedById");

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
                name: "IX_RatePlanTypeLookups_RequestTypeId",
                table: "RatePlanTypeLookups",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTypeLookup_RequestForId",
                table: "RequestTypeLookup",
                column: "RequestForId");

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
                name: "BusinessLineRequests");

            migrationBuilder.DropTable(
                name: "historicalMetlifeData");

            migrationBuilder.DropTable(
                name: "medicalCardRequestForEmployees");

            migrationBuilder.DropTable(
                name: "medicalCardRequestForSpouses");

            migrationBuilder.DropTable(
                name: "medicalCardRequests");

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
                name: "RatePlanRules");

            migrationBuilder.DropTable(
                name: "RatePlanTypeLookups");

            migrationBuilder.DropTable(
                name: "RoundDates");

            migrationBuilder.DropTable(
                name: "SuccessFactor");

            migrationBuilder.DropTable(
                name: "URLsLookups");

            migrationBuilder.DropTable(
                name: "VestingRules");

            migrationBuilder.DropTable(
                name: "VestingRulesHistories");

            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "RequestTypeLookup");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "RequestForLookups");
        }
    }
}
