﻿// <auto-generated />
using Book.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Book.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Book.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Book.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "泰絲．格里森",
                            Description = "一日間諜，一世間諜",
                            ISBN = "9789577419057",
                            ListPrice = 520.0,
                            Price = 410.0,
                            Price100 = 410.0,
                            Price50 = 410.0,
                            Title = "間諜海岸"
                        },
                        new
                        {
                            Id = 2,
                            Author = "東野圭吾",
                            Description = "‖他的謊言，是操弄人心的陷阱，\r\n　　‖也能召喚她們的覺醒──",
                            ISBN = "9789573341802",
                            ListPrice = 480.0,
                            Price = 379.0,
                            Price100 = 379.0,
                            Price50 = 379.0,
                            Title = "謊言裡的魔術師"
                        },
                        new
                        {
                            Id = 3,
                            Author = "胡展詰",
                            Description = "絕大多數的問題行為，都源自於情緒問題。\r\n　　你可以陪伴孩子，學習覺察情緒、安頓情緒， \r\n　　讓情緒如溪水般潺潺流動……",
                            ISBN = "9786263618268",
                            ListPrice = 380.0,
                            Price = 300.0,
                            Price100 = 300.0,
                            Price50 = 300.0,
                            Title = "情緒流動"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
