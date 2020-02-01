﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using apiTurnos.Data;

namespace apiTurnos.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200201010044_fixturno")]
    partial class fixturno
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("apiTurnos.Models.Empresa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Razon_social")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("empresas");
                });

            modelBuilder.Entity("apiTurnos.Models.Jornada", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("apertura")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("cierre")
                        .HasColumnType("datetime2");

                    b.Property<int?>("empresaid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("empresaid");

                    b.ToTable("jornadas");
                });

            modelBuilder.Entity("apiTurnos.Models.JornadaServicio", b =>
                {
                    b.Property<int>("jornadaId")
                        .HasColumnType("int");

                    b.Property<int>("servicioId")
                        .HasColumnType("int");

                    b.HasKey("jornadaId", "servicioId");

                    b.HasIndex("servicioId");

                    b.ToTable("jornadasServicios");
                });

            modelBuilder.Entity("apiTurnos.Models.Precio", b =>
                {
                    b.Property<DateTime>("fechahora")
                        .HasColumnType("datetime2");

                    b.Property<float>("importe")
                        .HasColumnType("real");

                    b.Property<int?>("servicioIdid")
                        .HasColumnType("int");

                    b.HasKey("fechahora");

                    b.HasIndex("servicioIdid");

                    b.ToTable("precios");
                });

            modelBuilder.Entity("apiTurnos.Models.Rol", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Usuarioid")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Usuarioid");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("apiTurnos.Models.Servicio", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("servicios");
                });

            modelBuilder.Entity("apiTurnos.Models.Turno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("jornadaServiciojornadaId")
                        .HasColumnType("int");

                    b.Property<int?>("jornadaServicioservicioId")
                        .HasColumnType("int");

                    b.Property<int?>("usuarioid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("usuarioid");

                    b.HasIndex("jornadaServiciojornadaId", "jornadaServicioservicioId");

                    b.ToTable("turnos");
                });

            modelBuilder.Entity("apiTurnos.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("apiTurnos.Models.Jornada", b =>
                {
                    b.HasOne("apiTurnos.Models.Empresa", "empresa")
                        .WithMany("jornadas")
                        .HasForeignKey("empresaid");
                });

            modelBuilder.Entity("apiTurnos.Models.JornadaServicio", b =>
                {
                    b.HasOne("apiTurnos.Models.Jornada", "jornada")
                        .WithMany()
                        .HasForeignKey("jornadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("apiTurnos.Models.Servicio", "servicio")
                        .WithMany()
                        .HasForeignKey("servicioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("apiTurnos.Models.Precio", b =>
                {
                    b.HasOne("apiTurnos.Models.Servicio", "servicioId")
                        .WithMany("Precios")
                        .HasForeignKey("servicioIdid");
                });

            modelBuilder.Entity("apiTurnos.Models.Rol", b =>
                {
                    b.HasOne("apiTurnos.Models.Usuario", "Usuario")
                        .WithMany("roles")
                        .HasForeignKey("Usuarioid");
                });

            modelBuilder.Entity("apiTurnos.Models.Turno", b =>
                {
                    b.HasOne("apiTurnos.Models.Usuario", "usuario")
                        .WithMany("turnos")
                        .HasForeignKey("usuarioid");

                    b.HasOne("apiTurnos.Models.JornadaServicio", "jornadaServicio")
                        .WithMany()
                        .HasForeignKey("jornadaServiciojornadaId", "jornadaServicioservicioId");
                });
#pragma warning restore 612, 618
        }
    }
}