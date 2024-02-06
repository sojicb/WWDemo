﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WWDemo.Data;

#nullable disable

namespace WWDemo.Data.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    [Migration("20240206193602_Add_Index_ProductsSerialNumber")]
    partial class Add_Index_ProductsSerialNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WWDemo.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Category")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Price")
                        .HasColumnType("text");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SerialNumber");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
