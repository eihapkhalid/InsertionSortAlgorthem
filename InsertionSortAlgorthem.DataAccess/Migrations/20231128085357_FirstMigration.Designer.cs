﻿// <auto-generated />
using InsertionSortAlgorthem.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InsertionSortAlgorthem.DataAccess.Migrations
{
    [DbContext(typeof(SortAlgoDbContext))]
    [Migration("20231128085357_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InsertionSortAlgorthem.Models.TbEmbloyee", b =>
                {
                    b.Property<int>("EmbloyeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmbloyeeId"));

                    b.Property<int>("EmbloyeeAge")
                        .HasColumnType("int");

                    b.Property<bool>("EmbloyeeIsActive")
                        .HasColumnType("bit");

                    b.Property<string>("EmbloyeeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("EmbloyeeSalary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("EmbloyeeId");

                    b.ToTable("TbEmbloyees");
                });
#pragma warning restore 612, 618
        }
    }
}
