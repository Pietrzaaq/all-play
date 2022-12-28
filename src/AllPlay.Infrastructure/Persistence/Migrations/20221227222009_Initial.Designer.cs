﻿// <auto-generated />
using System;
using AllPlay.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AllPlay.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(AllPlayDbContext))]
    [Migration("20221227222009_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AllPlay.Domain.Entities.Game.Player", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MarkerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.HasIndex("MarkerId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Map.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Map.Marker", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SportType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Markers");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Game.Player", b =>
                {
                    b.HasOne("AllPlay.Domain.Entities.Map.Marker", null)
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllPlay.Domain.Entities.Map.Marker", null)
                        .WithMany("Players")
                        .HasForeignKey("MarkerId");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Map.Area", b =>
                {
                    b.OwnsOne("AllPlay.Domain.Entities.Map.Coordinates", "Coordinates", b1 =>
                        {
                            b1.Property<Guid>("AreaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float")
                                .HasColumnName("Latitude");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float")
                                .HasColumnName("Longitude");

                            b1.HasKey("AreaId");

                            b1.ToTable("Areas");

                            b1.WithOwner()
                                .HasForeignKey("AreaId");
                        });

                    b.Navigation("Coordinates");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Map.Marker", b =>
                {
                    b.HasOne("AllPlay.Domain.Entities.Map.Area", "Area")
                        .WithMany("Markers")
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AllPlay.Domain.Entities.Map.Area", null)
                        .WithMany()
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Map.Area", b =>
                {
                    b.Navigation("Markers");
                });

            modelBuilder.Entity("AllPlay.Domain.Entities.Map.Marker", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
