using Benefits_Backend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Benefits_Backend.Domain.EntitiesMapping
{
    public class PensionRequestMap
    {
        public PensionRequestMap(EntityTypeBuilder<PensionRequest> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.WithdrawalAmmount).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.BeginingBalance).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.CurrentyearContribution).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.VestingPercent).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.LastRoundWithdrawal).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.ProratedNewContribution).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.CurrentAvailableBalance).IsRequired().HasColumnType("decimal(18,4)");
            entityBuilder.Property(t => t.MaxWithdrawalAmount).IsRequired().HasColumnType("decimal(18,4)"); 
            entityBuilder.Property(t => t.YearsOfService).IsRequired();
            entityBuilder.Property(t => t.RequestedOn).HasColumnType("date");

            //entityBuilder.HasOne<Employee>(p => p.ApprovedBy)
            //    .WithMany()
            //    .HasForeignKey(p => p.ApprovedById);

            entityBuilder.HasOne<Employee>(p => p.RequestedBy)
                .WithMany(e => e.PensionRequests)
                .HasForeignKey(p => p.RequestedById);

            //entityBuilder.HasOne<Employee>(p => p.RejectedBy)
            //    .WithMany()
            //    .HasForeignKey(p => p.RejectedById);

            //modelBuilder.Entity<User>()
            //.HasOptional(u => u.Creator)     // or HasRequired
            //.WithMany();

            //modelBuilder.Entity<User>()
            //.HasOptional(u => u.LastEditor)  // or HasRequired
            //.WithMany();

            //modelBuilder.Entity<Team>().HasMany(t => t.HomeGames)
            //.WithOne(g => g.HomeTeam)
            //.HasForeignKey(g => g.HomeTeamId);
            //modelBuilder.Entity<Team>().HasMany(t => t.AwayGames)
            //.WithOne(g => g.AwayTeam)
            //.HasForeignKey(g => g.AwayTeamId).OnDelete(DeleteBehavior.Restrict);



            // TO BE DECIDED....  
            //entityBuilder.Property(t => t.isActive).IsRequired();
            //entityBuilder.Property(t => t.isApproved).IsRequired();
            //ApprovedBy
            //ApprovedOn
            //RejectedBy
            //RejectedOn


        }
    }
}
