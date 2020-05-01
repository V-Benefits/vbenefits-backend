using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class mig5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSeetingHistory_AppSetting_AppSettingId",
                table: "AppSeetingHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppSetting",
                table: "AppSetting");

            migrationBuilder.DropColumn(
                name: "BalanceAsOf28FebSimpleformula",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "Band",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "CC",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "EligibilityBasedOnLastRound",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "MaxLoanAmount",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "ProrateContribution",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "SepRound",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "SubBand",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "Tenure",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "VestedBalance",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "Vesting",
                table: "metlifeData");

            migrationBuilder.DropColumn(
                name: "BalanceAsOf28FebSimpleformula",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "Band",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "CC",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "EligibilityBasedOnLastRound",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "MaxLoanAmount",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "ProrateContribution",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "SepRound",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "SubBand",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "Tenure",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedBalanceAsOf28FebSimpleformula",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedBand",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedCC",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedEligibilityBasedOnLastRound",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedHiringDate",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedMaxLoanAmount",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedProrateContribution",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedSepRound",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedStaffId",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedSubBand",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedTenure",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedVestedBalance",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedVesting",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "VestedBalance",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "Vesting",
                table: "historicalMetlifeData");

            migrationBuilder.RenameTable(
                name: "AppSetting",
                newName: "AppSettings");

            migrationBuilder.AddColumn<string>(
                name: "Band",
                table: "PensionRequests",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CostCenter",
                table: "PensionRequests",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "PensionRequests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Income",
                table: "PensionRequests",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PensionRequests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "PensionRequests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubBand",
                table: "PensionRequests",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Tenure",
                table: "PensionRequests",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<decimal>(
                name: "Withdrawals",
                table: "metlifeData",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "OldBalance",
                table: "metlifeData",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "NewBalance",
                table: "metlifeData",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Income",
                table: "metlifeData",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<decimal>(
                name: "Contribution",
                table: "metlifeData",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppSettings",
                table: "AppSettings",
                column: "Id");

            migrationBuilder.InsertData(
                table: "metlifeData",
                columns: new[] { "Id", "CERT", "Contribution", "Income", "Name", "NewBalance", "OldBalance", "Withdrawals" },
                values: new object[] { 1, 2, 85299.64m, 4233.757m, "MAHMOUD, ASHRAF", 142326.8m, 52793.4m, 0m });

            migrationBuilder.InsertData(
                table: "metlifeData",
                columns: new[] { "Id", "CERT", "Contribution", "Income", "Name", "NewBalance", "OldBalance", "Withdrawals" },
                values: new object[] { 2, 3, 15439.77m, 1277.134m, "Abdallah Fekry Kenawy, Abdullah Mahmoud", 33200.45m, 25658.55m, 9175m });

            migrationBuilder.AddForeignKey(
                name: "FK_AppSeetingHistory_AppSettings_AppSettingId",
                table: "AppSeetingHistory",
                column: "AppSettingId",
                principalTable: "AppSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSeetingHistory_AppSettings_AppSettingId",
                table: "AppSeetingHistory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppSettings",
                table: "AppSettings");

            migrationBuilder.DeleteData(
                table: "metlifeData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "metlifeData",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Band",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "CostCenter",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "HiringDate",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "Income",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "SubBand",
                table: "PensionRequests");

            migrationBuilder.DropColumn(
                name: "Tenure",
                table: "PensionRequests");

            migrationBuilder.RenameTable(
                name: "AppSettings",
                newName: "AppSetting");

            migrationBuilder.AlterColumn<float>(
                name: "Withdrawals",
                table: "metlifeData",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "OldBalance",
                table: "metlifeData",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "NewBalance",
                table: "metlifeData",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "Income",
                table: "metlifeData",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<float>(
                name: "Contribution",
                table: "metlifeData",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<float>(
                name: "BalanceAsOf28FebSimpleformula",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Band",
                table: "metlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CC",
                table: "metlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EligibilityBasedOnLastRound",
                table: "metlifeData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "metlifeData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "MaxLoanAmount",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ProrateContribution",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SepRound",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "metlifeData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubBand",
                table: "metlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Tenure",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VestedBalance",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Vesting",
                table: "metlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "BalanceAsOf28FebSimpleformula",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Band",
                table: "historicalMetlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CC",
                table: "historicalMetlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EligibilityBasedOnLastRound",
                table: "historicalMetlifeData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "historicalMetlifeData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "MaxLoanAmount",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ProrateContribution",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SepRound",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "historicalMetlifeData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubBand",
                table: "historicalMetlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Tenure",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedBalanceAsOf28FebSimpleformula",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBand",
                table: "historicalMetlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedCC",
                table: "historicalMetlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "UpdatedEligibilityBasedOnLastRound",
                table: "historicalMetlifeData",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedHiringDate",
                table: "historicalMetlifeData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "UpdatedMaxLoanAmount",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedProrateContribution",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedSepRound",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedStaffId",
                table: "historicalMetlifeData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedSubBand",
                table: "historicalMetlifeData",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedTenure",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedVestedBalance",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedVesting",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VestedBalance",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Vesting",
                table: "historicalMetlifeData",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppSetting",
                table: "AppSetting",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSeetingHistory_AppSetting_AppSettingId",
                table: "AppSeetingHistory",
                column: "AppSettingId",
                principalTable: "AppSetting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
