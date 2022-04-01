﻿// <auto-generated />
using AnimalShelter.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Api.Migrations
{
    [DbContext(typeof(AnimalShelterApiContext))]
    partial class AnimalShelterApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("AnimalShelter.Api.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Species")
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Breed = "I dunno, cat",
                            Description = "Fat & mean, you'll love him.",
                            Name = "Steve",
                            Species = "Cat",
                            Status = 1
                        },
                        new
                        {
                            AnimalId = 2,
                            Breed = "Beagle",
                            Description = "Just one of the worst dogs, but also one of the best? A study in contradictions.",
                            Name = "Six Hotdogs",
                            Species = "Dog",
                            Status = 2
                        },
                        new
                        {
                            AnimalId = 3,
                            Breed = "Chihuahua",
                            Description = "Annoying, mean, won't stop shaking, growls at everything, please help us",
                            Name = "Toes under the escalator",
                            Species = "Dog",
                            Status = 1
                        },
                        new
                        {
                            AnimalId = 4,
                            Breed = "Fat",
                            Description = "Queen Salt has to have her chicken precisely at 5pm or you will get scratched. She has thumbs!",
                            Name = "Salt",
                            Species = "Cat",
                            Status = 2
                        },
                        new
                        {
                            AnimalId = 5,
                            Breed = "Dachshund",
                            Description = "Loves a good burger",
                            Name = "Whataburger",
                            Species = "Dog",
                            Status = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}