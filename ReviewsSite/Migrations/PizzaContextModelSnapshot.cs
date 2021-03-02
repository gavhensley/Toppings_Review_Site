﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewsSite;

namespace ReviewsSite.Migrations
{
    [DbContext(typeof(PizzaContext))]
    partial class PizzaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ReviewContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewScore")
                        .HasColumnType("int");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToppingsId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("ToppingsId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            ReviewContent = "If it isn't Doge coin... At least it's shaped like a coin. #SpaceX",
                            ReviewScore = 4,
                            ReviewerName = "Elon Musk",
                            ToppingsId = 1
                        },
                        new
                        {
                            ReviewId = 2,
                            ReviewContent = "Ruh Ro Raggy! Resse Aren't Scooby Snacks!!!",
                            ReviewScore = 2,
                            ReviewerName = "Scooby Doo",
                            ToppingsId = 2
                        },
                        new
                        {
                            ReviewId = 3,
                            ReviewContent = "The only thing better than this topping is the review(Site)",
                            ReviewScore = 5,
                            ReviewerName = "Carlos Lopez",
                            ToppingsId = 1
                        },
                        new
                        {
                            ReviewId = 4,
                            ReviewContent = "Pika Pika, Pikachu!",
                            ReviewScore = 1,
                            ReviewerName = "Pikachu",
                            ToppingsId = 2
                        },
                        new
                        {
                            ReviewId = 5,
                            ReviewContent = "I like my sausage bulky, like me.",
                            ReviewScore = 5,
                            ReviewerName = "Dwayne 'The Rock' Johnson",
                            ToppingsId = 3
                        },
                        new
                        {
                            ReviewId = 6,
                            ReviewContent = "Better than pepperoni.",
                            ReviewScore = 4,
                            ReviewerName = "Davis Murphy",
                            ToppingsId = 3
                        },
                        new
                        {
                            ReviewId = 7,
                            ReviewContent = "I love pineapple so much that I live in one.",
                            ReviewScore = 5,
                            ReviewerName = "SpongeBob SquarePants",
                            ToppingsId = 4
                        },
                        new
                        {
                            ReviewId = 8,
                            ReviewContent = "I hate pineapples because my neighbor lives in one.",
                            ReviewScore = 0,
                            ReviewerName = "Squidward Tentacles",
                            ToppingsId = 4
                        },
                        new
                        {
                            ReviewId = 9,
                            ReviewContent = "It sucks.  It's Great!",
                            ReviewScore = 3,
                            ReviewerName = "CatDog",
                            ToppingsId = 5
                        },
                        new
                        {
                            ReviewId = 10,
                            ReviewContent = "I always need more.",
                            ReviewScore = 4,
                            ReviewerName = "Clifford The Big Red Dog",
                            ToppingsId = 5
                        },
                        new
                        {
                            ReviewId = 11,
                            ReviewContent = "MUSHROOMS!",
                            ReviewScore = 5,
                            ReviewerName = "Peregrin 'Pippin' Took",
                            ToppingsId = 6
                        },
                        new
                        {
                            ReviewId = 12,
                            ReviewContent = "Zoinks Scoob! Like, sign me up for more man.",
                            ReviewScore = 5,
                            ReviewerName = "Shaggy",
                            ToppingsId = 6
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Toppings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Toppings");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Pepperoni is an American variety of salami, made from cured pork and beef seasoned with paprika or other chili pepper.",
                            Img = "Pepperoni.png",
                            IsVegetarian = false,
                            Name = "Pepperoni"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The mild-flavored, unripe fruit of the bell or sweet pepper, Capsicum annuum grossum, used as a green vegetable.",
                            Img = "GPepper.png",
                            IsVegetarian = true,
                            Name = "Green Pepper"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Coarsely ground pork (and sometimes beef) with fennel, also known as “mild” Italian sausage.",
                            Img = "Sausage.png",
                            IsVegetarian = false,
                            Name = "Sausage"
                        },
                        new
                        {
                            Id = 4,
                            Description = "A large juicy tropical fruit consisting of aromatic edible yellow flesh surrounded by a tough segmented skin and topped with a tuft of stiff leaves.",
                            Img = "Pineapple.png",
                            IsVegetarian = true,
                            Name = "Pineapple"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Bacon is a type of salt-cured pork made from various cuts, typically from the pork belly or from the less fatty back cuts.",
                            Img = "Bacon.png",
                            IsVegetarian = false,
                            Name = "Bacon"
                        },
                        new
                        {
                            Id = 6,
                            Description = "An enlarged complex aboveground fleshy fruiting body of a fungus (such as a basidiomycete) that consists typically of a stem bearing a pileus.",
                            Img = "Mushroom.png",
                            IsVegetarian = true,
                            Name = "Mushrooms"
                        });
                });

            modelBuilder.Entity("ReviewsSite.Models.Review", b =>
                {
                    b.HasOne("ReviewsSite.Models.Toppings", "Toppings")
                        .WithMany("Reviews")
                        .HasForeignKey("ToppingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Toppings");
                });

            modelBuilder.Entity("ReviewsSite.Models.Toppings", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
