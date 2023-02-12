using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VEB.Models
{
    public partial class DBQLCHTAN : DbContext
    {
        public DBQLCHTAN()
            : base("name=DBQLCHTAN")
        {
        }
        

        public virtual DbSet<ChucDanh> ChucDanhs { get; set; }
        public virtual DbSet<DanhGia> DanhGias { get; set; }
        public virtual DbSet<DatHang> DatHangs { get; set; }
        public virtual DbSet<DoAn> DoAns { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HinhThucThanhToan> HinhThucThanhToans { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhoBan> KhoBans { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<LoaiDoAn> LoaiDoAns { get; set; }
        public virtual DbSet<LoaiDonHang> LoaiDonHangs { get; set; }
        public virtual DbSet<LoaiKhachHang> LoaiKhachHangs { get; set; }
        public virtual DbSet<LoaiKhuyenMai> LoaiKhuyenMais { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanViens { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<MatHang> MatHangs { get; set; }
        public virtual DbSet<NuocUong> NuocUongs { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }
        public virtual DbSet<ThongTinDoAn> ThongTinDoAns { get; set; }
        public virtual DbSet<ThongTinDonHang> ThongTinDonHangs { get; set; }
        public virtual DbSet<ThongTinHangTon> ThongTinHangTons { get; set; }
        public virtual DbSet<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChucDanh>()
                .Property(e => e.maChucDanh)
                .IsUnicode(false);

            modelBuilder.Entity<DanhGia>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<DatHang>()
                .Property(e => e.maDatHang)
                .IsUnicode(false);

            modelBuilder.Entity<DoAn>()
                .Property(e => e.maDoAn)
                .IsUnicode(false);

            modelBuilder.Entity<DoAn>()
                .Property(e => e.maLoaiDoAn)
                .IsUnicode(false);

            modelBuilder.Entity<DoAn>()
                .HasOptional(e => e.ThongTinDoAn)
                .WithRequired(e => e.DoAn);

            modelBuilder.Entity<DoAn>()
                .HasMany(e => e.ThongTinThanhPhanDoAns)
                .WithRequired(e => e.DoAn)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.maDonHang)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.maLoaiDon)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.SDTKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.maKhuyenMai)
                .IsUnicode(false);

            modelBuilder.Entity<DonHang>()
                .Property(e => e.tongGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<DonHang>()
                .HasMany(e => e.ThongTinDonHangs)
                .WithRequired(e => e.DonHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.maGioHang)
                .IsUnicode(false);

            modelBuilder.Entity<GioHang>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.maLoaiKhach)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .HasOptional(e => e.DanhGia)
                .WithRequired(e => e.KhachHang);

            modelBuilder.Entity<KhoBan>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhoBan>()
                .Property(e => e.tongGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.maKhuyenMai)
                .IsUnicode(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.maLoaiKhuyenMai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiDoAn>()
                .Property(e => e.maLoaiDoAn)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiDonHang>()
                .Property(e => e.maLoaiDon)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiKhachHang>()
                .Property(e => e.maLoaiKhach)
                .IsFixedLength();

            modelBuilder.Entity<LoaiKhuyenMai>()
                .Property(e => e.maLoaiKhuyenMai)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiNhanVien>()
                .Property(e => e.maLoaiNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSanPham>()
                .Property(e => e.maLoaiSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.maNCC)
                .IsUnicode(false);

            modelBuilder.Entity<MatHang>()
                .Property(e => e.donGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MatHang>()
                .HasOptional(e => e.KhoBan)
                .WithRequired(e => e.MatHang);

            modelBuilder.Entity<MatHang>()
                .HasOptional(e => e.NuocUong)
                .WithRequired(e => e.MatHang);

            modelBuilder.Entity<MatHang>()
                .HasOptional(e => e.ThongTinHangTon)
                .WithRequired(e => e.MatHang);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ThongTinThanhPhanDoAns)
                .WithRequired(e => e.MatHang)
                .HasForeignKey(e => e.maThanhPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NuocUong>()
                .Property(e => e.maNuoc)
                .IsUnicode(false);

            modelBuilder.Entity<NuocUong>()
                .Property(e => e.giaBanNuoc)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.maNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.emailNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.sdtNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maChucDanh)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maLoaiNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.TaiKhoanNhanViens)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.tenTaiKhoan);

            modelBuilder.Entity<PhanQuyen>()
                .Property(e => e.maQuyen)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .Property(e => e.maLoaiSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SanPham>()
                .HasOptional(e => e.DoAn)
                .WithRequired(e => e.SanPham);

            modelBuilder.Entity<SanPham>()
                .HasOptional(e => e.NuocUong)
                .WithRequired(e => e.SanPham);

            modelBuilder.Entity<SanPham>()
                .HasMany(e => e.ThongTinDonHangs)
                .WithRequired(e => e.SanPham)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .Property(e => e.tenTaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanNhanVien>()
                .Property(e => e.maQuyen)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDoAn>()
                .Property(e => e.maDoAn)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDoAn>()
                .Property(e => e.donGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinDonHang>()
                .Property(e => e.maDonHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDonHang>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDonHang>()
                .Property(e => e.giaTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinDonHang>()
                .Property(e => e.thanhTien)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinHangTon>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinHangTon>()
                .Property(e => e.tongDonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinThanhPhanDoAn>()
                .Property(e => e.maThanhPhan)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinThanhPhanDoAn>()
                .Property(e => e.maDoAn)
                .IsUnicode(false);
        }

      
    }
}
