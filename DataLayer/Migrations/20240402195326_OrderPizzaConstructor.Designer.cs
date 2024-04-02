﻿// <auto-generated />
using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataLayer.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20240402195326_OrderPizzaConstructor")]
    partial class OrderPizzaConstructor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataLayer.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = new Guid("33b791ed-0085-4016-9c0b-0f068e663326"),
                            Age = 21,
                            Name = "Gabi"
                        },
                        new
                        {
                            Id = new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf"),
                            Age = 20,
                            Name = "Maria"
                        },
                        new
                        {
                            Id = new Guid("19d51914-ac74-4b94-803c-8506511038d2"),
                            Age = 30,
                            Name = "Ana"
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Office", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Devices")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e6b39b49-53db-4eef-9e36-f04d06b27456"),
                            Devices = "Computer, Laptop, Printer",
                            EmployeeId = new Guid("33b791ed-0085-4016-9c0b-0f068e663326")
                        },
                        new
                        {
                            Id = new Guid("eb5e3a9c-d6e3-4574-954c-45d9dd6b8131"),
                            Devices = "Laptop, Printer",
                            EmployeeId = new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf")
                        },
                        new
                        {
                            Id = new Guid("af2cd36c-bb43-4e8c-b5c5-62f9c6450634"),
                            Devices = "Computer",
                            EmployeeId = new Guid("19d51914-ac74-4b94-803c-8506511038d2")
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"),
                            DateTime = new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6027),
                            EmployeeId = new Guid("33b791ed-0085-4016-9c0b-0f068e663326")
                        },
                        new
                        {
                            Id = new Guid("07ae8913-ec0c-4110-aa7c-9638d0059e13"),
                            DateTime = new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6087),
                            EmployeeId = new Guid("f1fa59fa-a7cf-4e05-9031-cad1063a3caf")
                        },
                        new
                        {
                            Id = new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"),
                            DateTime = new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6090),
                            EmployeeId = new Guid("19d51914-ac74-4b94-803c-8506511038d2")
                        },
                        new
                        {
                            Id = new Guid("34550853-e2df-4378-8879-e86abda5b2c8"),
                            DateTime = new DateTime(2024, 4, 2, 22, 53, 26, 263, DateTimeKind.Local).AddTicks(6092),
                            EmployeeId = new Guid("33b791ed-0085-4016-9c0b-0f068e663326")
                        });
                });

            modelBuilder.Entity("DataLayer.Models.OrderPizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PizzaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("PizzaId");

                    b.ToTable("OrderPizza");

                    b.HasData(
                        new
                        {
                            Id = new Guid("562b9a3c-e17e-46c5-b42f-cb3eae881d44"),
                            OrderId = new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"),
                            PizzaId = new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc")
                        },
                        new
                        {
                            Id = new Guid("8d939c48-bfe5-44c2-a6ef-5cd7e90b7513"),
                            OrderId = new Guid("9df41939-93ea-42c4-b4a3-4ed6c941c5aa"),
                            PizzaId = new Guid("4a0036f1-5e27-4662-b379-c92eea215542")
                        },
                        new
                        {
                            Id = new Guid("6dfe9925-d76a-4fa1-a60a-82b480d9f472"),
                            OrderId = new Guid("07ae8913-ec0c-4110-aa7c-9638d0059e13"),
                            PizzaId = new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653")
                        },
                        new
                        {
                            Id = new Guid("f03ac834-0d4f-40f5-9c3d-a3077cb422e9"),
                            OrderId = new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"),
                            PizzaId = new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653")
                        },
                        new
                        {
                            Id = new Guid("e317b8e6-b738-4bc6-96ca-c569df50a8db"),
                            OrderId = new Guid("fd9b6c99-63a9-4a13-bad6-26f6091bf362"),
                            PizzaId = new Guid("8fd24f07-5581-4406-bdbc-b211025b2141")
                        },
                        new
                        {
                            Id = new Guid("8b22c387-1424-45c3-b494-e4f21c51c10f"),
                            OrderId = new Guid("34550853-e2df-4378-8879-e86abda5b2c8"),
                            PizzaId = new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc")
                        },
                        new
                        {
                            Id = new Guid("3f688795-7822-4ea4-9a6e-91c09a78430f"),
                            OrderId = new Guid("34550853-e2df-4378-8879-e86abda5b2c8"),
                            PizzaId = new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653")
                        },
                        new
                        {
                            Id = new Guid("d4741f93-f028-4112-b4f6-9cceafbcd3da"),
                            OrderId = new Guid("34550853-e2df-4378-8879-e86abda5b2c8"),
                            PizzaId = new Guid("8fd24f07-5581-4406-bdbc-b211025b2141")
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d96730bf-6374-4a82-9bae-69d706fafbcc"),
                            Description = "Mozzarella, Salam Picant, Sos Picant",
                            Name = "Diavola",
                            Price = 32f
                        },
                        new
                        {
                            Id = new Guid("4a0036f1-5e27-4662-b379-c92eea215542"),
                            Description = "Mozzarella, Salam, Cabanos, Sos",
                            Name = "Salami",
                            Price = 28f
                        },
                        new
                        {
                            Id = new Guid("5af967d2-c37e-4da0-bd43-ebd4dc0ff653"),
                            Description = "Mozzarella, Salam, Sunca, Sos",
                            Name = "Capricioasa",
                            Price = 34f
                        },
                        new
                        {
                            Id = new Guid("8fd24f07-5581-4406-bdbc-b211025b2141"),
                            Description = "Mozzarella, Branza",
                            Name = "Margherita",
                            Price = 24f
                        });
                });

            modelBuilder.Entity("DataLayer.Models.Office", b =>
                {
                    b.HasOne("DataLayer.Models.Employee", "Employee")
                        .WithOne("Office")
                        .HasForeignKey("DataLayer.Models.Office", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DataLayer.Models.Order", b =>
                {
                    b.HasOne("DataLayer.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DataLayer.Models.OrderPizza", b =>
                {
                    b.HasOne("DataLayer.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataLayer.Models.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataLayer.Models.Employee", b =>
                {
                    b.Navigation("Office")
                        .IsRequired();

                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}