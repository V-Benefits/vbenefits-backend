using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
    public class AppSettingMap
    {
        public AppSettingMap(EntityTypeBuilder<AppSetting> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Key).IsRequired();
            entityBuilder.Property(t => t.Value).IsRequired();

        }
    }
}
