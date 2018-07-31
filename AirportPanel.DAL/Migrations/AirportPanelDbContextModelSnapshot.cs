﻿// <auto-generated />
using System;
using AirportPanel.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirportPanel.DAL.Migrations
{
    [DbContext(typeof(AirportPanelDbContext))]
    partial class AirportPanelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirportPanel.Model.EntityModels.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("ArrivalOn");

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime?>("DepartureOn");

                    b.Property<byte>("FlightType");

                    b.Property<Guid>("MofidiedBy");

                    b.Property<DateTime?>("MofidiedOn");

                    b.Property<string>("Number");

                    b.Property<int?>("StatusId");

                    b.HasKey("Id");

                    b.HasIndex("StatusId");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("AirportPanel.Model.EntityModels.FlightStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid>("CreatedBy");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Discription");

                    b.Property<Guid>("MofidiedBy");

                    b.Property<DateTime?>("MofidiedOn");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("FlightStatuses");
                });

            modelBuilder.Entity("AirportPanel.Model.EntityModels.Flight", b =>
                {
                    b.HasOne("AirportPanel.Model.EntityModels.FlightStatus", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
