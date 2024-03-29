﻿// <auto-generated />
using System;
using EF_Genealogy.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_Genealogy.Migrations
{
    [DbContext(typeof(GenealogyContext))]
    [Migration("20211205174701_DataBaseGeneratedOptionIdentityTest")]
    partial class DataBaseGeneratedOptionIdentityTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Genealogy.Models.HistoricalEvent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventDate")
                        .HasColumnType("int");

                    b.Property<string>("EventDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EventLocationID")
                        .HasColumnType("int");

                    b.Property<int?>("EventPersonID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EventLocationID");

                    b.HasIndex("EventPersonID");

                    b.ToTable("LifeEvents");
                });

            modelBuilder.Entity("EF_Genealogy.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeathDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeathLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FatherID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaidenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotherID")
                        .HasColumnType("int");

                    b.Property<int?>("SpouseID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SpouseID")
                        .IsUnique()
                        .HasFilter("[SpouseID] IS NOT NULL");

                    b.ToTable("People");
                });

            modelBuilder.Entity("EF_Genealogy.Models.Place", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("EF_Genealogy.Models.Spouse", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("ID");

                    b.ToTable("Spouse");
                });

            modelBuilder.Entity("EF_Genealogy.Models.HistoricalEvent", b =>
                {
                    b.HasOne("EF_Genealogy.Models.Place", "EventLocation")
                        .WithMany()
                        .HasForeignKey("EventLocationID");

                    b.HasOne("EF_Genealogy.Models.Person", "EventPerson")
                        .WithMany("PersonHistory")
                        .HasForeignKey("EventPersonID");

                    b.Navigation("EventLocation");

                    b.Navigation("EventPerson");
                });

            modelBuilder.Entity("EF_Genealogy.Models.Person", b =>
                {
                    b.HasOne("EF_Genealogy.Models.Spouse", "Spouse")
                        .WithOne("SpouseX")
                        .HasForeignKey("EF_Genealogy.Models.Person", "SpouseID");

                    b.Navigation("Spouse");
                });

            modelBuilder.Entity("EF_Genealogy.Models.Person", b =>
                {
                    b.Navigation("PersonHistory");
                });

            modelBuilder.Entity("EF_Genealogy.Models.Spouse", b =>
                {
                    b.Navigation("SpouseX");
                });
#pragma warning restore 612, 618
        }
    }
}
