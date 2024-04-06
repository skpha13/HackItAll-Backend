﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace HackItAllBackend.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240406105846_CreatedModels")]
    partial class CreatedModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HackItAll_Backend.Models.Battery", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<int>("capacity")
                        .HasColumnType("int");

                    b.Property<int>("maxCapacity")
                        .HasColumnType("int");

                    b.Property<Guid>("modelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.Property<Guid>("stationId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("modelId");

                    b.HasIndex("stationId");

                    b.ToTable("Batteries");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Car", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("batteryModelId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("batteryModelId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Model", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Models");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Station", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("chargingStations")
                        .HasColumnType("int");

                    b.Property<float>("coordinateX")
                        .HasColumnType("real");

                    b.Property<float>("coordinateY")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Stations");
                });

            modelBuilder.Entity("backend.Models.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Battery", b =>
                {
                    b.HasOne("HackItAll_Backend.Models.Model", "model")
                        .WithMany("batteries")
                        .HasForeignKey("modelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HackItAll_Backend.Models.Station", "station")
                        .WithMany("batteries")
                        .HasForeignKey("stationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("model");

                    b.Navigation("station");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Car", b =>
                {
                    b.HasOne("HackItAll_Backend.Models.Model", "batteryModel")
                        .WithMany("cars")
                        .HasForeignKey("batteryModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("batteryModel");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Model", b =>
                {
                    b.Navigation("batteries");

                    b.Navigation("cars");
                });

            modelBuilder.Entity("HackItAll_Backend.Models.Station", b =>
                {
                    b.Navigation("batteries");
                });
#pragma warning restore 612, 618
        }
    }
}
