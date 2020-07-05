using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
    public class AppSettingHistoriesMap
    {
        public AppSettingHistoriesMap(EntityTypeBuilder<AppSeetingHistory> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Key).IsRequired();
            entityBuilder.Property(t => t.OldValue).IsRequired();
            entityBuilder.Property(t => t.NewValue).IsRequired();

            entityBuilder.Property(t => t.ChangedOn).HasColumnType("date");
            entityBuilder.HasOne<Employee>(p => p.ChangedBy)
                    .WithMany()
                    .HasForeignKey(p => p.ChangedById);

            entityBuilder.HasOne<AppSetting>(p => p.AppSetting)
                    .WithMany(a=> a.AppSeetingHistories)
                    .HasForeignKey(p => p.AppSettingId);
        }
    }
}
