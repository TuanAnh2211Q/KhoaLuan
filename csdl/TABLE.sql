create database QLCUAHANGTHUCANNHANH
go
use  QLCUAHANGTHUCANNHANH
go
set dateformat dmy
go

create table DoAn
(
	maDoAn varchar(10) not null primary key,
    maLoaiDoAn varchar(10),
	tenDoAn nvarchar(50),
	ghiChu nvarchar(max)
)
go

create table LoaiDoAn
(
	maLoaiDoAn varchar(10) not null primary key,
	tenLoaiDoAn nvarchar(50)
)
go

create table ThongTinDoAn
(
	maDoAn varchar(10),
	donViBan nvarchar(10),
	donGia money,
	ghiChu nvarchar(max)
)
go

create table ThongTinThanhPhanDoAn
(
	maThanhPhan varchar(10) ,
	tenThanhPhan nvarchar(50),
	dinhLuong nvarchar(10),
	maDoAn varchar(10),
	primary key(maThanhPhan,maDoAn)
)
go
 
create table NuocUong
(
	maNuoc varchar(10) primary key not null,
	tenNuoc nvarchar(50),
	donViBan nvarchar(10),
	giaBanNuoc money
)
go

create table SanPham
(
	maSanPham varchar(10) not null primary key,
	maLoaiSanPham varchar(10)
)
go

create table LoaiSanPham
(
maLoaiSanPham varchar(10) not null primary key,
tenLoaiSanPham nvarchar(50)
)
go

 
create Table NhaCungCap
(
    maNCC varchar(10) not null primary key,
    tenNCC nvarchar(50) not null,
    diaChiNCC nvarchar(50),
	emailNCC varchar(50),
    sdtNCC varchar(11),
	ghiChu nvarchar(max)
)
go

create Table MatHang
(
    maHang varchar(10) not null primary key,
    tenHang nvarchar(50) not null,
    maNCC varchar(10),
	donVi nvarchar(10),
	NSX date,
    HSD date,
	donGia money,
	ghiChu nvarchar(max)	
)
go



create table ThongTinHangTon
(
	maHang varchar(10) not null,
	soLuongTon int,
	tongDonGia money
)
go

create table DatHang
(
	maDatHang varchar(10) not null primary key,
	phuongThucThanhToan bit,
	ngayDatHang datetime,
	ngayDuKienGiao datetime,
	ghiChu nvarchar(max)
)
go

create table ThongTinDatHang
(
	maDatHang varchar(10),
	maHang varchar(10) ,
	maNCC varchar(10),
	soLuongDat int,
	tongDonGia money,
)
go

create table NhapKho
(
	maNhap varchar(10) not null primary key,
	ngayNhap datetime,
	maDatHang varchar(10),
	ghiChu nvarchar(max)
)
go

create table ThongTinNhapKho
(
	maNhap varchar(10),
	maNCC varchar(10),
	maHang varchar(10),
	soLuong int,
	tongDonGia money
)
go

create table TraHang
(
maTra varchar(10) primary key not null,
maNhap varchar(10),
ngayTra datetime,
ghiChu nvarchar(max)
)

create table ThongTinTraHang
(
	maTra varchar(10),
	maNCC varchar(10),
	maHang varchar(10),
	soLuong int,
	tongDonGia money
)
go

create table XuatKho
(
	maXuat varchar(10) not null primary key,
	ngayXuat datetime
)
go

create table ThongTinXuatKho
(
	maXuat varchar(10),
	maHang varchar(10),
	soLuong int,
	ghiChu nvarchar(max)
)
go

create table KhuyenMai
(
	maKhuyenMai varchar(10) not null primary key,
	tenKhuyenMai nvarchar(50),
	maLoaiKhuyenMai varchar(10),
		mucGiam float
)
go


create table LoaiKhuyenMai
(
	maLoaiKhuyenMai varchar(10) not null primary key,
	tenLoaiKhuyenMai nvarchar(50)
)
go

create table ThongTinKhuyenMai
(
	maKhuyenMai varchar(10), 
	maSanPham varchar(10),
	ngayBatDau datetime,
	ngayKetThuc datetime,
	ghiChu nvarchar(max)
)
go


