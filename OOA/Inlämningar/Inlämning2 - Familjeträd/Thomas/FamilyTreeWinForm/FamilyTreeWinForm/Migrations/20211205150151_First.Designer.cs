﻿// <auto-generated />
using System;
using FamilyTreeWF.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyTreeWF.Migrations
{
    [DbContext(typeof(DbAccess))]
    [Migration("20211205150151_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FamilyTreeWF.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("FamilyTreeWF.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("FamilyTreeWF.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonId"), 1L, 1);

                    b.Property<int?>("BirthCityId")
                        .HasColumnType("int");

                    b.Property<int?>("BirthCountryId")
                        .HasColumnType("int");

                    b.Property<int>("BirthYear")
                        .HasColumnType("int");

                    b.Property<int?>("DeathCityId")
                        .HasColumnType("int");

                    b.Property<int?>("DeathCountryId")
                        .HasColumnType("int");

                    b.Property<int?>("DeathYear")
                        .HasColumnType("int");

                    b.Property<int?>("FatherId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("MotherId")
                        .HasColumnType("int");

                    b.HasKey("PersonId");

                    b.HasIndex("BirthCityId");

                    b.HasIndex("BirthCountryId");

                    b.HasIndex("DeathCityId");

                    b.HasIndex("DeathCountryId");

                    b.HasIndex("FatherId");

                    b.HasIndex("MotherId");

                    b.ToTable("People");
                });

            modelBuilder.Entity("FamilyTreeWF.Models.Person", b =>
                {
                    b.HasOne("FamilyTreeWF.Models.City", "BirthCity")
                        .WithMany("PeopleBorn")
                        .HasForeignKey("BirthCityId");

                    b.HasOne("FamilyTreeWF.Models.Country", "BirthCountry")
                        .WithMany("PeopleBorn")
                        .HasForeignKey("BirthCountryId");

                    b.HasOne("FamilyTreeWF.Models.City", "DeathCity")
                        .WithMany("PeopleDead")
                        .HasForeignKey("DeathCityId");

                    b.HasOne("FamilyTreeWF.Models.Country", "DeathCountry")
                        .WithMany("PeopleDead")
                        .HasForeignKey("DeathCountryId");

                    b.HasOne("FamilyTreeWF.Models.Person", "Father")
                        .WithMany()
                        .HasForeignKey("FatherId");

                    b.HasOne("FamilyTreeWF.Models.Person", "Mother")
                        .WithMany()
                        .HasForeignKey("MotherId");

                    b.Navigation("BirthCity");

                    b.Navigation("BirthCountry");

                    b.Navigation("DeathCity");

                    b.Navigation("DeathCountry");

                    b.Navigation("Father");

                    b.Navigation("Mother");
                });

            modelBuilder.Entity("FamilyTreeWF.Models.City", b =>
                {
                    b.Navigation("PeopleBorn");

                    b.Navigation("PeopleDead");
                });

            modelBuilder.Entity("FamilyTreeWF.Models.Country", b =>
                {
                    b.Navigation("PeopleBorn");

                    b.Navigation("PeopleDead");
                });
#pragma warning restore 612, 618
        }
    }
}
