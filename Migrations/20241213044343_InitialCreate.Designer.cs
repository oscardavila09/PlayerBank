﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayerBank.Models;

#nullable disable

namespace PlayerBank.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241213044343_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("PlayerBank.Models.Athlete", b =>
                {
                    b.Property<int>("AthleteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CollegeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Sport")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AthleteID");

                    b.HasIndex("CollegeID");

                    b.ToTable("Athletes");
                });

            modelBuilder.Entity("PlayerBank.Models.College", b =>
                {
                    b.Property<int>("CollegeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CollegeCity")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CollegeState")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CollegeID");

                    b.ToTable("Colleges");
                });

            modelBuilder.Entity("PlayerBank.Models.Athlete", b =>
                {
                    b.HasOne("PlayerBank.Models.College", "College")
                        .WithMany("Athletes")
                        .HasForeignKey("CollegeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("College");
                });

            modelBuilder.Entity("PlayerBank.Models.College", b =>
                {
                    b.Navigation("Athletes");
                });
#pragma warning restore 612, 618
        }
    }
}
