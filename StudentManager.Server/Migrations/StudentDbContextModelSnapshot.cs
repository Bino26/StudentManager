﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentManager.Server.Data;

#nullable disable

namespace StudentManager.Server.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SharedLibrary.Models.Entity.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6b0f3027-9339-4a90-af53-c4e13d1c8498"),
                            Class = "4A",
                            Email = "alice.dupont@collegesjb.com",
                            Name = "Alice Dupont"
                        },
                        new
                        {
                            Id = new Guid("016dc937-47b0-4fa8-900d-b73b60af84ee"),
                            Class = "5B",
                            Email = "marc.durand@collegesjb.com",
                            Name = "Marc Durand"
                        },
                        new
                        {
                            Id = new Guid("8b26b4b9-e3d3-4a51-bc78-af192f8c702c"),
                            Class = "3C",
                            Email = "julie.martin@collegesjb.com",
                            Name = "Julie Martin"
                        },
                        new
                        {
                            Id = new Guid("610fa24c-f80c-4bbe-811c-e3f5414b4662"),
                            Class = "2D",
                            Email = "pierre.dubois@collegesjb.com",
                            Name = "Pierre Dubois"
                        },
                        new
                        {
                            Id = new Guid("6a9b245a-e75b-4ed8-bc83-d2d9a87a9dec"),
                            Class = "1A",
                            Email = "sophie.lefevre@collegesjb.com",
                            Name = "Sophie Lefevre"
                        },
                        new
                        {
                            Id = new Guid("545ff6bb-4280-49d1-b26b-f654ee9384c2"),
                            Class = "4B",
                            Email = "paul.moreau@collegesjb.com",
                            Name = "Paul Moreau"
                        },
                        new
                        {
                            Id = new Guid("3e3af6c9-3298-446e-8e80-18f012799609"),
                            Class = "5C",
                            Email = "lucie.petit@collegesjb.com",
                            Name = "Lucie Petit"
                        },
                        new
                        {
                            Id = new Guid("6404eb46-b625-495d-8447-cdd3ed665339"),
                            Class = "3A",
                            Email = "thomas.richard@collegesjb.com",
                            Name = "Thomas Richard"
                        },
                        new
                        {
                            Id = new Guid("4bdfa2fd-92bc-4df0-a360-cd253711f488"),
                            Class = "2B",
                            Email = "emma.michel@collegesjb.com",
                            Name = "Emma Michel"
                        },
                        new
                        {
                            Id = new Guid("c0465f76-818b-4bcc-9944-db6c45a27429"),
                            Class = "1C",
                            Email = "antoine.leroy@collegesjb.com",
                            Name = "Antoine Leroy"
                        },
                        new
                        {
                            Id = new Guid("a1b90a17-0e3f-4581-8512-9ef090e8e4ba"),
                            Class = "4C",
                            Email = "claire.roux@collegesjb.com",
                            Name = "Claire Roux"
                        },
                        new
                        {
                            Id = new Guid("b53b1db3-0c0e-45b9-af33-f905e0a6c402"),
                            Class = "5A",
                            Email = "julien.vincent@collegesjb.com",
                            Name = "Julien Vincent"
                        },
                        new
                        {
                            Id = new Guid("990d26c5-ed73-41a4-91f5-526d509c0755"),
                            Class = "3B",
                            Email = "manon.garnier@collegesjb.com",
                            Name = "Manon Garnier"
                        },
                        new
                        {
                            Id = new Guid("991a3c0d-84fd-491f-a6e1-80203db9e5dd"),
                            Class = "2C",
                            Email = "nicolas.lambert@collegesjb.com",
                            Name = "Nicolas Lambert"
                        },
                        new
                        {
                            Id = new Guid("476a7bb7-0f2c-4a55-9342-0a0d4d3e942a"),
                            Class = "1B",
                            Email = "elodie.fournier@collegesjb.com",
                            Name = "Elodie Fournier"
                        },
                        new
                        {
                            Id = new Guid("adbe6d15-19c6-4cfc-a549-57ee457c2533"),
                            Class = "4D",
                            Email = "mathieu.chevalier@collegesjb.com",
                            Name = "Mathieu Chevalier"
                        },
                        new
                        {
                            Id = new Guid("d6a3ad99-1a00-49df-9d1f-828cadcdba76"),
                            Class = "5D",
                            Email = "isabelle.francois@collegesjb.com",
                            Name = "Isabelle Francois"
                        },
                        new
                        {
                            Id = new Guid("3ba6eb97-9886-4998-bc03-98ce1575d33e"),
                            Class = "3D",
                            Email = "hugo.dupuis@collegesjb.com",
                            Name = "Hugo Dupuis"
                        },
                        new
                        {
                            Id = new Guid("5886a891-42ac-484b-ae66-46be7f9c0d01"),
                            Class = "2A",
                            Email = "camille.fontaine@collegesjb.com",
                            Name = "Camille Fontaine"
                        },
                        new
                        {
                            Id = new Guid("5fa0054b-9ea6-4014-b274-1084c9fbc839"),
                            Class = "1D",
                            Email = "victor.leger@collegesjb.com",
                            Name = "Victor Leger"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
