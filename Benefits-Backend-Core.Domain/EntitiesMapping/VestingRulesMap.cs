using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
    public class VestingRulesMap
    {
        public VestingRulesMap(EntityTypeBuilder<VestingRules> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(t => t.FromYear).IsRequired();
            entityBuilder.Property(t => t.ToYear).IsRequired();
        }
    }
}
