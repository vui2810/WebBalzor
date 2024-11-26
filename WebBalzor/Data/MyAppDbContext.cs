using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Intenr.Models;
using BaiThucTap.Models;
using WebBalzor.Models;

namespace WebBalzor.Data
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext (DbContextOptions<MyAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Intenr.Models.DonViTinh> DonViTinh { get; set; } = default!;
        public DbSet<BaiThucTap.Models.LoaiSanPham> LoaiSanPham { get; set; } = default!;
        public DbSet<Intenr.Models.SanPham> SanPham { get; set; } = default!;
        public DbSet<Intenr.Models.NhaCungCap> NhaCungCap { get; set; } = default!;
        public DbSet<WebBalzor.Models.DM_Kho> DM_Kho { get; set; } = default!;
        public DbSet<WebBalzor.Models.DM_Kho_User> DM_Kho_User { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DM_Kho_User>()
                .HasIndex(u => new { u.Ma_Dang_Nhap, u.Kho_ID })
                .IsUnique();
        }
        public DbSet<WebBalzor.Models.NhapKho> DM_Nhap_Kho { get; set; } = default!;
    }
}
