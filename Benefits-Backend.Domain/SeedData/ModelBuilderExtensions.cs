﻿using Benefits_Backend.Domain.Entities;
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
                        StaffId = 26018,
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
                        StaffId = 26782,
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
                        StaffId = 28896,
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

            modelBuilder.Entity<URLsLookup>().HasData(
            new URLsLookup
            {
                Id = 1,
                Key = "PensionPolicyURL",
                Value = ""
            },
             new URLsLookup
             {
                 Id = 2,
                 Key = "PensionPolicyFilePath",
                 Value = ""
             }
            );

            modelBuilder.Entity<MetlifeData>().HasData(
                 new MetlifeData
                 {
                     Id = 1,
                     Name = "MAHMOUD, ASHRAF",
                     CERT = 20,
                     OldBalance = 52793.4m,
                     Contribution = 85299.64m,
                     Income = 4233.757m,
                     Withdrawals = 0,
                     NewBalance = 142326.8m
                 },
                 new MetlifeData
                 {
                     Id = 2,
                     Name = "Abdallah Fekry Kenawy, Abdullah Mahmoud",
                     CERT = 30,
                     OldBalance = 25658.55m,
                     Contribution = 15439.77m,
                     Income = 1277.134m,
                     Withdrawals = 9175,
                     NewBalance = 33200.45m
                 },
                 new MetlifeData
                 {
                     Id = 3,
                     Name = "Mona",
                     CERT = 2,
                     OldBalance = 52793.40m,
                     Contribution = 85299.64m,
                     Income = 4233.76m,
                     Withdrawals = 0,
                     NewBalance = 142326.80m
                 },
                   new MetlifeData
                   {
                       Id = 4,
                       Name = "Ziad",
                       CERT = 3,
                       OldBalance = 168140m,
                       Contribution = 89238m,
                       Income = 9438m,
                       Withdrawals = 0,
                       NewBalance = 237070m
                   },
                   new MetlifeData
                   {
                       Id = 5,
                       Name = "Mohamed AlMokadem",
                       CERT = 26018,
                       OldBalance = 168140m,
                       Contribution = 89238m,
                       Income = 9438m,
                       Withdrawals = 0,
                       NewBalance = 237070m
                   }
             );

            modelBuilder.Entity<RoundDate>().HasData(
                new RoundDate
                {
                    Id = 1,
                    IsActive = true,
                    StartDate = new DateTime(2020, 7, 1),
                    EndDate = new DateTime(2020, 7, 30),
                    RoundName = "July 2020"
                });

            modelBuilder.Entity<RequestForLookup>().HasData(
                new RequestForLookup
                {
                    Id = 1,
                    Value = "Myself"
                },
                new RequestForLookup
                {
                    Id = 2,
                    Value = "Family or friends ( deductible from salary)"
                });

            modelBuilder.Entity<RatePlanRules>().HasData(
             new RatePlanRules
             {
                 Id = 1,
                 Number = 1,
                 Band = "Contractor",
                 RatePlan = "Flex 65",
                 BundleType ="Employee Line"
             },
             new RatePlanRules
             {
                 Id = 2,
                 Number = 2,
                 Band = "G2",
                 RatePlan = "Red 150",
                 BundleType = "Employee Line"
             },
             new RatePlanRules
             {
                 Id = 3,
                 Number = 2,
                 Band = "H1",
                 RatePlan = "Red 150",
                 BundleType = "Employee Line"
             },
            new RatePlanRules
            {
                Id = 4,
                Number = 2,
                Band = "H2",
                RatePlan = "Red 150",
                BundleType = "Employee Line"
            },
            new RatePlanRules
            {
                Id = 5,
                Number = 3,
                Band = "G1",
                RatePlan = "Red 300",
                BundleType = "Employee Line"
            },
            new RatePlanRules
            {
                Id = 6,
                Number = 4,
                Band = "F",
                RatePlan = "Red 500",
                BundleType = "Employee Line"
            },
            new RatePlanRules
            {
                Id = 7,
                Number = 5,
                Band = "E",
                RatePlan = "Red 800",
                BundleType = "Employee Line"
            },
            new RatePlanRules
            {
                Id = 8,
                Number = 1,
                Band = "H",
                RatePlan = "20 GB",
                BundleType = "Employee Data"
            },
            new RatePlanRules
            {
                Id = 9,
                Number = 1,
                Band = "G",
                RatePlan = "20 GB",
                BundleType = "Employee Data"
            },
            new RatePlanRules
            {
                Id = 10,
                Number = 1,
                Band = "Contractors",
                RatePlan = "20 GB",
                BundleType = "Employee Data"
            },
            new RatePlanRules
            {
                Id = 11,
                Number = 2,
                Band = "F",
                RatePlan = "40 GB",
                BundleType = "Employee Data"
            },
            new RatePlanRules
            {
                Id = 12,
                Number = 2,
                Band = "E",
                RatePlan = "40 GB",
                BundleType = "Employee Data"
            });

            modelBuilder.Entity<RequestTypeLookup>().HasData(
            new RequestTypeLookup
            {
                Id = 1,
                Value = "New Line",
                RequestForId = 2 
            },
            new RequestTypeLookup
            {
                Id = 2,
                Value = "New Line",
                RequestForId = 1
            },
            new RequestTypeLookup
            {
                Id = 3,
                Value = "New Data SIM",
                RequestForId = 1
            },
            new RequestTypeLookup
            {
                Id = 4,
                Value = "Change Line Rate Plan",
                RequestForId = 1
            },
            new RequestTypeLookup
            {
                Id = 5,
                Value = "Recharge Your Line",
                RequestForId = 1
            }, 
            new RequestTypeLookup
            {
                Id = 6,
                Value = "Change Your Data SIM",
                RequestForId = 1
            },
            new RequestTypeLookup
            {
                Id = 7,
                Value = "Recharge Your Data SIM",
                RequestForId = 1
            });
        }
    }
}