create table KhachHang
(
	tenKhachHang nvarchar(100),
	Phai nvarchar(10),
	SDT varchar(11) not null primary key,
	Email varchar(50),
	diaChi nvarchar(100),
	ghiChu nvarchar(max)
)
go

create table LoaiNhanVien
(
	maLoaiNhanVien varchar(10) not null primary key,
	tenLoaiNhanVien nvarchar(50)
)
go

create table ChucDanh
(
	maChucDanh varchar(10) not null primary key,
	tenChucDanh nvarchar(100),
	heSoLuong float
)
go

create table NhanVien
(
	maNhanVien varchar(10) not null primary key,
	tenNhanVien nvarchar(100),
	Phai nvarchar(10),
	SDT varchar(11),
	Email varchar(50),
	diaChi nvarchar(50),
	maChucDanh varchar(10),
	maLoaiNhanVien varchar(10)
)
go


 create table CaLam
 (
	 maCaLam varchar(10) not null primary key,
	 tenCaLam nvarchar(50)
 )
 go

 create table ThongTinCaLam
 (
	 maCaLam varchar(10),
	 gioVao time, 
	 gioRa time,
	 soLuongNhanVien int
 )
 go

 create table ChamCong
 (
	 maNhanVien varchar(10) not null primary key,
	 ngayLam datetime,
	 gioVao time,
	 gioRa time,
	 maCaLam varchar(10),
	 ghiChu varchar(max)
 )
 go

 create table PhucLoi
 (
	 maPhucLoi varchar(10) not null primary key,
	 tenPhucLoi nvarchar(50),
	 mucThuong money
 )
 go

 create table ThongTinPhucLoi
 (
	 maPhucLoi varchar(10),
	 maNhanVien varchar(10),
	 ngayBatDau datetime,
	 ngayKetThuc datetime,
	 ghiChu nvarchar(max)
 )
 go

 create table ViPham
 (
	 maViPham varchar(10) not null primary key,
	 tenViPham nvarchar(50),
	 mucPhat money
 )
 go

 create table ThongTinViPham
 (
	 maViPham varchar(10),
	 maNhanVien varchar(10),
	 ghiChu nvarchar(max)
 )
 go

 create table PhanQuyen
(
	 maQuyen varchar(10) not null primary key,
	 tenQuyen nvarchar(50),
	 ghiChu nvarchar(max)
 )
 go

 create table TaiKhoanNhanVien
 (
	 id int  not null primary key identity(1,001),
	 tenTaiKhoan varchar(10),
	 matKhau varchar,
	 maNhanVien varchar(10),
	 maQuyen varchar(10)
 )
 go

 create table LoaiDonHang
 (
	 maLoaiDon varchar(10) not null primary key,
	 tenLoaiDon nvarchar(50)
 )
 go

 create table HinhThucThanhToan
 (
	 maHinhThuc bit not null primary key,
	 tenHinhThuc nvarchar(50)
 )
go

create table DonHang
(
	maDonHang varchar(10) not null primary key,
	tenDonHang nvarchar(50),
	maLoaiDon varchar(10),
	maHinhthuc bit,
	maNhanVien varchar(10),
	SDTKhachHang varchar(11),
	maKhuyenMai varchar(10),
	thoiGianDat datetime,
	trangThai int,
	ghiChu nvarchar(max)
)
go

create table ThongTinDonHang
(
	maDonHang varchar(10),
	maSanPham varchar(10)	,
	giaTien money,
)
go



create table LoaiHoaDon
(
	maLoaiHoaDon varchar(10) primary key,
	tenLoaiHoaDon varchar(50)
)
go

create table HoaDon
(
	maLoaiHoaDon varchar(10),
	maHoaDon varchar(10),
	tenHoaDon varchar(50),
	tongGia money,
	maNhanVien varchar(10),
	ghiChu nvarchar(max)
)
go

create table DanhGia
(
 SDTKhachHang varchar(11),
 maSanPham varchar(10),
 thongTinDanhGia nvarchar(max)
 )


