using Benefits_Backend_Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benefits_Backend_Core.Domain.EntitiesMapping
{
   public class MedicalCardRequestForEmployeeMap
    {
        public MedicalCardRequestForEmployeeMap(EntityTypeBuilder<MedicalCardRequestForEmployee> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
        }
    }
}
