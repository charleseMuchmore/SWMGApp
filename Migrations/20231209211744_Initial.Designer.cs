﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheboisGaming.Data;

#nullable disable

namespace SWMGApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231209211744_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SWMGApp.Models.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CompanyId");

                    b.HasIndex("IndustryId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("SWMGApp.Models.Help", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Datetime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Msg")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Help");
                });

            modelBuilder.Entity("SWMGApp.Models.Industry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AvgWage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("minEducation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Industries");
                });

            modelBuilder.Entity("SWMGApp.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AvgWage")
                        .HasColumnType("int");

                    b.Property<int>("IndustryId")
                        .HasColumnType("int");

                    b.Property<string>("JobName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("JobId");

                    b.HasIndex("IndustryId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("SWMGApp.Models.Newsletter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Newsletters");
                });

            modelBuilder.Entity("SWMGApp.Models.Company", b =>
                {
                    b.HasOne("SWMGApp.Models.Industry", null)
                        .WithMany("Companies")
                        .HasForeignKey("IndustryId");
                });

            modelBuilder.Entity("SWMGApp.Models.Job", b =>
                {
                    b.HasOne("SWMGApp.Models.Industry", "Industry")
                        .WithMany()
                        .HasForeignKey("IndustryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Industry");
                });

            modelBuilder.Entity("SWMGApp.Models.Industry", b =>
                {
                    b.Navigation("Companies");
                });
#pragma warning restore 612, 618
        }
    }
}
