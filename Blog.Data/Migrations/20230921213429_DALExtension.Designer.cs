﻿// <auto-generated />
using System;
using Blog.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230921213429_DALExtension")]
    partial class DALExtension
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            Id = new Guid("1b2a7db6-c7fb-40c5-8bfc-ed69e0c1309c"),
                            CategoryId = new Guid("e2caf291-90f4-4c56-977c-ecedd4be6f35"),
                            Content = " Asp.net Core Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(295),
                            ImageId = new Guid("e4304cd3-09ee-4eab-b23e-b25160cbacad"),
                            IsDeleted = false,
                            Title = "Asp.net Core Deneme Makalesi 1",
                            ViewCount = 15
                        },
                        new
                        {
                            Id = new Guid("7e323924-e7f6-41e8-91b3-500c2b7683cb"),
                            CategoryId = new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"),
                            Content = " Ders Deneme Lorem ipsum dolor sit amet consectetur adipiscing elit nullam at, proin curabitur orci dignissim lacinia ac mollis primis, odio quisque dis fermentum ad risus tortor sagittis. Porttitor class eu id fames suspendisse lacus praesent, urna cras dictum eget parturient duis habitant cum, aenean suscipit risus mi hendrerit dictumst. Augue rhoncus et ante himenaeos ullamcorper vehicula aliquam, class eu consequat gravida dapibus mollis, dignissim varius sem neque dui luctus. A justo convallis quisque hac eu scelerisque urna sodales inceptos, fermentum auctor vehicula dapibus massa himenaeos rhoncus netus facilisi, dictumst per nam nibh blandit tempor diam lectus.",
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(318),
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
                            CreatedDate = new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1101),
                            IsDeleted = false,
                            Name = "ASP.NET Core"
                        },
                        new
                        {
                            Id = new Guid("176abc05-4f2a-449c-841c-b292125cdcd6"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1116),
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
                            CreatedDate = new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1561),
                            FileName = "images/testimage",
                            FileType = "png",
                            IsDeleted = false
                        },
                        new
                        {
                            Id = new Guid("a46c0151-17c7-47f6-9e84-73699d6fc018"),
                            CreatedBy = "Admin Test",
                            CreatedDate = new DateTime(2023, 9, 22, 0, 34, 29, 133, DateTimeKind.Local).AddTicks(1574),
                            FileName = "images/testimage",
                            FileType = "png",
                            IsDeleted = false
                        });
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
