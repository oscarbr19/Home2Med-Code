﻿// <auto-generated />
using System;
using Home2Med.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Home2Med.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211015034531_initial1")]
    partial class initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Home2Med.Shared.Entity.Doctor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speciality")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Nurse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NurseDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NurseDocumentType")
                        .HasColumnType("int");

                    b.Property<int>("NurseGender")
                        .HasColumnType("int");

                    b.Property<string>("NurseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NursePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NursePhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NurseSpeciality")
                        .HasColumnType("int");

                    b.Property<bool>("NurseStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int?>("NurseId")
                        .HasColumnType("int");

                    b.Property<string>("PatientAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientDiagnosis")
                        .HasColumnType("int");

                    b.Property<int>("PatientDoctor")
                        .HasColumnType("int");

                    b.Property<string>("PatientDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientDocumentType")
                        .HasColumnType("int");

                    b.Property<string>("PatientEPS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientGender")
                        .HasColumnType("int");

                    b.Property<string>("PatientGeorreferentiation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PatientStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DoctorId");

                    b.HasIndex("NurseId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Relative", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PatientId")
                        .HasColumnType("int");

                    b.Property<string>("RelativeDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RelativeDocumentType")
                        .HasColumnType("int");

                    b.Property<string>("RelativeEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RelativeGender")
                        .HasColumnType("int");

                    b.Property<string>("RelativeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelativePatientDoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelativePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RelativePhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RelativeRelationship")
                        .HasColumnType("int");

                    b.Property<bool>("RelativeStatus")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("PatientId");

                    b.ToTable("Relatives");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Patient", b =>
                {
                    b.HasOne("Home2Med.Shared.Entity.Doctor", null)
                        .WithMany("Patients")
                        .HasForeignKey("DoctorId");

                    b.HasOne("Home2Med.Shared.Entity.Nurse", null)
                        .WithMany("Patients")
                        .HasForeignKey("NurseId");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Relative", b =>
                {
                    b.HasOne("Home2Med.Shared.Entity.Patient", null)
                        .WithMany("Relatives")
                        .HasForeignKey("PatientId");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Doctor", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Nurse", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("Home2Med.Shared.Entity.Patient", b =>
                {
                    b.Navigation("Relatives");
                });
#pragma warning restore 612, 618
        }
    }
}