﻿// <auto-generated />
using System;
using Flocker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Flocker.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Flocker.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Image = "~/Image/game-console.png",
                            Name = "Games"
                        },
                        new
                        {
                            CategoryId = 2,
                            Image = "~/Image/game-console.png",
                            Name = "Electronic"
                        },
                        new
                        {
                            CategoryId = 3,
                            Image = "~/Image/game-console.png",
                            Name = "Accessories"
                        },
                        new
                        {
                            CategoryId = 4,
                            Image = "~/Image/game-console.png",
                            Name = "Phone"
                        });
                });

            modelBuilder.Entity("Flocker.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            ProductId = 1,
                            UserId = 1,
                            content = "how much is this?"
                        },
                        new
                        {
                            CommentId = 2,
                            ProductId = 1,
                            UserId = 1,
                            content = "how much is this?"
                        },
                        new
                        {
                            CommentId = 3,
                            ProductId = 1,
                            UserId = 1,
                            content = "how much is this?"
                        },
                        new
                        {
                            CommentId = 4,
                            ProductId = 1,
                            UserId = 1,
                            content = "how much is this?"
                        });
                });

            modelBuilder.Entity("Flocker.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatePosted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Sold")
                        .HasColumnType("bit");

                    b.Property<bool>("Spotlight")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 2,
                            DatePosted = new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
                            Image = "https://i.imgur.com/w305JQE.png",
                            Name = "XBOX ONE CONTROLLER",
                            Price = 34.99m,
                            Sold = false,
                            Spotlight = false,
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            DatePosted = new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
                            Image = "~/Image/controller.png",
                            Name = "XBOX ONE CONTROLLER FREE",
                            Price = 34.99m,
                            Sold = false,
                            Spotlight = true,
                            UserId = 1
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            DatePosted = new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
                            Image = "~/Image/cupboard.png",
                            Name = "CUPBOARD",
                            Price = 34.99m,
                            Sold = false,
                            Spotlight = true,
                            UserId = 2
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            DatePosted = new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
                            Image = "~/Image/bed.png",
                            Name = "BED SHEET",
                            Price = 34.99m,
                            Sold = true,
                            Spotlight = false,
                            UserId = 2
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 3,
                            DatePosted = new DateTime(2020, 7, 20, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "The quick, brown fox jumps over a lazy dog. DJs flock by when MTV ax quiz prog. Junk MTV quiz graced by fox whelps. Bawds jog, flick quartz, vex nymphs. Waltz, bad nymph, for",
                            Image = "~/Image/games.png",
                            Name = "XBOX ONE GAMES",
                            Price = 7200.99m,
                            Sold = true,
                            Spotlight = false,
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Flocker.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg",
                            Username = "Test Dummy"
                        },
                        new
                        {
                            UserId = 2,
                            Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg",
                            Username = "Bob Marley"
                        },
                        new
                        {
                            UserId = 3,
                            Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg",
                            Username = "Jack Danny"
                        },
                        new
                        {
                            UserId = 4,
                            Image = "https://a.wattpad.com/cover/148493833-288-k395634.jpg",
                            Username = "Easter Egg"
                        });
                });

            modelBuilder.Entity("Flocker.Models.Comment", b =>
                {
                    b.HasOne("Flocker.Models.Product", null)
                        .WithMany("Comment")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Flocker.Models.Product", b =>
                {
                    b.HasOne("Flocker.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Flocker.Models.User", "Owner")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
