﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineGames.Models;

namespace OnlineGames.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200528201230_Slika")]
    partial class Slika
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineGames.Models.Igrica", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<DateTime>("DatumIzlaska")
                        .HasColumnType("datetime2");

                    b.Property<string>("Izdavac")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SlikaIgriceId")
                        .HasColumnType("int");

                    b.Property<string>("Specifikacije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SlikaIgriceId");

                    b.ToTable("Igrica");
                });

            modelBuilder.Entity("OnlineGames.Models.Kategorija", b =>
                {
                    b.Property<int>("KategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategorijaId");

                    b.ToTable("Kategorija");
                });

            modelBuilder.Entity("OnlineGames.Models.KategorijaIgrica", b =>
                {
                    b.Property<int>("KategorijaIgricaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IgricaId")
                        .HasColumnType("int");

                    b.Property<int>("KategorijaId")
                        .HasColumnType("int");

                    b.HasKey("KategorijaIgricaId");

                    b.HasIndex("IgricaId");

                    b.HasIndex("KategorijaId");

                    b.ToTable("KategorijaIgrica");
                });

            modelBuilder.Entity("OnlineGames.Models.Novosti", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tekst")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Novosti");
                });

            modelBuilder.Entity("OnlineGames.Models.SlikaIgrice", b =>
                {
                    b.Property<int>("SlikaIgriceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SlikaIgriceId");

                    b.ToTable("SlikaIgirce");
                });

            modelBuilder.Entity("OnlineGames.Models.Igrica", b =>
                {
                    b.HasOne("OnlineGames.Models.SlikaIgrice", "SlikaIgrice")
                        .WithMany()
                        .HasForeignKey("SlikaIgriceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineGames.Models.KategorijaIgrica", b =>
                {
                    b.HasOne("OnlineGames.Models.Igrica", "Igrica")
                        .WithMany("KategorijaIgrica")
                        .HasForeignKey("IgricaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineGames.Models.Kategorija", "Kategorija")
                        .WithMany("KategorijaIgrica")
                        .HasForeignKey("KategorijaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
