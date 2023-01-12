﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class CaLam
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public CaLam()
    {
        this.ChamCongs = new HashSet<ChamCong>();
    }

    public string maCaLam { get; set; }
    public string tenCaLam { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ChamCong> ChamCongs { get; set; }
}

public partial class ChamCong
{
    public string maNhanVien { get; set; }
    public Nullable<System.DateTime> ngayLam { get; set; }
    public Nullable<System.TimeSpan> gioVao { get; set; }
    public Nullable<System.TimeSpan> gioRa { get; set; }
    public string maCaLam { get; set; }
    public string ghiChu { get; set; }

    public virtual CaLam CaLam { get; set; }
    public virtual NhanVien NhanVien { get; set; }
}

public partial class ChucDanh
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ChucDanh()
    {
        this.NhanViens = new HashSet<NhanVien>();
    }

    public string maChucDanh { get; set; }
    public string tenChucDanh { get; set; }
    public Nullable<double> heSoLuong { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<NhanVien> NhanViens { get; set; }
}

public partial class DatHang
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DatHang()
    {
        this.NhapKhoes = new HashSet<NhapKho>();
        this.TraHangs = new HashSet<TraHang>();
    }

    public string maDatHang { get; set; }
    public Nullable<System.DateTime> ngayDatHang { get; set; }
    public Nullable<System.DateTime> ngayDuKienGiao { get; set; }
    public string ghiChu { get; set; }
    public string phuongThucThanhToan { get; set; }
    public Nullable<bool> trangThai { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<NhapKho> NhapKhoes { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TraHang> TraHangs { get; set; }
}

public partial class DoAn
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DoAn()
    {
        this.ThongTinThanhPhanDoAns = new HashSet<ThongTinThanhPhanDoAn>();
    }

    public string maDoAn { get; set; }
    public string maLoaiDoAn { get; set; }
    public string tenDoAn { get; set; }

    public virtual SanPham SanPham { get; set; }
    public virtual LoaiDoAn LoaiDoAn { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAns { get; set; }
}

public partial class DonHang
{
    public string maDonHang { get; set; }
    public string tenDonHang { get; set; }
    public string maLoaiDon { get; set; }
    public Nullable<bool> maHinhthuc { get; set; }
    public string maNhanVien { get; set; }
    public string SDTKhachHang { get; set; }
    public string maKhuyenMai { get; set; }
    public Nullable<System.DateTime> thoiGianDat { get; set; }
    public Nullable<int> trangThai { get; set; }
    public string ghiChu { get; set; }
    public Nullable<int> idKhachHang { get; set; }
    public Nullable<decimal> tongGia { get; set; }

    public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }
    public virtual KhachHang KhachHang { get; set; }
    public virtual KhuyenMai KhuyenMai { get; set; }
    public virtual LoaiDonHang LoaiDonHang { get; set; }
    public virtual NhanVien NhanVien { get; set; }
}

public partial class HinhThucThanhToan
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public HinhThucThanhToan()
    {
        this.DonHangs = new HashSet<DonHang>();
    }

    public bool maHinhThuc { get; set; }
    public string tenHinhThuc { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DonHang> DonHangs { get; set; }
}

public partial class KhachHang
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public KhachHang()
    {
        this.DonHangs = new HashSet<DonHang>();
    }

    public string tenKhachHang { get; set; }
    public string Phai { get; set; }
    public string SDT { get; set; }
    public string Email { get; set; }
    public string diaChi { get; set; }
    public string ghiChu { get; set; }
    public int idKhachHang { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DonHang> DonHangs { get; set; }
}

public partial class KhoBan
{
    public string maHang { get; set; }
    public Nullable<int> soLuong { get; set; }
    public Nullable<decimal> tongGia { get; set; }
    public string maXuat { get; set; }

    public virtual MatHang MatHang { get; set; }
    public virtual XuatKho XuatKho { get; set; }
}

