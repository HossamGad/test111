﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt.Models;

namespace Projekt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200226114229_New123")]
    partial class New123
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Projekt.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Sovrum"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Badrum"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Vardagsrum"
                        });
                });

            modelBuilder.Entity("Projekt.Models.NyProdukt", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdukterProduktId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.HasIndex("ProdukterProduktId");

                    b.ToTable("DbNyProdukt");
                });

            modelBuilder.Entity("Projekt.Models.Produkter", b =>
                {
                    b.Property<int>("ProduktId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("ProductOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProduktId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Produkter");

                    b.HasData(
                        new
                        {
                            ProduktId = 1,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.112861/missoni-home-handduk-giacomo-70x115-cm.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.112861/missoni-home-handduk-giacomo-70x115-cm.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Golv som passar till vardagsrum, och är inspirerat av ett tyg från Missoni och har ett distinkt grafiskt mönster med en flödande gradient, presenterad i tidlöst svart. ",
                            Name = "Golv(Missoni Home)",
                            Price = 56.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Missoni Home"
                        },
                        new
                        {
                            ProduktId = 2,
                            CategoryId = 2,
                            ImageThumbnailUrl = " https://www.systerlycklig.se/images/2.111554/designers-guild-matta-eberson-cobalt-160x260-cm.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.111554/designers-guild-matta-eberson-cobalt-160x260-cm.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Ett varmt, taktilt golv med en handgjord känsla – dåtid möter nutid i en svart/grå nyans. ",
                            Name = "Golv(Artisan - Coal)",
                            Price = 76.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Artisan - Coal"
                        },
                        new
                        {
                            ProduktId = 3,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.115904/designers-guild-matta-caretti-linen-160x260-cm.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.115904/designers-guild-matta-caretti-linen-160x260-cm.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Ett golv inspirerat av Sisalmattor, med en mjuk, strukturerad och ändå slitstark känsla. ",
                            Name = "Golv(BKB - Metallic Alpha)",
                            Price = 83.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "BKB - Metallic Alpha"
                        },
                        new
                        {
                            ProduktId = 4,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.115969/designers-guild-matta-ashbee-berry-250x350-cm.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.115969/designers-guild-matta-ashbee-berry-250x350-cm.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Glow är en mörk, svartblå matta med kopparinslag. Mattan är producerad i vårt egna originalmaterial av vinyl som förstärkts genom att addera ull och glittrigt garn. ",
                            Name = "Matta(Duet - Duet Glow)",
                            Price = 83.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Duet - Duet Glow"
                        },
                        new
                        {
                            ProduktId = 5,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.153034/designers-guild-matta-castillion-fuchsia-160x260-cm.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.153034/designers-guild-matta-castillion-fuchsia-160x260-cm.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Matta Castillion Fuchsia från Designers Guild är en handvävd matta med modernt diagonalt rutmönster. ",
                            Name = "Matta(Castillion Fuchsia)",
                            Price = 105.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Castillion Fuchsia"
                        },
                        new
                        {
                            ProduktId = 6,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.110160/missoni-home-badrumsmatta-giacomo.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.110160/missoni-home-badrumsmatta-giacomo.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "Badrumsmatta Giacomo från italienska Missoni med klassiskt zickzackmönster. ",
                            Name = "Matta(Giacomo)",
                            Price = 116.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Giacomo"
                        },
                        new
                        {
                            ProduktId = 7,
                            CategoryId = 3,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.199538/sandberg-tapet-hannes-morkbla.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.199538/sandberg-tapet-hannes-morkbla.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "En slitstark och vacker klinker i grå nyanser och naturliga marmoreringar. ",
                            Name = "Marmor(Aura Marengo Blank )",
                            Price = 610.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Aura Marengo Blank "
                        },
                        new
                        {
                            ProduktId = 8,
                            CategoryId = 1,
                            ImageThumbnailUrl = "https://www.systerlycklig.se/images/2.199595/sandberg-tapet-hannes-svart.jpeg",
                            ImageUrl = "https://www.systerlycklig.se/images/2.199595/sandberg-tapet-hannes-svart.jpeg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = "marmorerad granitkeramik i grå nyanser. Dramatiskt mönster med känsla av mörka moln som hopar sig. ",
                            Name = "Marmor(Alvesta Assos Grey Matt)",
                            Price = 568.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Alvesta Assos Grey Matt"
                        },
                        new
                        {
                            ProduktId = 9,
                            CategoryId = 2,
                            ImageThumbnailUrl = "https://cdn.cdon.com/media-dynamic/images/product/kidsbaby/kidsbabydefault/image838/kakel_d-sign_metro_marquina_10x20-49323698-69612507-xtra1.jpg",
                            ImageUrl = "https://cdn.cdon.com/media-dynamic/images/product/kidsbaby/kidsbabydefault/image838/kakel_d-sign_metro_marquina_10x20-49323698-69612507-xtra1.jpg",
                            InStock = false,
                            IsProductOfTheWeek = false,
                            LongDescription = " slät yta och marmor-känsla. Ger en exklusiv och vacker vägg. ",
                            Name = "Marmor(Marquina )",
                            Price = 428.95m,
                            ProductOfTheWeek = false,
                            ShortDescription = "Marquina "
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Projekt.Models.NyProdukt", b =>
                {
                    b.HasOne("Projekt.Models.Produkter", null)
                        .WithMany("Nyproduktlist")
                        .HasForeignKey("ProdukterProduktId");
                });

            modelBuilder.Entity("Projekt.Models.Produkter", b =>
                {
                    b.HasOne("Projekt.Models.Category", "Category")
                        .WithMany("Produkter")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
