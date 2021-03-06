﻿using Benefits_Backend.Domain.Entities;
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

            new VestingRulesMap(modelBuilder.Entity<VestingRules>());
            new VestingRulesHistoryMap(modelBuilder.Entity<VestingRulesHistory>());
            new RoundDateMap(modelBuilder.Entity<RoundDate>());
            new PhoneProgramRequestMap(modelBuilder.Entity<PhoneProgramRequest>());
            new PensionEnrollmentRulesMap(modelBuilder.Entity<PensionEnrollmentRules>());
            new PensionEnrollmentRulesHistoryMap(modelBuilder.Entity<PensionEnrollmentRulesHistory>());
            new MetlifeDataMap(modelBuilder.Entity<MetlifeData>());
            new HistoricalMetlifeDataMap(modelBuilder.Entity<HistoricalMetlifeData>());
            new MedicalCardRequestForEmployeeMap(modelBuilder.Entity<MedicalCardRequestForEmployee>());
            new MedicalCardRequestForSpouseMap(modelBuilder.Entity<MedicalCardRequestForSpouse>());
            new AppSettingMap(modelBuilder.Entity<AppSetting>());
            new AppSettingHistoriesMap(modelBuilder.Entity<AppSeetingHistory>());
            new URLsLookupMap(modelBuilder.Entity<URLsLookup>());

            new RatePlanRulesMap(modelBuilder.Entity<RatePlanRules>());
            new RequestForLookupMap(modelBuilder.Entity<RequestForLookup>());
            new RatePlanTypeLookupMap(modelBuilder.Entity<RatePlanTypeLookup>());
            new SIMCardRequestMap(modelBuilder.Entity<SIMCardRequest>());

            modelBuilder.Seed();
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PhoneProgramRequest> PhoneProgramRequests { get; set; }
        public DbSet<VestingRules> VestingRules { get; set; }
        public DbSet<PensionEnrollmentRules> PensionEnrollmentRules { get; set; }
        public DbSet<PensionEnrollmentRulesHistory> PensionEnrollmentRulesHistories { get; set; }
        public DbSet<VestingRulesHistory> VestingRulesHistories { get; set; }
        public DbSet<MetlifeData> metlifeData { get; set; }
        public DbSet<HistoricalMetlifeData> historicalMetlifeData { get; set; }
        public DbSet<PensionRequest> PensionRequests { get; set; }
        public DbSet<AppSetting> AppSettings { get; set; }
        public DbSet<RoundDate> RoundDates { get; set; }
        public DbSet<SuccessFactor> SuccessFactor { get; set; }
        public DbSet<MedicalCardRequestForEmployee> medicalCardRequestForEmployees  { get; set; }
        public DbSet<MedicalCardRequestForSpouse> medicalCardRequestForSpouses  { get; set; }
        public DbSet<MedicalCardRequest> medicalCardRequests { get; set; }
        public DbSet<URLsLookup> URLsLookups { get; set; }
        public DbSet<RatePlanRules> RatePlanRules { get; set; }
        public DbSet<RequestForLookup> RequestForLookups { get; set; }
        public DbSet<RatePlanTypeLookup> RatePlanTypeLookups { get; set; }
        public DbSet<SIMCardRequest> SIMCardRequests { get; set; }
        public DbSet<RequestTypeLookup> RequestTypeLookups { get; set; }

    }

}
