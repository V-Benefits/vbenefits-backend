using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
   public class MetlifeDataMap
    {
        public MetlifeDataMap(EntityTypeBuilder<MetlifeData> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.OldBalance).HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.Contribution).HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.Income).HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.Withdrawals).HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.NewBalance).HasColumnType("decimal(18,4)");
        }
    }
}
