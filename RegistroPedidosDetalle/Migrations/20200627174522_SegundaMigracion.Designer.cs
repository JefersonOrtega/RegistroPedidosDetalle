﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroPedidosDetalle.DAL;

namespace RegistroPedidosDetalle.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200627174522_SegundaMigracion")]
    partial class SegundaMigracion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("RegistroPedidosDetalle.Models.Ordenes", b =>
                {
                    b.Property<int>("OrdenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.Property<int>("SuplidorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrdenId");

                    b.HasIndex("SuplidorId");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("RegistroPedidosDetalle.Models.OrdenesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Cantidad")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<int>("OrdenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductoId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("OrdenId");

                    b.HasIndex("ProductoId");

                    b.ToTable("OrdenesDetalle");
                });

            modelBuilder.Entity("RegistroPedidosDetalle.Models.Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Costo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int>("Inventario")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 250m,
                            Descripcion = "Salami Super especial",
                            Inventario = 10
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 1000m,
                            Descripcion = "Chuleta",
                            Inventario = 5
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 60m,
                            Descripcion = "Carton de Leche",
                            Inventario = 15
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 125m,
                            Descripcion = "Mantequilla",
                            Inventario = 10
                        });
                });

            modelBuilder.Entity("RegistroPedidosDetalle.Models.Suplidores", b =>
                {
                    b.Property<int>("SuplidorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombres")
                        .HasColumnType("TEXT");

                    b.HasKey("SuplidorId");

                    b.ToTable("Suplidores");

                    b.HasData(
                        new
                        {
                            SuplidorId = 1,
                            Nombres = "Induveca"
                        },
                        new
                        {
                            SuplidorId = 2,
                            Nombres = "Rica"
                        });
                });

            modelBuilder.Entity("RegistroPedidosDetalle.Models.Ordenes", b =>
                {
                    b.HasOne("RegistroPedidosDetalle.Models.Suplidores", "Suplidor")
                        .WithMany()
                        .HasForeignKey("SuplidorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RegistroPedidosDetalle.Models.OrdenesDetalle", b =>
                {
                    b.HasOne("RegistroPedidosDetalle.Models.Ordenes", null)
                        .WithMany("OrdenesDetalle")
                        .HasForeignKey("OrdenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistroPedidosDetalle.Models.Productos", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
