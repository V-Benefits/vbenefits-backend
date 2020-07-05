using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
    public class PhoneProgramRequestMap
    {
        public PhoneProgramRequestMap(EntityTypeBuilder<PhoneProgramRequest> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            //entityBuilder.Property(t => t.RequestBy).IsRequired();
            entityBuilder.Property(t => t.RequestFor).IsRequired();
            entityBuilder.Property(t => t.RequestDate).IsRequired().HasColumnType("date");
            
        }
    }
}
