﻿// <auto-generated />
using InventoryBack.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace inventoryBack2.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("InventoryBack.Models.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Cantidad")
                        .HasColumnType("tinyint");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Cuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Folio")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Fondo")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Num_Empleado")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Observaciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Pertenece")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Responsable")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Serie_De_Fabrica")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Subcuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Unidad_Presupuestal")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("InventoryDetails");
                });
#pragma warning restore 612, 618
        }
    }
}