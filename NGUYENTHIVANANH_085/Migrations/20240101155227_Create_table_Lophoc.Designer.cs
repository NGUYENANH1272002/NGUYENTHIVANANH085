﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NGUYENTHIVANANH_085.Data;

#nullable disable

namespace NGUYENTHIVANANH_085.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20240101155227_Create_table_Lophoc")]
    partial class Create_table_Lophoc
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("NGUYENTHIVANANH_085.Models.Lophoc", b =>
                {
                    b.Property<int>("Malop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tenlop")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Malop");

                    b.ToTable("Lophocs");
                });
#pragma warning restore 612, 618
        }
    }
}
