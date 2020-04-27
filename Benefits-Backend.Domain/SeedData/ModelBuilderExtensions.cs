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
        }
    }
}
