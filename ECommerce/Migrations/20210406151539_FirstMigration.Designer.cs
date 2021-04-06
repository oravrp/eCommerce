﻿// <auto-generated />
using System;
using ECommerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ECommerce.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210406151539_FirstMigration")]
    partial class FirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ECommerce.Models.Customer", b =>
                {
                    b.Property<int>("customer_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("customer_id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("ECommerce.Models.Order", b =>
                {
                    b.Property<int>("order_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("customer_id")
                        .HasColumnType("int");

                    b.Property<int?>("customer_id1")
                        .HasColumnType("int");

                    b.Property<int>("item_count")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int?>("product_id1")
                        .HasColumnType("int");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("order_id");

                    b.HasIndex("customer_id1");

                    b.HasIndex("product_id1");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("ECommerce.Models.Product", b =>
                {
                    b.Property<int>("product_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("varchar(50) CHARACTER SET utf8mb4")
                        .HasMaxLength(50);

                    b.Property<string>("imageurl")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("initial_quantity")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("datetime(6)");

                    b.HasKey("product_id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("ECommerce.Models.Order", b =>
                {
                    b.HasOne("ECommerce.Models.Customer", "customer")
                        .WithMany("orders")
                        .HasForeignKey("customer_id1");

                    b.HasOne("ECommerce.Models.Product", "product")
                        .WithMany("orders")
                        .HasForeignKey("product_id1");
                });
#pragma warning restore 612, 618
        }
    }
}