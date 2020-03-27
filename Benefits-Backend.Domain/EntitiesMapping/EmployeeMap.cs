using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Benefits_Backend.Domain.EntitiesMapping
{
    public class EmployeeMap
    {
        public EmployeeMap(EntityTypeBuilder<Employee> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.StaffId).IsRequired();
            entityBuilder.Property(t => t.DateOfBirth).HasColumnType("date");
        }
    }
}
