using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Benefits_Backend.Domain.EntitiesMapping
{
   public class MedicalCardRequestForSpouseMap
    {
        public MedicalCardRequestForSpouseMap(EntityTypeBuilder<MedicalCardRequestForSpouse> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
        }
    }
}
