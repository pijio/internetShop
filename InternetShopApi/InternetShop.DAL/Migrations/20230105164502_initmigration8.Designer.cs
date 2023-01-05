﻿// <auto-generated />
using InternetShop.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace InternetShop.DAL.Migrations
{
    [DbContext(typeof(InternetShopDbContext))]
    [Migration("20230105164502_initmigration8")]
    partial class initmigration8
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<string>("Os")
                        .HasColumnType("text");

                    b.Property<string>("Processor")
                        .HasColumnType("text");

                    b.Property<int>("Ram")
                        .HasColumnType("integer");

                    b.Property<double>("ScreenSize")
                        .HasColumnType("double precision");

                    b.HasKey("CharactId", "ProductId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductsCharacteristics");
                });

            modelBuilder.Entity("InternetShop.DAL.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CharactId")
                        .HasColumnType("integer");

                    b.Property<int>("InfoId")
                        .HasColumnType("integer");

                    b.Property<int>("Key")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("Rate")
                        .HasColumnType("double precision");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("InternetShop.DAL.ProductAdditInfo", b =>
                {
                    b.Property<int>("InfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

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

                    b.HasKey("InfoId", "ProductId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("ProductAdditInfos");
                });

            modelBuilder.Entity("InternetShop.DAL.Characteristics", b =>
                {
                    b.HasOne("InternetShop.DAL.Product", "Product")
                        .WithOne("Characteristics")
                        .HasForeignKey("InternetShop.DAL.Characteristics", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InternetShop.DAL.Product", b =>
                {
                    b.HasOne("InternetShop.DAL.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("InternetShop.DAL.ProductAdditInfo", b =>
                {
                    b.HasOne("InternetShop.DAL.Product", "Product")
                        .WithOne("AdditInfo")
                        .HasForeignKey("InternetShop.DAL.ProductAdditInfo", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("InternetShop.DAL.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("InternetShop.DAL.Product", b =>
                {
                    b.Navigation("AdditInfo");

                    b.Navigation("Characteristics");
                });
#pragma warning restore 612, 618
        }
    }
}
