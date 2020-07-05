using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
    public class VestingRulesHistoryMap
    {
        public VestingRulesHistoryMap(EntityTypeBuilder<VestingRulesHistory> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(t => t.FromYearBefore).IsRequired();
            entityBuilder.Property(t => t.ToYearBefore).IsRequired();
            entityBuilder.Property(t => t.VestingPercentageBefore).IsRequired();
            entityBuilder.Property(t => t.FromYearAfter).IsRequired();
            entityBuilder.Property(t => t.ToYearAfter).IsRequired();
            entityBuilder.Property(t => t.VestingPercentageAfter).IsRequired();
            //entityBuilder.Property(t => t.UpdatedBy).IsRequired();
            entityBuilder.Property(t => t.UpdatedOn).IsRequired();
        }
    }
}
