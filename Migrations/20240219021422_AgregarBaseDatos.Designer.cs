﻿// <auto-generated />
using System;
using MagiVilla.Datos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MagiVilla.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20240219021422_AgregarBaseDatos")]
    partial class AgregarBaseDatos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MagiVilla.Modelos.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Detalle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaActuslizacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaCreaccion")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagenUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetrosCuadrados")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ocupantes")
                        .HasColumnType("int");

                    b.Property<double>("Tarifa")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Amenidad = "",
                            Detalle = "Detalle de la villa...",
                            FechaActuslizacion = new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6800),
                            FechaCreaccion = new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6789),
                            ImagenUrl = "",
                            MetrosCuadrados = 50,
                            Nombre = "Villa Real",
                            Ocupantes = 5,
                            Tarifa = 200.0
                        },
                        new
                        {
                            Id = 2,
                            Amenidad = "",
                            Detalle = "Detalle de la villa...",
                            FechaActuslizacion = new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6802),
                            FechaCreaccion = new DateTime(2024, 2, 18, 22, 14, 22, 379, DateTimeKind.Local).AddTicks(6802),
                            ImagenUrl = "",
                            MetrosCuadrados = 40,
                            Nombre = "Premium vista a la pscina",
                            Ocupantes = 4,
                            Tarifa = 150.0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}