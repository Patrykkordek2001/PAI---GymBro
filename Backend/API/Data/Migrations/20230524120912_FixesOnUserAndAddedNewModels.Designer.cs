﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230524120912_FixesOnUserAndAddedNewModels")]
    partial class FixesOnUserAndAddedNewModels
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("API.Models.Excercise", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfRepetitions")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfSeries")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Excercises");
                });

            modelBuilder.Entity("API.Models.Measurement", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Arms")
                        .HasColumnType("float");

                    b.Property<double>("Chest")
                        .HasColumnType("float");

                    b.Property<double>("Hips")
                        .HasColumnType("float");

                    b.Property<DateTime>("MeasurementDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Thighs")
                        .HasColumnType("float");

                    b.Property<double>("Waist")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Measurements");
                });

            modelBuilder.Entity("API.Models.Workout", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExcerciseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ExerciseID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("WorkoutDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ExcerciseId");

                    b.ToTable("Workouts");
                });

            modelBuilder.Entity("API.Models.Workout", b =>
                {
                    b.HasOne("API.Models.Excercise", "Excercise")
                        .WithMany("Workouts")
                        .HasForeignKey("ExcerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Excercise");
                });

            modelBuilder.Entity("API.Models.Excercise", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
