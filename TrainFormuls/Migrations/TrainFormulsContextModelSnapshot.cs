﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrainFormuls.DataAccess.Contexts;

namespace TrainFormuls.Migrations
{
    [DbContext(typeof(TrainFormulsContext))]
    partial class TrainFormulsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26");

            modelBuilder.Entity("TrainFormuls.DataAccess.Models.FormulaRto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Formulas");
                });

            modelBuilder.Entity("TrainFormuls.DataAccess.Models.QuantityRto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int?>("FormulaRtoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FormulaRtoId");

                    b.ToTable("Quantities");
                });

            modelBuilder.Entity("TrainFormuls.DataAccess.Models.QuantityRto", b =>
                {
                    b.HasOne("TrainFormuls.DataAccess.Models.FormulaRto", null)
                        .WithMany("Quantities")
                        .HasForeignKey("FormulaRtoId");
                });
#pragma warning restore 612, 618
        }
    }
}