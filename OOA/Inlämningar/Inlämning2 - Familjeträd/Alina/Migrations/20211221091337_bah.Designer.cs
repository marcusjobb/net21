﻿// <auto-generated />
using System;
using Genealogy_Tree.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Genealogy_Tree.Migrations
{
    [DbContext(typeof(ADGenealogy))]
    [Migration("20211221091337_bah")]
    partial class bah
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Genealogy_Tree.Models.Monarchy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Monarchies");
                });

            modelBuilder.Entity("Genealogy_Tree.Models.MonarchyMember", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BirthDate")
                        .HasColumnType("int");

                    b.Property<int>("DeathDate")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MonarchyId")
                        .HasColumnType("int");

                    b.HasKey("PersonID");

                    b.HasIndex("MonarchyId");

                    b.ToTable("MonarchyMembers");
                });

            modelBuilder.Entity("MonarchyMemberMonarchyMember", b =>
                {
                    b.Property<int>("ChildrenPersonID")
                        .HasColumnType("int");

                    b.Property<int>("ParentsPersonID")
                        .HasColumnType("int");

                    b.HasKey("ChildrenPersonID", "ParentsPersonID");

                    b.HasIndex("ParentsPersonID");

                    b.ToTable("MonarchyMemberMonarchyMember");
                });

            modelBuilder.Entity("Genealogy_Tree.Models.MonarchyMember", b =>
                {
                    b.HasOne("Genealogy_Tree.Models.Monarchy", "Monarchy")
                        .WithMany("Members")
                        .HasForeignKey("MonarchyId");

                    b.Navigation("Monarchy");
                });

            modelBuilder.Entity("MonarchyMemberMonarchyMember", b =>
                {
                    b.HasOne("Genealogy_Tree.Models.MonarchyMember", null)
                        .WithMany()
                        .HasForeignKey("ChildrenPersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Genealogy_Tree.Models.MonarchyMember", null)
                        .WithMany()
                        .HasForeignKey("ParentsPersonID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Genealogy_Tree.Models.Monarchy", b =>
                {
                    b.Navigation("Members");
                });
#pragma warning restore 612, 618
        }
    }
}
