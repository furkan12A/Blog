﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entity.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("d9795d58-a7b5-4546-a9f9-252c9203918c"),
                            ConcurrencyStamp = "942f03fc-d920-4719-ae65-215690c4edc1",
                            Name = "Superadmin",
                            NormalizedName = "SUPERADMİN"
                        },
                        new
                        {
                            Id = new Guid("a08b4329-ab58-4053-ab14-0ef2ab0de26d"),
                            ConcurrencyStamp = "339b69ae-f6ae-4f88-9f6a-a5914e683bf5",
                            Name = "Admin",
                            NormalizedName = "ADMİN"
                        },
                        new
                        {
                            Id = new Guid("010dd980-6272-4879-b1df-4452f6951b25"),
                            ConcurrencyStamp = "47be6119-f098-49f2-aba8-c8fdf2a808ac",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("80a80476-1989-4ff1-98b4-4ed30250624d"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7b8ccf0-ec60-48ba-9d3d-59b6cd6904d0",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Furkan",
                            LastName = "Ayaoku",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMİN@GMAİL.COM",
                            NormalizedUserName = "SUPERADMİN@GMAİL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAECP8FWPw6aN7s9XSbeRoFzmPPWmoXhKtpqRHpVRS4w3EEoIppOs/uF4uoaIJlEEKwQ==",
                            PhoneNumber = "+905375756282",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "fb38e4b8-a6da-4a9e-98d4-f6b0290a1cd4",
                            TwoFactorEnabled = false,
                            UserName = "superadmin@gmail.com"
                        },
                        new
                        {
                            Id = new Guid("3311dd66-bffd-400d-98f3-604018fb08b0"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "9f9fab69-a0e1-4dcb-9b31-7780313789b5",
                            Email = "admin@gmail.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMİN@GMAİL.COM",
                            NormalizedUserName = "ADMİN@GMAİL.COM",
                            PhoneNumber = "+905375756281",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6445a0fb-e769-465a-a49e-c1988471370b",
                            TwoFactorEnabled = false,
                            UserName = "admin@gmail.com"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = new Guid("80a80476-1989-4ff1-98b4-4ed30250624d"),
                            RoleId = new Guid("d9795d58-a7b5-4546-a9f9-252c9203918c")
                        },
                        new
                        {
                            UserId = new Guid("80a80476-1989-4ff1-98b4-4ed30250624d"),
                            RoleId = new Guid("a08b4329-ab58-4053-ab14-0ef2ab0de26d")
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserToken", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ImageId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ImageId");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6ed7b4f7-1bc7-4402-a358-4027cb08e22f"),
                            CategoryId = new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"),
                            Content = " Asp.net Core Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 23, 1, 57, 7, 671, DateTimeKind.Local).AddTicks(56),
                            ImageId = new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("b4196121-1570-447c-8aa1-e35b2cf22dfa"),
                            CategoryId = new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"),
                            Content = " Ders Deneme Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 23, 1, 57, 7, 671, DateTimeKind.Local).AddTicks(64),
                            ImageId = new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"),
                            IsDeleted = false,
                            Title = "Ders Deneme  Makalesi 1",
                            ViewCount = 15
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 23, 1, 57, 7, 671, DateTimeKind.Local).AddTicks(1817),
                            IsDeleted = false,
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 23, 1, 57, 7, 671, DateTimeKind.Local).AddTicks(1821),
                            IsDeleted = false,
                            Name = "Ders Deneme"
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DeletedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 23, 1, 57, 7, 671, DateTimeKind.Local).AddTicks(2099),
                            FileName = "images/testimage",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 23, 1, 57, 7, 671, DateTimeKind.Local).AddTicks(2113),
                            FileName = "images/testimage",
                            FileType = "png",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppRoleClaim", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserClaim", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserLogin", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserRole", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.AppUserToken", b =>
                {
                    b.HasOne("Blog.Entity.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Blog.Entity.Entities.Article", b =>
                {
                    b.HasOne("Blog.Entity.Entities.Category", "Category")
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entity.Entities.Image", "Image")
                        .WithMany("Articles")
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Blog.Entity.Entities.Image", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
