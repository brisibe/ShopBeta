﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopBeta.Infrastructure.Repository;

namespace ShopBeta.Api.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20201110201329_orders")]
    partial class orders
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "9cd6644c-747f-4432-b84b-ea10a71b2a8f",
                            ConcurrencyStamp = "a024a3e8-7668-44cf-8fd0-9d13758a2572",
                            Name = "Seller",
                            NormalizedName = "SELLER"
                        },
                        new
                        {
                            Id = "e1293093-e561-46b2-9577-cae241b426ae",
                            ConcurrencyStamp = "03c672a9-9fac-489b-97f7-7717678eea2a",
                            Name = "Customer",
                            NormalizedName = "CUSTOMER"
                        },
                        new
                        {
                            Id = "e041d9f1-9a75-446e-a352-516958d5f255",
                            ConcurrencyStamp = "61052091-a0e0-4fba-9267-ea011fc08098",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ShopBeta.Core.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ProductId")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("OldPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SellerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ProductsId");

                    b.HasIndex("SellerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductsId = 1,
                            Brand = "Apple",
                            Category = "Phones",
                            Description = "500Gb rom, 12mp rear camera, blah blah blah",
                            Name = "Iphone 12",
                            OldPrice = "150000",
                            Price = "800000"
                        },
                        new
                        {
                            ProductsId = 2,
                            Brand = "Samsung",
                            Category = "Phones",
                            Description = "500Gb rom, 12mp rear camera, blah blah blah",
                            Name = "Samsung Galaxy s11",
                            OldPrice = "650000",
                            Price = "500000"
                        },
                        new
                        {
                            ProductsId = 3,
                            Brand = "Sony",
                            Category = "Gaming",
                            Description = "500Gb hdd,  dual controller, lah blah blah",
                            Name = "Playstation 5",
                            OldPrice = "250000",
                            Price = "200000"
                        },
                        new
                        {
                            ProductsId = 4,
                            Brand = "Acer",
                            Category = "Computer",
                            Description = "500Gb ROM, 8Gb RAM, Nvidia gtx 1020, core i7",
                            Name = "Acer Aspire E5",
                            OldPrice = "420000",
                            Price = "400000"
                        });
                });

            modelBuilder.Entity("ShopBeta.Core.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("ReviewId");

                    b.HasIndex("ProductId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            Comment = "A wonderful product, swift delivery",
                            Name = "Bode Thomas",
                            ProductId = 1,
                            date = new DateTime(2020, 11, 10, 20, 13, 28, 873, DateTimeKind.Utc).AddTicks(2085)
                        },
                        new
                        {
                            ReviewId = 2,
                            Comment = "Great product but expensive",
                            Name = "Tunde Brisibe",
                            ProductId = 1,
                            date = new DateTime(2020, 11, 10, 20, 13, 28, 873, DateTimeKind.Utc).AddTicks(3343)
                        },
                        new
                        {
                            ReviewId = 3,
                            Comment = "wonderful laptop",
                            Name = "Jesse Brisibe",
                            ProductId = 4,
                            date = new DateTime(2020, 11, 10, 20, 13, 28, 873, DateTimeKind.Utc).AddTicks(3370)
                        });
                });

            modelBuilder.Entity("ShopBeta.Core.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ShopBeta.Infrastructure.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ShopBeta.Infrastructure.Orders.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductsId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ShopBeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ShopBeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShopBeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ShopBeta.Core.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopBeta.Core.Models.Products", b =>
                {
                    b.HasOne("ShopBeta.Core.Models.User", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("ShopBeta.Core.Models.Reviews", b =>
                {
                    b.HasOne("ShopBeta.Core.Models.Products", "Product")
                        .WithMany("reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ShopBeta.Infrastructure.Orders.Order", b =>
                {
                    b.HasOne("ShopBeta.Core.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ShopBeta.Infrastructure.Orders.OrderItem", b =>
                {
                    b.HasOne("ShopBeta.Infrastructure.Orders.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId");

                    b.HasOne("ShopBeta.Core.Models.Products", "Product")
                        .WithMany()
                        .HasForeignKey("ProductsId");
                });
#pragma warning restore 612, 618
        }
    }
}
