using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class RoundDateMap
    {
        public RoundDateMap(EntityTypeBuilder<RoundDate> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.RoundName).IsRequired();
            entityBuilder.Property(t => t.StartDate).HasColumnType("date");
            entityBuilder.Property(t => t.EndDate).HasColumnType("date");
            entityBuilder.Property(t => t.Year).IsRequired();

        }
    }
}
