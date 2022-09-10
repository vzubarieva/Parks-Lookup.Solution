﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Park_Lookup.Models;

namespace Park_Lookup.Migrations
{
    [DbContext(typeof(Park_LookupContext))]
    partial class Park_LookupContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Park_Lookup.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Location = "Washington state",
                            Name = "Bridle Trails State Park",
                            Type = "State park"
                        },
                        new
                        {
                            ParkId = 2,
                            Location = "Washington state",
                            Name = "Lake Sammamish State Park",
                            Type = "State park"
                        },
                        new
                        {
                            ParkId = 3,
                            Location = "Washington state",
                            Name = "Saint Edward State Park",
                            Type = "State park"
                        },
                        new
                        {
                            ParkId = 4,
                            Location = "Washington state",
                            Name = "Bear Creek Park",
                            Type = "State park"
                        },
                        new
                        {
                            ParkId = 5,
                            Location = "Washington state",
                            Name = "Olympic National Park",
                            Type = "National park"
                        },
                        new
                        {
                            ParkId = 6,
                            Location = "Washington state",
                            Name = "Mount Rainier National Park",
                            Type = "National park"
                        },
                        new
                        {
                            ParkId = 7,
                            Location = "Washington state",
                            Name = "North Cascades National Park",
                            Type = "National park"
                        },
                        new
                        {
                            ParkId = 8,
                            Location = "Oregon state",
                            Name = "Crater Lake National Park",
                            Type = "National park"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
