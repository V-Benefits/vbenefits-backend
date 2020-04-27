using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class HistoricalMetlifeDataMap
    {
        public HistoricalMetlifeDataMap(EntityTypeBuilder<HistoricalMetlifeData> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.StaffId).IsRequired();
            entityBuilder.Property(t => t.HiringDate).HasColumnType("date");
            entityBuilder.Property(t => t.UpdatedHiringDate).HasColumnType("date");
        }
    }
}
