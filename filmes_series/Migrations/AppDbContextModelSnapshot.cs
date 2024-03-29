﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using filmes_series.data.context;

#nullable disable

namespace filmes_series.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AtorProducao", b =>
                {
                    b.Property<int>("ElencoId")
                        .HasColumnType("int");

                    b.Property<int>("ProducoesId")
                        .HasColumnType("int");

                    b.HasKey("ElencoId", "ProducoesId");

                    b.HasIndex("ProducoesId");

                    b.ToTable("AtorProducao");
                });

            modelBuilder.Entity("filmes_series.domain.entity.Ator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Atores");
                });

            modelBuilder.Entity("filmes_series.domain.entity.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("ProducaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProducaoId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("filmes_series.domain.entity.Producao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Classificacao")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("DataLancamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Diretor")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Estudio")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.ToTable("Producoes");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Producao");
                });

            modelBuilder.Entity("filmes_series.domain.entity.Filme", b =>
                {
                    b.HasBaseType("filmes_series.domain.entity.Producao");

                    b.HasDiscriminator().HasValue("Filme");
                });

            modelBuilder.Entity("filmes_series.domain.entity.Serie", b =>
                {
                    b.HasBaseType("filmes_series.domain.entity.Producao");

                    b.Property<DateTime?>("DataEncerramento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Temporadas")
                        .HasMaxLength(255)
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Serie");
                });

            modelBuilder.Entity("AtorProducao", b =>
                {
                    b.HasOne("filmes_series.domain.entity.Ator", null)
                        .WithMany()
                        .HasForeignKey("ElencoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("filmes_series.domain.entity.Producao", null)
                        .WithMany()
                        .HasForeignKey("ProducoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("filmes_series.domain.entity.Categoria", b =>
                {
                    b.HasOne("filmes_series.domain.entity.Producao", null)
                        .WithMany("Categorias")
                        .HasForeignKey("ProducaoId");
                });

            modelBuilder.Entity("filmes_series.domain.entity.Producao", b =>
                {
                    b.Navigation("Categorias");
                });
#pragma warning restore 612, 618
        }
    }
}
