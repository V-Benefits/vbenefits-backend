using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class RatePlanRulesMap
    {
        public RatePlanRulesMap(EntityTypeBuilder<RatePlanRules> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(t => t.Band).IsRequired();
            entityBuilder.Property(t => t.RatePlan).IsRequired();
        }
    }
}
