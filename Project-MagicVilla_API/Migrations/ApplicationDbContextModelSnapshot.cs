﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_MagicVilla_API.Context;

#nullable disable

namespace Project_MagicVilla_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_MagicVilla_API.Models.Villa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Occupancy")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("Sqrft")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Villas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5448),
                            Details = "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.",
                            ImageUrl = "https://th.bing.com/th?id=OIP.1YM53mG10H_U25iPjop83QHaEo&w=316&h=197&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                            Name = "Royal Villa",
                            Occupancy = 10,
                            Rate = 10000.0,
                            Sqrft = 50,
                            UpdatedDate = new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5457)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5464),
                            Details = "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.",
                            ImageUrl = "https://th.bing.com/th?id=OIP.aj48y9KXH2xOZ46X9NvKJQHaEo&w=316&h=197&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                            Name = "Forest Villa",
                            Occupancy = 20,
                            Rate = 20000.0,
                            Sqrft = 100,
                            UpdatedDate = new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5465)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5466),
                            Details = "We have a few other developers using the same solution code (myself included) that have not issues with add-migration.",
                            ImageUrl = "https://th.bing.com/th?id=OIP.Vt3kGu4X6WQlmH91GpJpzgHaFH&w=300&h=207&c=8&rs=1&qlt=90&o=6&dpr=1.3&pid=3.1&rm=2",
                            Name = "Beach Villa",
                            Occupancy = 5,
                            Rate = 30000.0,
                            Sqrft = 200,
                            UpdatedDate = new DateTime(2023, 7, 5, 15, 5, 10, 865, DateTimeKind.Local).AddTicks(5467)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
