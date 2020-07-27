using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class RequestForLookupMap
    {
        public RequestForLookupMap(EntityTypeBuilder<RequestForLookup> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Value).IsRequired();
        }
    }
}
