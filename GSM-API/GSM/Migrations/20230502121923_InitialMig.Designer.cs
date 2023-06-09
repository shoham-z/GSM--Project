﻿// <auto-generated />
using System;
using GSM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GSM.Migrations
{
    [DbContext(typeof(GSMContext))]
    [Migration("20230502121923_InitialMig")]
    partial class InitialMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GSM.Models.GameData", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)")
                        .HasColumnOrder(0);

                    b.Property<string>("ChatGPTDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.HasKey("Name");

                    b.ToTable("GamesData");
                });

            modelBuilder.Entity("GSM.Models.GameGenre", b =>
                {
                    b.Property<string>("Genre")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("GameName")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("GameDataName")
                        .HasColumnType("varchar(255)");

                    b.HasKey("Genre", "GameName");

                    b.HasIndex("GameDataName");

                    b.ToTable("GameGenre");
                });

            modelBuilder.Entity("GSM.Models.GameServerStats", b =>
                {
                    b.Property<string>("GameName")
                        .HasColumnType("varchar(255)")
                        .HasColumnOrder(0);

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime")
                        .HasColumnOrder(1);

                    b.Property<decimal>("CPUUsage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("MAXCPU")
                        .HasColumnType("float");

                    b.Property<long>("PlayersCount")
                        .HasColumnType("bigint");

                    b.Property<float>("RAMSize")
                        .HasColumnType("float");

                    b.Property<decimal>("RAMUsage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Temperature")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TopScore")
                        .HasColumnType("int");

                    b.HasKey("GameName", "UpdateDate");

                    b.ToTable("GameServerStats");
                });

            modelBuilder.Entity("GSM.Models.GameGenre", b =>
                {
                    b.HasOne("GSM.Models.GameData", null)
                        .WithMany("Genres")
                        .HasForeignKey("GameDataName");
                });

            modelBuilder.Entity("GSM.Models.GameData", b =>
                {
                    b.Navigation("Genres");
                });
#pragma warning restore 612, 618
        }
    }
}