public partial class KhuyenMai
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public KhuyenMai()
    {
        this.DonHangs = new HashSet<DonHang>();
        this.ThongTinKhuyenMais = new HashSet<ThongTinKhuyenMai>();
    }

    public string maKhuyenMai { get; set; }
    public string tenKhuyenMai { get; set; }
    public string maLoaiKhuyenMai { get; set; }
    public Nullable<double> mucGiam { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DonHang> DonHangs { get; set; }
    public virtual LoaiKhuyenMai LoaiKhuyenMai { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ThongTinKhuyenMai> ThongTinKhuyenMais { get; set; }
}

public partial class LoaiDoAn
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LoaiDoAn()
    {
        this.DoAns = new HashSet<DoAn>();
    }

    public string maLoaiDoAn { get; set; }
    public string tenLoaiDoAn { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DoAn> DoAns { get; set; }
}

public partial class LoaiDonHang
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LoaiDonHang()
    {
        this.DonHangs = new HashSet<DonHang>();
    }

    public string maLoaiDon { get; set; }
    public string tenLoaiDon { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DonHang> DonHangs { get; set; }
}

public partial class LoaiHoaDon
{
    public string maLoaiHoaDon { get; set; }
    public string tenLoaiHoaDon { get; set; }
}

public partial class LoaiKhuyenMai
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LoaiKhuyenMai()
    {
        this.KhuyenMais = new HashSet<KhuyenMai>();
    }

    public string maLoaiKhuyenMai { get; set; }
    public string tenLoaiKhuyenMai { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<KhuyenMai> KhuyenMais { get; set; }
}

public partial class LoaiNhanVien
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LoaiNhanVien()
    {
        this.NhanViens = new HashSet<NhanVien>();
    }

    public string maLoaiNhanVien { get; set; }
    public string tenLoaiNhanVien { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<NhanVien> NhanViens { get; set; }
}

public partial class LoaiSanPham
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LoaiSanPham()
    {
        this.SanPhams = new HashSet<SanPham>();
    }

    public string maLoaiSanPham { get; set; }
    public string tenLoaiSanPham { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<SanPham> SanPhams { get; set; }
}

public partial class MatHang
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public MatHang()
    {
        this.ThongTinThanhPhanDoAns = new HashSet<ThongTinThanhPhanDoAn>();
    }

    public string maHang { get; set; }
    public string tenHang { get; set; }
    public string maNCC { get; set; }
    public string donVi { get; set; }
    public Nullable<System.DateTime> NSX { get; set; }
    public Nullable<System.DateTime> HSD { get; set; }
    public Nullable<decimal> donGia { get; set; }
    public string ghiChu { get; set; }
    public Nullable<bool> loaiHang { get; set; }

    public virtual NhaCungCap NhaCungCap { get; set; }
    public virtual KhoBan KhoBan { get; set; }
    public virtual NuocUong NuocUong { get; set; }
    public virtual ThongTinHangTon ThongTinHangTon { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAns { get; set; }
}

public partial class NhaCungCap
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NhaCungCap()
    {
        this.MatHangs = new HashSet<MatHang>();
    }

    public string maNCC { get; set; }
    public string tenNCC { get; set; }
    public string diaChiNCC { get; set; }
    public string emailNCC { get; set; }
    public string sdtNCC { get; set; }
    public string ghiChu { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<MatHang> MatHangs { get; set; }
}

public partial class NhanVien
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public NhanVien()
    {
        this.DonHangs = new HashSet<DonHang>();
        this.TaiKhoanNhanViens = new HashSet<TaiKhoanNhanVien>();
    }

    public string maNhanVien { get; set; }
    public string tenNhanVien { get; set; }
    public string Phai { get; set; }
    public string SDT { get; set; }
    public string Email { get; set; }
    public string diaChi { get; set; }
    public string maChucDanh { get; set; }
    public string maLoaiNhanVien { get; set; }

    public virtual ChamCong ChamCong { get; set; }
    public virtual ChucDanh ChucDanh { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<DonHang> DonHangs { get; set; }
    public virtual LoaiNhanVien LoaiNhanVien { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }
}

public partial class NhapKho
{
    public string maNhap { get; set; }
    public Nullable<System.DateTime> ngayNhap { get; set; }
    public string maDatHang { get; set; }
    public string ghiChu { get; set; }
    public Nullable<bool> trangThai { get; set; }

    public virtual DatHang DatHang { get; set; }
}

public partial class NuocUong
{
    public string maNuoc { get; set; }
    public string tenNuoc { get; set; }
    public string donViBan { get; set; }
    public Nullable<decimal> giaBanNuoc { get; set; }

    public virtual MatHang MatHang { get; set; }
    public virtual SanPham SanPham { get; set; }
}

public partial class PhanQuyen
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public PhanQuyen()
    {
        this.TaiKhoanNhanViens = new HashSet<TaiKhoanNhanVien>();
    }

    public string maQuyen { get; set; }
    public string tenQuyen { get; set; }
    public string ghiChu { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }
}

