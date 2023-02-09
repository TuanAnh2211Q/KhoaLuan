using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebQLCHTAN.Models
{
    public partial class QLCHTANDBContext : DbContext
    {
        public QLCHTANDBContext()
            : base("name=QLCHTANDBContext")
        {
        }

        public virtual DbSet<ChucDanh> ChucDanh { get; set; }
        public virtual DbSet<DanhGia> DanhGia { get; set; }
        public virtual DbSet<DatHang> DatHang { get; set; }
        public virtual DbSet<DoAn> DoAn { get; set; }
        public virtual DbSet<DonHang> DonHang { get; set; }
        public virtual DbSet<GioHang> GioHang { get; set; }
        public virtual DbSet<HinhThucThanhToan> HinhThucThanhToan { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhoBan> KhoBan { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<LoaiDoAn> LoaiDoAn { get; set; }
        public virtual DbSet<LoaiDonHang> LoaiDonHang { get; set; }
        public virtual DbSet<LoaiKhachHang> LoaiKhachHang { get; set; }
        public virtual DbSet<LoaiKhuyenMai> LoaiKhuyenMai { get; set; }
        public virtual DbSet<LoaiNhanVien> LoaiNhanVien { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public virtual DbSet<MatHang> MatHang { get; set; }
        public virtual DbSet<NuocUong> NuocUong { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<NhapKho> NhapKho { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyen { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }
        public virtual DbSet<TaiKhoanNhanVien> TaiKhoanNhanVien { get; set; }
        public virtual DbSet<ThongTinDatHang> ThongTinDatHang { get; set; }
        public virtual DbSet<ThongTinDoAn> ThongTinDoAn { get; set; }
        public virtual DbSet<ThongTinDonHang> ThongTinDonHang { get; set; }
        public virtual DbSet<ThongTinHangTon> ThongTinHangTon { get; set; }
        public virtual DbSet<ThongTinNhapKho> ThongTinNhapKho { get; set; }
        public virtual DbSet<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAn { get; set; }
        public virtual DbSet<ThongTinTraHang> ThongTinTraHang { get; set; }
        public virtual DbSet<ThongTinXuatKho> ThongTinXuatKho { get; set; }
        public virtual DbSet<TraHang> TraHang { get; set; }
        public virtual DbSet<XuatKho> XuatKho { get; set; }

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

            modelBuilder.Entity<DatHang>()
                .HasMany(e => e.ThongTinDatHang)
                .WithRequired(e => e.DatHang)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.ThongTinThanhPhanDoAn)
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
                .HasMany(e => e.ThongTinDonHang)
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
                .HasMany(e => e.ThongTinDatHang)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasOptional(e => e.ThongTinHangTon)
                .WithRequired(e => e.MatHang);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ThongTinNhapKho)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ThongTinThanhPhanDoAn)
                .WithRequired(e => e.MatHang)
                .HasForeignKey(e => e.maThanhPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ThongTinTraHang)
                .WithRequired(e => e.MatHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MatHang>()
                .HasMany(e => e.ThongTinXuatKho)
                .WithRequired(e => e.MatHang)
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
                .HasMany(e => e.TaiKhoanNhanVien)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.tenTaiKhoan);

            modelBuilder.Entity<NhapKho>()
                .Property(e => e.maNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NhapKho>()
                .Property(e => e.maDatHang)
                .IsUnicode(false);

            modelBuilder.Entity<NhapKho>()
                .HasMany(e => e.ThongTinNhapKho)
                .WithRequired(e => e.NhapKho)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.ThongTinDonHang)
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

            modelBuilder.Entity<ThongTinDatHang>()
                .Property(e => e.maDatHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDatHang>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDatHang>()
                .Property(e => e.maNCC)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinDatHang>()
                .Property(e => e.tongDonGia)
                .HasPrecision(19, 4);

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

            modelBuilder.Entity<ThongTinNhapKho>()
                .Property(e => e.maNhap)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNhapKho>()
                .Property(e => e.maNCC)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNhapKho>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinNhapKho>()
                .Property(e => e.tongDonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinThanhPhanDoAn>()
                .Property(e => e.maThanhPhan)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinThanhPhanDoAn>()
                .Property(e => e.maDoAn)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinTraHang>()
                .Property(e => e.maTra)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinTraHang>()
                .Property(e => e.maNCC)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinTraHang>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinTraHang>()
                .Property(e => e.tongDonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ThongTinXuatKho>()
                .Property(e => e.maXuat)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinXuatKho>()
                .Property(e => e.maHang)
                .IsUnicode(false);

            modelBuilder.Entity<ThongTinXuatKho>()
                .Property(e => e.tongDonGia)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TraHang>()
                .Property(e => e.maTra)
                .IsUnicode(false);

            modelBuilder.Entity<TraHang>()
                .Property(e => e.maDatHang)
                .IsUnicode(false);

            modelBuilder.Entity<TraHang>()
                .HasMany(e => e.ThongTinTraHang)
                .WithRequired(e => e.TraHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<XuatKho>()
                .Property(e => e.maXuat)
                .IsUnicode(false);

            modelBuilder.Entity<XuatKho>()
                .HasMany(e => e.ThongTinXuatKho)
                .WithRequired(e => e.XuatKho)
                .WillCascadeOnDelete(false);
        }
    }
}
