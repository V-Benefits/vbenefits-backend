using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class PensionEnrollmentRulesHistoryMap
    {
        public PensionEnrollmentRulesHistoryMap(EntityTypeBuilder<PensionEnrollmentRulesHistory> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.BandBefore).IsRequired();
            entityBuilder.Property(t => t.NumberOfMonthsToEnrollmentBefore).IsRequired();
            entityBuilder.Property(p => p.BandAfter).IsRequired();
            entityBuilder.Property(t => t.NumberOfMonthsToEnrollmentAfter).IsRequired();
            //entityBuilder.Property(t => t.UpdatedBy).IsRequired();
            entityBuilder.Property(t => t.UpdatedOn).IsRequired().HasColumnType("date");
        }
    }
}
