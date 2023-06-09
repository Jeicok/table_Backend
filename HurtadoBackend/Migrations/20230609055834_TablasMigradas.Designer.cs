﻿// <auto-generated />
using HurtadoBackend.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HurtadoBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230609055834_TablasMigradas")]
    partial class TablasMigradas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HurtadoBackend.Modelos.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<bool>("GnrEstado")
                        .HasColumnType("bit");

                    b.Property<string>("GnrNombre")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("HurtadoBackend.Modelos.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<string>("UsrClave")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("UsrEstado")
                        .HasColumnType("bit");

                    b.Property<string>("UsrNombre")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.HasIndex("GeneroId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("HurtadoBackend.Modelos.Usuario", b =>
                {
                    b.HasOne("HurtadoBackend.Modelos.Genero", "Genero")
                        .WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genero");
                });
#pragma warning restore 612, 618
        }
    }
}
