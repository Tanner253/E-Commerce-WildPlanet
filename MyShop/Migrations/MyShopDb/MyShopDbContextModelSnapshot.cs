﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShop.data;

namespace MyShop.Migrations.MyShopDb
{
    [DbContext(typeof(MyShopDbContext))]
    partial class MyShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyShop.Models.Basket", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TotalItems");

                    b.Property<double>("TotalPrice");

                    b.Property<string>("UserName");

                    b.HasKey("ID");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("MyShop.Models.BasketItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BasketID");

                    b.Property<double>("LineItemAmount");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("BasketID");

                    b.HasIndex("ProductID");

                    b.ToTable("BasketItems");
                });

            modelBuilder.Entity("MyShop.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<double>("GrandTotal");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyShop.Models.OrderItems", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderID");

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("MyShop.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AmmountLeft");

                    b.Property<string>("Description");

                    b.Property<string>("ImageAnimal");

                    b.Property<string>("ImageStuffedAnimal");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<string>("Summary");

                    b.HasKey("ID");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AmmountLeft = 43,
                            Description = "Name a pangolin and receive a plush.",
                            ImageAnimal = "http://yesofcorsa.com/wp-content/uploads/2017/06/Pangolin-Best-Wallpaper-1024x646.jpg",
                            ImageStuffedAnimal = "https://images-na.ssl-images-amazon.com/images/I/7194O4jEGnL._SY355_.jpg",
                            Name = "Pangolin",
                            Price = 2400.0,
                            Summary = "Large-scale trafficking is driven by a belief in pangolins’ magical and curative properties and a demand for their meat. When mixed with bark from certain trees, the scales are thought to neutralize witchcraft and evil spirits. If buried near a man’s door they are said to give an interested woman power over him. The smoke from their scales is thought to improve cattle health, keep lions away, and cure ailments like nose-bleeds.  Although their scales are made of keratin—the same substance that makes up human hair and nails—they are in high demand in certain Asian countries where the scales are believed to cure illnesses ranging from cancer to asthma, and their meat is considered a delicacy. In some areas, tribes believe a pangolin sighting indicates there will be a drought and the only way to prevent it is by killing the animal."
                        },
                        new
                        {
                            ID = 2,
                            AmmountLeft = 43,
                            Description = "Name an Amur Leopard and receive a plush.",
                            ImageAnimal = "http://cdn.animalhi.com/2560x1600/20121027/animals%20leopards%20amur%20leopard%202560x1600%20wallpaper_www.animalhi.com_40.jpg",
                            ImageStuffedAnimal = "https://i.ebayimg.com/images/g/NQEAAOSwHntbmfbP/s-l300.jpg",
                            Name = "Amur Leopard",
                            Price = 2400.0,
                            Summary = "People usually think of leopards in the savannas of Africa but in the Russian Far East, a rare subspecies has adapted to life in the temperate forests that make up the northern-most part of the species’ range. Similar to other leopards, the Amur leopard can run at speeds of up to 37 miles per hour. This incredible animal has been reported to leap more than 19 feet horizontally and up to 10 feet vertically. The Amur leopard is solitary.Nimble - footed and strong, it carries and hides unfinished kills so that they are not taken by other predators.It has been reported that some males stay with females after mating, and may even help with rearing the young.Several males sometimes follow and fight over a female.They live for 10 - 15 years, and in captivity up to 20 years.The Amur leopard is also known as the Far East leopard, the Manchurian leopard or the Korean leopard."
                        },
                        new
                        {
                            ID = 3,
                            AmmountLeft = 43,
                            Description = "Name a Sumatran Orangutan and receive a plush.",
                            ImageAnimal = "https://ak8.picdn.net/shutterstock/videos/30904708/thumb/1.jpg",
                            ImageStuffedAnimal = "https://zoostore.zoo.org/media/catalog/product/cache/6b1c09900b407c50fce2db5e66ebc123/1/2/12250-orangutan.jpg",
                            Name = "Sumatran Orangutan",
                            Price = 2400.0,
                            Summary = "Temp"
                        },
                        new
                        {
                            ID = 4,
                            AmmountLeft = 43,
                            Description = "Name a Cross River Gorilla and receive a plush.",
                            ImageAnimal = "http://www.manyaratravel.com/wp-content/uploads/2015/04/Gorilla-with-baby.jpg",
                            ImageStuffedAnimal = "https://cdn3.volusion.com/9nxdj.fchy5/v/vspfiles/photos/AR-80431-2.jpg?1517907494",
                            Name = "Cross River Gorilla",
                            Price = 2400.0,
                            Summary = "Temp."
                        },
                        new
                        {
                            ID = 5,
                            AmmountLeft = 43,
                            Description = "Name a Hawksbill Sea Turtle and receive a plush.",
                            ImageAnimal = "https://voiceforthespeechless.com/wp-content/uploads/2017/02/hawksbill-seaturtle.png",
                            ImageStuffedAnimal = "https://i.ebayimg.com/images/g/rwkAAOSw2BxafjbF/s-l640.jpg",
                            Name = "Hawksbill Sea Turtle",
                            Price = 2400.0,
                            Summary = "Temp."
                        },
                        new
                        {
                            ID = 6,
                            AmmountLeft = 43,
                            Description = "Name a Sumatran Tiger and receive a plush.",
                            ImageAnimal = "https://www.waza.org/wp-content/uploads/2019/02/sumatran-tiger-wz-gsmp-m.jpg",
                            ImageStuffedAnimal = "https://image.dhgate.com/0x0s/f2-albu-g7-M01-75-01-rBVaSlsWKw2AZsz_AANSc4-UmmA074.jpg/raj-the-sumatran-tiger-19-inch-large-sumatran.jpg",
                            Name = "Sumatran Tiger",
                            Price = 2400.0,
                            Summary = "Temp."
                        },
                        new
                        {
                            ID = 7,
                            AmmountLeft = 43,
                            Description = "Name a Black Rhino and receive a plush.",
                            ImageAnimal = "https://www.helpingrhinos.org/userfiles/helpingrhinos.org/About%20Rhinos/Black-Rhino3-9-flip.jpg",
                            ImageStuffedAnimal = "https://images-na.ssl-images-amazon.com/images/I/71M7U89W78L._SX425_.jpg",
                            Name = "Black Rhino",
                            Price = 2400.0,
                            Summary = "Temp."
                        },
                        new
                        {
                            ID = 8,
                            AmmountLeft = 43,
                            Description = "Name a Snow Leopard and receive a plush.",
                            ImageAnimal = "https://k6u8v6y8.stackpathcdn.com/blog/wp-content/uploads/2019/01/Snow-Leopard.jpg",
                            ImageStuffedAnimal = "https://gifts.worldwildlife.org/gift-center/images/species-adoptions/Snow-Leopard/Snow-Leopard-plush-z1.jpg",
                            Name = "Snow Leopard",
                            Price = 2400.0,
                            Summary = "Temp."
                        },
                        new
                        {
                            ID = 9,
                            AmmountLeft = 43,
                            Description = "Name a Polar Bear and receive a plush.",
                            ImageAnimal = "https://media.treehugger.com/assets/images/2018/10/polar-bear-kid.jpg.860x0_q70_crop-scale.jpg",
                            ImageStuffedAnimal = "https://images-na.ssl-images-amazon.com/images/I/611900XLxiL._SX425_.jpg",
                            Name = "Polar Bear",
                            Price = 2400.0,
                            Summary = "Temp."
                        },
                        new
                        {
                            ID = 10,
                            AmmountLeft = 43,
                            Description = "Name a Giant Panda and receive a plush.",
                            ImageAnimal = "https://www.sciencenews.org/sites/default/files/2019/01/main/articles/013019_JR_panda-diet_feat.jpg",
                            ImageStuffedAnimal = "https://images-na.ssl-images-amazon.com/images/I/71rbxOLyUSL._SX425_.jpg",
                            Name = "Giant Panda",
                            Price = 2400.0,
                            Summary = "Temp."
                        });
                });

            modelBuilder.Entity("MyShop.Models.BasketItems", b =>
                {
                    b.HasOne("MyShop.Models.Basket")
                        .WithMany("BasketList")
                        .HasForeignKey("BasketID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyShop.Models.OrderItems", b =>
                {
                    b.HasOne("MyShop.Models.Order")
                        .WithMany("OrderList")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
