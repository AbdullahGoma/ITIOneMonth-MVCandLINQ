﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThirdDemo.DBContext;

#nullable disable

namespace Sheet3.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230822195903_UpdateEmployeeTable1")]
    partial class UpdateEmployeeTable1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Sheet3.Models.Department", b =>
                {
                    b.Property<int>("Dnumber")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dnumber"));

                    b.Property<string>("Dname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("MGRSDATE")
                        .HasColumnType("datetime2");

                    b.Property<int>("SuperssnId")
                        .HasColumnType("int");

                    b.HasKey("Dnumber");

                    b.HasIndex("SuperssnId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Sheet3.Models.Employee", b =>
                {
                    b.Property<int>("SSN")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SSN"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("BDATE")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeSSN")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeeSSN")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool>("IsVisable")
                        .HasColumnType("bit");

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SSN");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("EmployeeeSSN");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Sheet3.Models.Superssn", b =>
                {
                    b.Property<int>("SSSN")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10)
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SSSN"));

                    b.HasKey("SSSN");

                    b.ToTable("Superssns");
                });

            modelBuilder.Entity("Sheet3.Models.Department", b =>
                {
                    b.HasOne("Sheet3.Models.Superssn", "Superssn")
                        .WithMany()
                        .HasForeignKey("SuperssnId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Superssn");
                });

            modelBuilder.Entity("Sheet3.Models.Employee", b =>
                {
                    b.HasOne("Sheet3.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sheet3.Models.Employee", "Employeee")
                        .WithMany()
                        .HasForeignKey("EmployeeeSSN")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Employeee");
                });
#pragma warning restore 612, 618
        }
    }
}
