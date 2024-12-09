﻿// <auto-generated />
using System;
using ElectronicDeviceManager.DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ElectronicDeviceManager.DataAccessLayer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241205173936_Migazad2")]
    partial class Migazad2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Device", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeviceDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeviceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.DeviceAssignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AssignedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DeviceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId")
                        .IsUnique();

                    b.HasIndex("EmployeeId");

                    b.ToTable("DeviceAssignments");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<Guid>("DepartmentId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId1");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.SoftwareLicense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DeviceID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LicenseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vendor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DeviceID")
                        .IsUnique();

                    b.ToTable("SoftwareLicense");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.DeviceAssignment", b =>
                {
                    b.HasOne("ElectronicDeviceManager.EntityLayer.Models.Device", "Device")
                        .WithOne("deviceAssignment")
                        .HasForeignKey("ElectronicDeviceManager.EntityLayer.Models.DeviceAssignment", "DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ElectronicDeviceManager.EntityLayer.Models.Employee", "Employee")
                        .WithMany("DeviceAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Employee", b =>
                {
                    b.HasOne("ElectronicDeviceManager.EntityLayer.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.SoftwareLicense", b =>
                {
                    b.HasOne("ElectronicDeviceManager.EntityLayer.Models.Device", "Device")
                        .WithOne("softwareLicense")
                        .HasForeignKey("ElectronicDeviceManager.EntityLayer.Models.SoftwareLicense", "DeviceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Device", b =>
                {
                    b.Navigation("deviceAssignment");

                    b.Navigation("softwareLicense");
                });

            modelBuilder.Entity("ElectronicDeviceManager.EntityLayer.Models.Employee", b =>
                {
                    b.Navigation("DeviceAssignments");
                });
#pragma warning restore 612, 618
        }
    }
}