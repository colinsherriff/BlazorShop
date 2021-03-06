// <auto-generated />
using System;
using BlazorShop.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorShop.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211022035629_ProductsRemoveFromCategoryModel")]
    partial class ProductsRemoveFromCategoryModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BlazorShop.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "book",
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "camera-slr",
                            Name = "Electronics",
                            Url = "electronics"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "aperture",
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelected")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 558, DateTimeKind.Local).AddTicks(683),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Hitchhiker's Guisw to the Galexy ( sometimes refered to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 19.99m,
                            Price = 9.99m,
                            Title = "Hitchhiker's Guise to the Galaxy"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(808),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(858),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 0m,
                            Price = 6.99m,
                            Title = "Nineteen Eighty-Four"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(865),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 249.00m,
                            Price = 166.66m,
                            Title = "Pentax Spotmatic"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(871),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 299m,
                            Price = 159.99m,
                            Title = "Xbox"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(890),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                            Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 400m,
                            Price = 73.74m,
                            Title = "Super Nintendo Entertainment System"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(896),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 29.99m,
                            Price = 8.19m,
                            Title = "Half-Life 2"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(901),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 24.99m,
                            Price = 9.99m,
                            Title = "Diablo II"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            DateCreated = new DateTime(2021, 10, 22, 16, 56, 28, 563, DateTimeKind.Local).AddTicks(905),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                            Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                            IsDelected = false,
                            IsPublic = false,
                            OriginalPrice = 0m,
                            Price = 14.99m,
                            Title = "Day of the Tentacle"
                        });
                });

            modelBuilder.Entity("BlazorShop.Shared.Product", b =>
                {
                    b.HasOne("BlazorShop.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
