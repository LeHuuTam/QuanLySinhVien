using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLySinhVien.Data
{
    public partial class QuanLySinhVienDbContext : DbContext
    {
        public QuanLySinhVienDbContext()
            : base("name=QuanLySinhVienDbContext")
        {
        }

        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<Diem>()
                .Property(e => e.MaSV)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MaGV)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.GiangViens)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.MonHocs)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Khoa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaGV)
                .IsUnicode(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.Lop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.Lops)
                .WithRequired(e => e.MonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Quyen>()
                .HasMany(e => e.TaiKhoans)
                .WithRequired(e => e.Quyen1)
                .HasForeignKey(e => e.Quyen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaKhoa)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Diems)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.TenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);
        }
    }
}
