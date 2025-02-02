﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RabbitMQReiverCoreAPI.Models;

namespace RabbitMQReiverCoreAPI.Migrations
{
    [DbContext(typeof(MedicineSystemContext))]
    [Migration("20220307113956_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("RabbitMQReiverCoreAPI.Models.AbcPharma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Brand")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("date")
                        .HasColumnName("expiryDate");

                    b.Property<string>("MedicineName")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Medicine_Name");

                    b.Property<string>("Notes")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal?>("Quantiy")
                        .HasColumnType("numeric(10,0)");

                    b.HasKey("Id");

                    b.ToTable("ABC Pharma");
                });

            modelBuilder.Entity("RabbitMQReiverCoreAPI.Models.Newtable", b =>
                {
                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("address");

                    b.Property<string>("Company")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("company");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("phone");

                    b.Property<string>("PostalZip")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("postalZip");

                    b.HasIndex(new[] { "PostalZip" }, "<Name of Missing Index, sysname,>");

                    b.HasIndex(new[] { "Name", "Phone", "Company", "Address" }, "NonClusteredIndex-20210923-072501");

                    b.ToTable("newtable");
                });

            modelBuilder.Entity("RabbitMQReiverCoreAPI.Models.TblEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Location")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("Salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("tbl_Employees");
                });

            modelBuilder.Entity("RabbitMQReiverCoreAPI.Models.TblEmployeeManager", b =>
                {
                    b.Property<int>("EmpId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManagerId")
                        .HasColumnType("int")
                        .HasColumnName("Manager_Id");

                    b.HasKey("EmpId");

                    b.ToTable("TblEmployeeManager");
                });
#pragma warning restore 612, 618
        }
    }
}
