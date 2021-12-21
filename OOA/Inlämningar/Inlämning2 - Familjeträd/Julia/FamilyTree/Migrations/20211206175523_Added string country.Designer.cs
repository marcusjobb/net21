﻿// <auto-generated />
using System;
using FamilyTree.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyTree.Migrations
{
    [DbContext(typeof(FamilyContext))]
    [Migration("20211206175523_Added string country")]
    partial class Addedstringcountry
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FamilyTree.Models.BirthPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BirthPlaces");
                });

            modelBuilder.Entity("FamilyTree.Models.DeathPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DeathPlaces");
                });

            modelBuilder.Entity("FamilyTree.Models.Person", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BirthPlaceId")
                        .HasColumnType("int");

                    b.Property<string>("DeathDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DeathPlaceId")
                        .HasColumnType("int");

                    b.Property<int?>("FatherId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MotherId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BirthPlaceId");

                    b.HasIndex("DeathPlaceId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("FamilyTree.Models.Person", b =>
                {
                    b.HasOne("FamilyTree.Models.BirthPlace", "BirthPlace")
                        .WithMany("People")
                        .HasForeignKey("BirthPlaceId");

                    b.HasOne("FamilyTree.Models.DeathPlace", "DeathPlace")
                        .WithMany("People")
                        .HasForeignKey("DeathPlaceId");

                    b.Navigation("BirthPlace");

                    b.Navigation("DeathPlace");
                });

            modelBuilder.Entity("FamilyTree.Models.BirthPlace", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("FamilyTree.Models.DeathPlace", b =>
                {
                    b.Navigation("People");
                });
#pragma warning restore 612, 618
        }
    }
}
