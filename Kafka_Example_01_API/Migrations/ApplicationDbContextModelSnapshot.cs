﻿// <auto-generated />
using Kafka_Example_01_API.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace Kafka_Example_01_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("DBTEST1")
                .UseCollation("USING_NLS_COMP")
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kafka_Example_01_API.Core.Models.TableProduct", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("VARCHAR2(100)")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .IsUnicode(false)
                        .HasColumnType("VARCHAR2(200)")
                        .HasColumnName("NAME");

                    b.Property<decimal>("Price")
                        .HasColumnType("NUMBER(38)")
                        .HasColumnName("PRICE");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("NUMBER(38)")
                        .HasColumnName("QUANTITY");

                    b.HasKey("Id")
                        .HasName("SYS_C008257");

                    b.ToTable("TABLE_PRODUCT", "DBTEST1");
                });
#pragma warning restore 612, 618
        }
    }
}