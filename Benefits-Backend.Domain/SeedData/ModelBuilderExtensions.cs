using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.SeedData
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                    new Employee
                    {
                        Id = 1,
                        StaffId = "26018",
                        FullName = "Mohamed AlMokadem",
                        Email = "Mohamed.Almokadem@vodafone.com",
                        DateOfBirth = new DateTime(1991, 12, 20),
                        NationalId = "0000200230979239",
                        MobileNumber = "01015925905",
                        LandlineNumber = "00226799126",
                    },
                    new Employee
                    {
                        Id = 2,
                        StaffId = "26782",
                        FullName = "Hager Ahmed",
                        Email = "Hager@vodafone.com",
                        DateOfBirth = new DateTime(1993, 11, 1),
                        NationalId = "0000200230979239",
                        MobileNumber = "010133344555",
                        LandlineNumber = "00226799126",
                    },
                    new Employee
                    {
                        Id = 3,
                        StaffId = "28896",
                        FullName = "Mona Fawzy",
                        Email = "Mona@vodafone.com",
                        DateOfBirth = new DateTime(1992, 6, 5),
                        NationalId = "0000200230559449",
                        MobileNumber = "010133234588",
                        LandlineNumber = "00224456126",
                    }
                );

            modelBuilder.Entity<VestingRules>().HasData(
                new VestingRules
                {
                    Id = 1,
                    FromYear = 2, 
                    ToYear = 3,
                    VestingRulesPercentage = 50,
                },
                new VestingRules
                {
                    Id = 2,
                    FromYear = 3,
                    ToYear = 4,
                    VestingRulesPercentage = 65,
                },
                new VestingRules
                {
                    Id = 3,
                    FromYear = 4,
                    ToYear = 5,
                    VestingRulesPercentage = 85,
                },
                new VestingRules
                {
                    Id = 4,
                    FromYear = 5,
                    ToYear = 0,
                    VestingRulesPercentage = 100,
                });

            modelBuilder.Entity<PensionEnrollmentRules>().HasData(
                new PensionEnrollmentRules
                { 
                    Id = 1,
                    Band = "S",
                    NumberOfMonthsToEnrollment = 0
                },
                new PensionEnrollmentRules
                {
                    Id = 2,
                    Band = "E",
                    NumberOfMonthsToEnrollment = 3
                },
                new PensionEnrollmentRules
                {
                    Id = 3,
                    Band = "F",
                    NumberOfMonthsToEnrollment = 3
                },
                new PensionEnrollmentRules
                {
                    Id = 4,
                    Band = "G",
                    NumberOfMonthsToEnrollment = 24
                },
                new PensionEnrollmentRules
                {
                    Id = 5,
                    Band = "H",
                    NumberOfMonthsToEnrollment = 24
                }
            );

            modelBuilder.Entity<AppSetting>().HasData(
                new AppSetting
                {
                    Id = 1,
                    Name = "Max Percent Withdrawal",
                    Key = "MaxPercentWithdrawal",
                    Value = "65"
                });
        }
    }
}
