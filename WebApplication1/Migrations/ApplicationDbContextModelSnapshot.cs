﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Properties.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebApplication1.Properties.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EmployeeListId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeListId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.EmployeeList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("EmployeeLists");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DueEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ProjectListId")
                        .HasColumnType("int");

                    b.Property<double>("TotalWorkingHours")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ProjectListId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.ProjectList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("ProjectLists");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.Employee", b =>
                {
                    b.HasOne("WebApplication1.Properties.Data.EmployeeList", null)
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeListId");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.Project", b =>
                {
                    b.HasOne("WebApplication1.Properties.Data.ProjectList", null)
                        .WithMany("Projects")
                        .HasForeignKey("ProjectListId");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.EmployeeList", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("WebApplication1.Properties.Data.ProjectList", b =>
                {
                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}