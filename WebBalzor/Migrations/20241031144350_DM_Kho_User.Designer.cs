﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebBalzor.Data;

#nullable disable

namespace WebBalzor.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20241031144350_DM_Kho_User")]
    partial class DM_Kho_User
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BaiThucTap.Models.LoaiSanPham", b =>
                {
                    b.Property<string>("Ma_LSP")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghi_Chu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_LSP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_LSP");

                    b.ToTable("LoaiSanPham");
                });

            modelBuilder.Entity("Intenr.Models.DonViTinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ghi_Chu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_Don_Vi_Tinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DonViTinh");
                });

            modelBuilder.Entity("Intenr.Models.NhaCungCap", b =>
                {
                    b.Property<int>("Ma_NCC")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Ma_NCC"));

                    b.Property<string>("Ghi_Chu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_NCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_NCC");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("Intenr.Models.SanPham", b =>
                {
                    b.Property<string>("Ma_San_Pham")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Don_Vi_Tinh_ID")
                        .HasColumnType("int");

                    b.Property<string>("Ghi_Chu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Loai_San_Pham_Id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten_San_Pham")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ma_San_Pham");

                    b.ToTable("SanPham");
                });

            modelBuilder.Entity("WebBalzor.Models.DM_Kho", b =>
                {
                    b.Property<string>("Ten_Kho")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghi_Chu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Ten_Kho");

                    b.ToTable("DM_Kho");
                });

            modelBuilder.Entity("WebBalzor.Models.DM_Kho_User", b =>
                {
                    b.Property<string>("Ma_Dang_Nhap")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Kho_ID")
                        .HasColumnType("int");

                    b.HasKey("Ma_Dang_Nhap");

                    b.ToTable("DM_Kho_User");
                });
#pragma warning restore 612, 618
        }
    }
}
