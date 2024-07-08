﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLayer.Repository;

#nullable disable

namespace NLayer.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NLayer.Core.Entities.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AccountCreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountCreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8374),
                            AccountType = "RENTER",
                            Email = "ferhatcakmakoglu@gmail.com",
                            Password = "123456",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AccountCreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8389),
                            AccountType = "RENTER",
                            Email = "tryit@gmail.com",
                            Password = "123456789",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            AccountCreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8390),
                            AccountType = "RENTER",
                            Email = "helloworld@gmail.com",
                            Password = "147852369",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            AccountCreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8392),
                            AccountType = "USER",
                            Email = "ali@gmail.com",
                            Password = "159852364",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            AccountCreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8393),
                            AccountType = "USER",
                            Email = "veli@gmail.com",
                            Password = "236547895",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("NLayer.Core.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("Photos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "BMW",
                            CreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8643),
                            Description = "Hızlı bir araba",
                            Model = "iX",
                            Price = 2300m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Volvo",
                            CreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8645),
                            Description = "Yol tutuşu harika bir araba",
                            Model = "XC90",
                            Price = 1950m,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Fiat",
                            CreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8646),
                            Description = "Günlük içler için ideal",
                            Model = "Egea Multijet",
                            Price = 950m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Mercedes",
                            CreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8647),
                            Description = "Konfor harika",
                            Model = "E350",
                            Price = 1450m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Peugeot",
                            CreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8648),
                            Description = "Yeni nesil tasarım",
                            Model = "3008 Gt",
                            Price = 2750m,
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Audi",
                            CreatedDate = new DateTime(2024, 7, 8, 20, 45, 23, 140, DateTimeKind.Local).AddTicks(8650),
                            Description = "Modern, konforlu ve hızlı",
                            Model = "A8 Long",
                            Price = 3000m,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("NLayer.Core.Entities.CarFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GearType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Km")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarFeatures");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BodyType = "SEDAN",
                            CarId = 1,
                            Color = "Kırmızı",
                            FuelType = "HYBRID",
                            GearType = "SEMI_AUTOMATIC",
                            Km = "12500"
                        },
                        new
                        {
                            Id = 2,
                            BodyType = "SUV",
                            CarId = 2,
                            Color = "Gri",
                            FuelType = "DIESEL",
                            GearType = "AUTOMATIC",
                            Km = "4500"
                        },
                        new
                        {
                            Id = 3,
                            BodyType = "CROSSOVER",
                            CarId = 3,
                            Color = "Mavi",
                            FuelType = "GASOLINE",
                            GearType = "MANUEL",
                            Km = "111000"
                        },
                        new
                        {
                            Id = 4,
                            BodyType = "SEDAN",
                            CarId = 4,
                            Color = "Yeşil",
                            FuelType = "ELECTRIC",
                            GearType = "SEMI_AUTOMATIC",
                            Km = "2150"
                        },
                        new
                        {
                            Id = 5,
                            BodyType = "CROSSOVER",
                            CarId = 5,
                            Color = "Turuncu",
                            FuelType = "DIESEL",
                            GearType = "AUTOMATIC",
                            Km = "65000"
                        },
                        new
                        {
                            Id = 6,
                            BodyType = "CROSSOVER",
                            CarId = 6,
                            Color = "Siyah",
                            FuelType = "DIESEL",
                            GearType = "AUTOMATIC",
                            Km = "35600"
                        });
                });

            modelBuilder.Entity("NLayer.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(125)
                        .HasColumnType("nvarchar(125)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Photo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adress = "X Mahallesi ",
                            LastName = "Cakmakoglu",
                            Name = "Ferhat",
                            PhoneNumber = "12365478914"
                        },
                        new
                        {
                            Id = 2,
                            Adress = "Y Mahallesi ",
                            LastName = "Tellioglu",
                            Name = "Ahmet",
                            PhoneNumber = "96325874125"
                        },
                        new
                        {
                            Id = 3,
                            Adress = "Z Mahallesi ",
                            LastName = "Can",
                            Name = "Kerem",
                            PhoneNumber = "25874123654"
                        },
                        new
                        {
                            Id = 4,
                            Adress = "C Mahallesi ",
                            LastName = "Vurgun",
                            Name = "Ali",
                            PhoneNumber = "58963214875"
                        },
                        new
                        {
                            Id = 5,
                            Adress = "AA Mahallesi ",
                            LastName = "Menur",
                            Name = "Veli",
                            PhoneNumber = "98563210254"
                        });
                });

            modelBuilder.Entity("NLayer.Core.Entities.Account", b =>
                {
                    b.HasOne("NLayer.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NLayer.Core.Entities.Car", b =>
                {
                    b.HasOne("NLayer.Core.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NLayer.Core.Entities.CarFeature", b =>
                {
                    b.HasOne("NLayer.Core.Entities.Car", "Car")
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Car");
                });
#pragma warning restore 612, 618
        }
    }
}
