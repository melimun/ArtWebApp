﻿// <auto-generated />
using System;
using ArtWebApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ArtWebApp.Migrations
{
    [DbContext(typeof(CommissionContext))]
    [Migration("20231129061201_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("ArtWebApp.Models.Commission", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("userId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("Commission", (string)null);
                });

            modelBuilder.Entity("ArtWebApp.Models.OrderedCommission", b =>
                {
                    b.Property<int>("orderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("buyerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("itemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("notes")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("orderId");

                    b.ToTable("orderedCommissions", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
