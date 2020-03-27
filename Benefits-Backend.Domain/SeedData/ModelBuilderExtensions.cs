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
            //modelBuilder.Entity<Employee>().HasData(
            //        new Employee
            //        {
            //            Id = 1,
            //            Name = "Agamy",
            //            Email = "agamy@pragimtech.com"
            //        }
            //    );
        }
    }
}
