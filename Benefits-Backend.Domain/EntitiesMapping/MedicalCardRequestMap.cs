using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class MedicalCardRequestMap
    {
        public MedicalCardRequestMap(EntityTypeBuilder<MedicalCardRequest> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
        }
    }
}