public partial class PhucLoi
{
    public string maPhucLoi { get; set; }
    public string tenPhucLoi { get; set; }
    public Nullable<decimal> mucThuong { get; set; }
}

public partial class SanPham
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public SanPham()
    {
        this.ThongTinKhuyenMais = new HashSet<ThongTinKhuyenMai>();
    }

    public string maSanPham { get; set; }
    public string maLoaiSanPham { get; set; }

    public virtual DoAn DoAn { get; set; }
    public virtual LoaiSanPham LoaiSanPham { get; set; }
    public virtual NuocUong NuocUong { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ThongTinKhuyenMai> ThongTinKhuyenMais { get; set; }
}

public partial class sysdiagram
{
    public string name { get; set; }
    public int principal_id { get; set; }
    public int diagram_id { get; set; }
    public Nullable<int> version { get; set; }
    public byte[] definition { get; set; }
}

public partial class TaiKhoanNhanVien
{
    public int id { get; set; }
    public string tenTaiKhoan { get; set; }
    public string matKhau { get; set; }
    public string maNhanVien { get; set; }
    public string maQuyen { get; set; }

    public virtual NhanVien NhanVien { get; set; }
    public virtual PhanQuyen PhanQuyen { get; set; }
}

public partial class ThongTinHangTon
{
    public string maHang { get; set; }
    public Nullable<int> soLuongTon { get; set; }
    public Nullable<decimal> tongDonGia { get; set; }

    public virtual MatHang MatHang { get; set; }
}

public partial class ThongTinKhuyenMai
{
    public string maKhuyenMai { get; set; }
    public string maSanPham { get; set; }
    public Nullable<System.DateTime> ngayBatDau { get; set; }
    public Nullable<System.DateTime> ngayKetThuc { get; set; }
    public string ghiChu { get; set; }

    public virtual KhuyenMai KhuyenMai { get; set; }
    public virtual SanPham SanPham { get; set; }
}

public partial class ThongTinThanhPhanDoAn
{
    public string maThanhPhan { get; set; }
    public string tenThanhPhan { get; set; }
    public string dinhLuong { get; set; }
    public string maDoAn { get; set; }
    public Nullable<int> soLuong { get; set; }

    public virtual DoAn DoAn { get; set; }
    public virtual MatHang MatHang { get; set; }
}

public partial class TraHang
{
    public string maTra { get; set; }
    public Nullable<System.DateTime> ngayTra { get; set; }
    public string ghiChu { get; set; }
    public string maDatHang { get; set; }
    public Nullable<bool> trangThai { get; set; }

    public virtual DatHang DatHang { get; set; }
}

public partial class ViPham
{
    public string maViPham { get; set; }
    public string tenViPham { get; set; }
    public Nullable<decimal> mucPhat { get; set; }
}

public partial class XuatKho
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public XuatKho()
    {
        this.KhoBans = new HashSet<KhoBan>();
    }

    public string maXuat { get; set; }
    public Nullable<System.DateTime> ngayXuat { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<KhoBan> KhoBans { get; set; }
}