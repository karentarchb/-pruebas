﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210121013433_Recreate")]
    partial class Recreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Project1.Models.Casino.Bet", b =>
                {
                    b.Property<int>("betID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("betAmmount")
                        .HasColumnType("int");

                    b.Property<int>("betType")
                        .HasColumnType("int");

                    b.Property<int?>("resultID")
                        .HasColumnType("int");

                    b.Property<int?>("rouletteID")
                        .HasColumnType("int");

                    b.HasKey("betID");

                    b.HasIndex("resultID");

                    b.HasIndex("rouletteID");

                    b.ToTable("t_Bet");
                });

            modelBuilder.Entity("Project1.Models.Casino.Result", b =>
                {
                    b.Property<int>("resultID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.HasKey("resultID");

                    b.ToTable("t_Result");
                });

            modelBuilder.Entity("Project1.Models.Casino.Roulette", b =>
                {
                    b.Property<int>("rouletteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.HasKey("rouletteID");

                    b.ToTable("t_Roulette");
                });

            modelBuilder.Entity("Project1.Models.Person", b =>
                {
                    b.Property<long>("IdNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdNumber");

                    b.ToTable("t_Person");
                });

            modelBuilder.Entity("Project1.Models.Casino.Bet", b =>
                {
                    b.HasOne("Project1.Models.Casino.Result", "result")
                        .WithMany()
                        .HasForeignKey("resultID");

                    b.HasOne("Project1.Models.Casino.Roulette", null)
                        .WithMany("bets")
                        .HasForeignKey("rouletteID");

                    b.Navigation("result");
                });

            modelBuilder.Entity("Project1.Models.Casino.Roulette", b =>
                {
                    b.Navigation("bets");
                });
#pragma warning restore 612, 618
        }
    }
}
