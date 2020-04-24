﻿// <auto-generated />
using System;
using Benefits_Backend.Domain.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Benefits_Backend.Domain.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("LandlineNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.HistoricalMetlifeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CERT")
                        .HasColumnType("int");

                    b.Property<float>("Contribution")
                        .HasColumnType("real");

                    b.Property<float>("Income")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NewBalance")
                        .HasColumnType("real");

                    b.Property<float>("OldBalance")
                        .HasColumnType("real");

                    b.Property<float>("Withdrawals")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("historicalMetlifeData");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.MetlifeData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CERT")
                        .HasColumnType("int");

                    b.Property<float>("Contribution")
                        .HasColumnType("real");

                    b.Property<float>("Income")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("NewBalance")
                        .HasColumnType("real");

                    b.Property<float>("OldBalance")
                        .HasColumnType("real");

                    b.Property<float>("Withdrawals")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("metlifeData");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PhoneProgramRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RequestById")
                        .HasColumnType("int");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestFor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RequestById");

                    b.ToTable("PhoneProgramRequests");
                });

            modelBuilder.Entity("Benefits_Backend.Domain.Entities.PhoneProgramRequest", b =>
                {
                    b.HasOne("Benefits_Backend.Domain.Entities.Employee", "RequestBy")
                        .WithMany()
                        .HasForeignKey("RequestById")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
