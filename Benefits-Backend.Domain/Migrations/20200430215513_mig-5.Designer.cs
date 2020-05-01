﻿// <auto-generated />
using System;
using Benefits_Backend.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Benefits_Backend.Domain.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20200430215513_mig-5")]
    partial class mig5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.AppSeetingHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AppSettingId")
                        .HasColumnType("int");

                    b.Property<int>("ChangedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("ChangedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValue")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AppSettingId");

                    b.HasIndex("ChangedById");

                    b.ToTable("AppSeetingHistory");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.AppSetting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppSettings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Key = "MaxPercentWithdrawal",
                            Name = "Max Percent Withdrawal",
                            Value = "65"
                        });
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandlineNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1991, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mohamed.Almokadem@vodafone.com",
                            FullName = "Mohamed AlMokadem",
                            LandlineNumber = "00226799126",
                            MobileNumber = "01015925905",
                            NationalId = "0000200230979239",
                            StaffId = "26018"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1993, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Hager@vodafone.com",
                            FullName = "Hager Ahmed",
                            LandlineNumber = "00226799126",
                            MobileNumber = "010133344555",
                            NationalId = "0000200230979239",
                            StaffId = "26782"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Mona@vodafone.com",
                            FullName = "Mona Fawzy",
                            LandlineNumber = "00224456126",
                            MobileNumber = "010133234588",
                            NationalId = "0000200230559449",
                            StaffId = "28896"
                        });
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.HistoricalMetlifeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CERT")
                        .HasColumnType("int");

                    b.Property<float>("Contribution")
                        .HasColumnType("real");

                    b.Property<float>("Income")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NewBalance")
                        .HasColumnType("real");

                    b.Property<float>("OldBalance")
                        .HasColumnType("real");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedCERT")
                        .HasColumnType("int");

                    b.Property<float>("UpdatedContribution")
                        .HasColumnType("real");

                    b.Property<float>("UpdatedIncome")
                        .HasColumnType("real");

                    b.Property<string>("UpdatedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("UpdatedNewBalance")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdatedON")
                        .HasColumnType("datetime2");

                    b.Property<float>("UpdatedOldBalance")
                        .HasColumnType("real");

                    b.Property<float>("UpdatedWithdrawals")
                        .HasColumnType("real");

                    b.Property<float>("Withdrawals")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("historicalMetlifeData");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.MetlifeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CERT")
                        .HasColumnType("int");

                    b.Property<decimal>("Contribution")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NewBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OldBalance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Withdrawals")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("metlifeData");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CERT = 2,
                            Contribution = 85299.64m,
                            Income = 4233.757m,
                            Name = "MAHMOUD, ASHRAF",
                            NewBalance = 142326.8m,
                            OldBalance = 52793.4m,
                            Withdrawals = 0m
                        },
                        new
                        {
                            Id = 2,
                            CERT = 3,
                            Contribution = 15439.77m,
                            Income = 1277.134m,
                            Name = "Abdallah Fekry Kenawy, Abdullah Mahmoud",
                            NewBalance = 33200.45m,
                            OldBalance = 25658.55m,
                            Withdrawals = 9175m
                        });
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PensionEnrollmentRules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Band")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfMonthsToEnrollment")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PensionEnrollmentRules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Band = "S",
                            NumberOfMonthsToEnrollment = 0
                        },
                        new
                        {
                            Id = 2,
                            Band = "E",
                            NumberOfMonthsToEnrollment = 3
                        },
                        new
                        {
                            Id = 3,
                            Band = "F",
                            NumberOfMonthsToEnrollment = 3
                        },
                        new
                        {
                            Id = 4,
                            Band = "G",
                            NumberOfMonthsToEnrollment = 24
                        },
                        new
                        {
                            Id = 5,
                            Band = "H",
                            NumberOfMonthsToEnrollment = 24
                        });
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PensionEnrollmentRulesHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BandAfter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BandBefore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfMonthsToEnrollmentAfter")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfMonthsToEnrollmentBefore")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("UpdatedById");

                    b.ToTable("PensionEnrollmentRulesHistories");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PensionRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ApprovedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Band")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BeginingBalance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("CostCenter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CurrentAvailableBalance")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("CurrentyearContribution")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Income")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("LastRoundWithdrawal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("MaxWithdrawalAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProratedNewContribution")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("RejectedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("RequestedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestedOn")
                        .HasColumnType("date");

                    b.Property<int>("StaffId")
                        .HasColumnType("int");

                    b.Property<string>("SubBand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tenure")
                        .HasColumnType("float");

                    b.Property<decimal>("VestingPercent")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("WithdrawalAmmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<string>("YearsOfService")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isApproved")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("RequestedById");

                    b.ToTable("PensionRequests");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PhoneProgramRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestById")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestFor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RequestById");

                    b.ToTable("PhoneProgramRequests");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.VestingRules", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromYear")
                        .HasColumnType("int");

                    b.Property<int>("ToYear")
                        .HasColumnType("int");

                    b.Property<int>("VestingRulesPercentage")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("VestingRules");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FromYear = 2,
                            ToYear = 3,
                            VestingRulesPercentage = 50
                        },
                        new
                        {
                            Id = 2,
                            FromYear = 3,
                            ToYear = 4,
                            VestingRulesPercentage = 65
                        },
                        new
                        {
                            Id = 3,
                            FromYear = 4,
                            ToYear = 5,
                            VestingRulesPercentage = 85
                        },
                        new
                        {
                            Id = 4,
                            FromYear = 5,
                            ToYear = 0,
                            VestingRulesPercentage = 100
                        });
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.VestingRulesHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FromYearAfter")
                        .HasColumnType("int");

                    b.Property<int>("FromYearBefore")
                        .HasColumnType("int");

                    b.Property<int>("ToYearAfter")
                        .HasColumnType("int");

                    b.Property<int>("ToYearBefore")
                        .HasColumnType("int");

                    b.Property<int>("UpdatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("VestingPercentageAfter")
                        .HasColumnType("int");

                    b.Property<int>("VestingPercentageBefore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UpdatedById");

                    b.ToTable("VestingRulesHistories");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.AppSeetingHistory", b =>
                {
                    b.HasOne("Benefits_Backend.Domain.Entities.AppSetting", "AppSetting")
                        .WithMany("AppSeetingHistories")
                        .HasForeignKey("AppSettingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Benefits_Backend.Domain.Entities.Employee", "ChangedBy")
                        .WithMany("AppSeetingHistories")
                        .HasForeignKey("ChangedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PensionEnrollmentRulesHistory", b =>
                {
                    b.HasOne("Benefits_Backend.Domain.Entities.Employee", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PensionRequest", b =>
                {
                    b.HasOne("Benefits_Backend.Domain.Entities.Employee", "RequestedBy")
                        .WithMany("PensionRequests")
                        .HasForeignKey("RequestedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PhoneProgramRequest", b =>
                {
                    b.HasOne("Benefits_Backend.Domain.Entities.Employee", "RequestBy")
                        .WithMany()
                        .HasForeignKey("RequestById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.VestingRulesHistory", b =>
                {
                    b.HasOne("Benefits_Backend.Domain.Entities.Employee", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
