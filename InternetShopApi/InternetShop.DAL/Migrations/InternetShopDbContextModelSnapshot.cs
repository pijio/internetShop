﻿// <auto-generated />
using System;
using InternetShop.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InternetShop.DAL.Migrations
{
    [DbContext(typeof(InternetShopDbContext))]
    partial class InternetShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("InternetShop.DAL.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("InternetShop.DAL.Characteristics", b =>
                {
                    b.Property<int>("CharactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("DiscVolAndType")
                        .HasColumnType("text");

                    b.Property<string>("Dpi")
                        .HasColumnType("text");

                    b.Property<string>("Format")
                        .HasColumnType("text");

                    b.Property<string>("MatrixType")
                        .HasColumnType("text");

                    b.Property<string>("Os")
                        .HasColumnType("text");

                    b.Property<string>("PrinterRam")
                        .HasColumnType("text");

                    b.Property<string>("PrinterType")
                        .HasColumnType("text");

                    b.Property<string>("Processor")
                        .HasColumnType("text");

                    b.Property<int?>("Ram")
                        .HasColumnType("integer");

                    b.Property<string>("RelationSide")
                        .HasColumnType("text");

                    b.Property<double?>("ScreenSize")
                        .HasColumnType("double precision");

                    b.HasKey("CharactId");

                    b.ToTable("ProductsCharacteristics");
                });

            modelBuilder.Entity("InternetShop.DAL.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("AdditInfoInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CharactId")
                        .HasColumnType("integer");

                    b.Property<int?>("CharacteristicsCharactId")
                        .HasColumnType("integer");

                    b.Property<bool>("InStock")
                        .HasColumnType("boolean");

                    b.Property<int>("InfoId")
                        .HasColumnType("integer");

                    b.Property<int>("Key")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.HasIndex("AdditInfoInfoId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CharacteristicsCharactId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InternetShop.DAL.ProductAdditInfo", b =>
                {
                    b.Property<int>("InfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl1")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl2")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl3")
                        .HasColumnType("text");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("text");

                    b.HasKey("InfoId");

                    b.ToTable("ProductAdditInfos");
                });

            modelBuilder.Entity("InternetShop.DAL.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InternetShop.DAL.Product", b =>
                {
                    b.HasOne("InternetShop.DAL.ProductAdditInfo", "AdditInfo")
                        .WithMany()
                        .HasForeignKey("AdditInfoInfoId");

                    b.HasOne("InternetShop.DAL.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InternetShop.DAL.Characteristics", "Characteristics")
                        .WithMany()
                        .HasForeignKey("CharacteristicsCharactId");

                    b.Navigation("AdditInfo");

                    b.Navigation("Category");

                    b.Navigation("Characteristics");
                });
#pragma warning restore 612, 618
        }
    }
}
