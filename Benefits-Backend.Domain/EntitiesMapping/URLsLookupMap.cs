using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class URLsLookupMap
    {
        public URLsLookupMap(EntityTypeBuilder<URLsLookup> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Key).IsRequired();
            entityBuilder.Property(t => t.Value).IsRequired();
        }
    }
}
