using Benefits_Backend.Domain.Entities;
using Benefits_Backend.Domain.EntitiesMapping;
using Benefits_Backend.Domain.SeedData;
using Microsoft.EntityFrameworkCore;

namespace Benefits_Backend.Domain.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new EmployeeMap(modelBuilder.Entity<Employee>());
            new PensionRequestMap(modelBuilder.Entity<PensionRequest>());

            modelBuilder.Seed();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PhoneProgramRequest> PhoneProgramRequests { get; set; }

        public DbSet<MetlifeData> metlifeData { get; set; }
        public DbSet<HistoricalMetlifeData> historicalMetlifeData { get; set; }

        public DbSet<PensionRequest> PensionRequests { get; set; }
    }

}
