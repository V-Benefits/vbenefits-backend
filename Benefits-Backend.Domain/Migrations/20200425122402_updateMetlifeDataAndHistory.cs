using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Benefits_Backend.Domain.Migrations
{
    public partial class updateMetlifeDataAndHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "BalanceAsOf28FebSimpleformula",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Band",
                table: "metlifeData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CC",
                table: "metlifeData",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EligibilityBasedOnLastRound",
                table: "metlifeData",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "metlifeData",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "MaxLoanAmount",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ProrateContribution",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SepRound",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubBand",
                table: "metlifeData",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Tenure",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VestedBalance",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Vesting",
                table: "metlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "BalanceAsOf28FebSimpleformula",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Band",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CC",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EligibilityBasedOnLastRound",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "HiringDate",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "MaxLoanAmount",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "ProrateContribution",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "SepRound",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SubBand",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Tenure",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedBalanceAsOf28FebSimpleformula",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBand",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedById",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedCC",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedCERT",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedContribution",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<bool>(
                name: "UpdatedEligibilityBasedOnLastRound",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedHiringDate",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "UpdatedIncome",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedMaxLoanAmount",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedName",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedNewBalance",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedON",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<float>(
                name: "UpdatedOldBalance",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedProrateContribution",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedSepRound",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedStaffId",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedSubBand",
                table: "historicalMetlifeData",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedTenure",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedVestedBalance",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedVesting",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "UpdatedWithdrawals",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "VestedBalance",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Vesting",
                table: "historicalMetlifeData",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "UpdatedById",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedCC",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedCERT",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedContribution",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedEligibilityBasedOnLastRound",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedHiringDate",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedIncome",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedMaxLoanAmount",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedName",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedNewBalance",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedON",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "UpdatedOldBalance",
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
                name: "UpdatedWithdrawals",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "VestedBalance",
                table: "historicalMetlifeData");

            migrationBuilder.DropColumn(
                name: "Vesting",
                table: "historicalMetlifeData");
        }
    }
}
