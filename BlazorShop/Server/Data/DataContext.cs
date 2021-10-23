﻿using BlazorShop.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorShop.Server.Data
{
    public class DataContext : DbContext

    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Books", Url = "books", Icon = "book" },
                new Category { Id = 2, Name = "Electronics", Url = "electronics", Icon = "camera-slr" },
                new Category { Id = 3, Name = "Video Games", Url = "video-games", Icon = "aperture" }
                );

            modelBuilder.Entity<Product>().HasData
                (
                    new Product
                    {
                        Id = 1,
                        CategoryId = 1,
                        Title = "Hitchhiker's Guise to the Galaxy",
                        Description = "The Hitchhiker's Guisw to the Galexy ( sometimes refered to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
                        Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                        Price = 9.99m,
                        OriginalPrice = 19.99m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },

                    new Product
                    {
                        Id = 2,
                        CategoryId = 1,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                        Price = 8.19m,
                        OriginalPrice = 29.99m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },

                    new Product
                    {
                        Id = 3,
                        CategoryId = 1,
                        Title = "Nineteen Eighty-Four",
                        Description = "Nineteen Eighty-Four: A Novel, often published as 1984, is a dystopian social science fiction novel by English novelist George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime.",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg",
                        Price = 6.99m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },
                    new Product
                    {
                        Id = 4,
                        CategoryId = 2,
                        Title = "Pentax Spotmatic",
                        Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                        Price = 166.66m,
                        OriginalPrice = 249.00m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },
                    new Product
                    {
                        Id = 5,
                        CategoryId = 2,
                        Title = "Xbox",
                        Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                        Price = 159.99m,
                        OriginalPrice = 299m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 2,
                        Title = "Super Nintendo Entertainment System",
                        Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                        Price = 73.74m,
                        OriginalPrice = 400m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },
                    new Product
                    {
                        Id = 7,
                        CategoryId = 3,
                        Title = "Half-Life 2",
                        Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                        Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                        Price = 8.19m,
                        OriginalPrice = 29.99m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },
                    new Product
                    {
                        Id = 8,
                        CategoryId = 3,
                        Title = "Diablo II",
                        Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                        Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                        Price = 9.99m,
                        OriginalPrice = 24.99m,
                        DateCreated = new DateTime(2021, 1, 1)
                    },
                    new Product
                    {
                        Id = 9,
                        CategoryId = 3,
                        Title = "Day of the Tentacle",
                        Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                        Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                        Price = 14.99m,
                        DateCreated = new DateTime(2021, 1, 1)
                    }
                );

            modelBuilder.Entity<Edition>().HasData(
                new Edition { Id = 1, Name = "Paperback" },
                new Edition { Id = 2, Name = "E-Book" },
                new Edition { Id = 3, Name = "Audio Book" },
                new Edition { Id = 4, Name = "PC" },
                new Edition { Id = 5, Name = "PlayStation" },
                new Edition { Id = 6, Name = "Xbox" }
                );

            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct")
                .HasData(
                new { EditionsId = 1, ProductsId = 1 },
                new { EditionsId = 2, ProductsId = 1 },
                new { EditionsId = 3, ProductsId = 1 },
                new { EditionsId = 1, ProductsId = 2 },
                new { EditionsId = 2, ProductsId = 2 },
                new { EditionsId = 4, ProductsId = 7 },
                new { EditionsId = 5, ProductsId = 7 },
                new { EditionsId = 6, ProductsId = 7 }
                );
        }
    }
}