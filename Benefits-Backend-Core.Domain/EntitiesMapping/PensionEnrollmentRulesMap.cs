using System;
using System.Collections.Generic;
using System.Text;
using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
    public class PensionEnrollmentRulesMap
    {
        public PensionEnrollmentRulesMap(EntityTypeBuilder<PensionEnrollmentRules> entityBuilder)
        {
            entityBuilder.HasKey(p => p.Id);
            entityBuilder.Property(p => p.Band).IsRequired();
            entityBuilder.Property(t => t.NumberOfMonthsToEnrollment).IsRequired();
        }
    }

}
