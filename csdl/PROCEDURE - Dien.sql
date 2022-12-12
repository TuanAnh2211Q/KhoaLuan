
use QLCUAHANGTHUCANNHANH
go
set dateformat dmy
go
--=================================Order=============================
--Lấy giá Món ăn
create proc select_donGia_SanPham
@maSanPham varchar(10), @donViBan nvarchar(10)
as
	select donGia
	from
	(select sp.maSanPham,ttda.donViBan,ttda.donGia as  donGia
	from ThongTinDoAn ttda, SanPham sp,DoAn da 
	where ttda.maDoAn=sp.maSanPham and da.maDoAn=ttda.maDoAn
	union
	select sp. maSanPham,nu.donViBan, giaBanNuoc as donGia
	from  SanPham sp, NuocUong nu
	where sp.maSanPham=nu.maNuoc
	)menu
	where maSanPham=@maSanPham and donViBan=@donViBan

--Lấy mã sản phẩm
create proc select_maSanPham_DoAn
@maDoAn varchar(10)
as
	select maSanPham from DoAn da, SanPham sp 
	where da.maDoAn=sp.maSanPham and da.maDoAn=@maDoAn
-- Lấy mã nước 
create proc select_SanPham_Nuoc
@maNuoc varchar(10)
as
	select maSanPham from SanPham sp, NuocUong nu
	where nu.maNuoc= sp.maSanPham and nu.maNuoc=@maNuoc
--Lấy mức giảm khuyến mãi
create proc select_MucKhuyenMai
@maKhuyenMai varchar(10)
as
select mucGiam from KhuyenMai where maKhuyenMai=@maKhuyenMai;

--Insert thông tin khách hàng vào database
alter proc insert_thongTinKhachHang
@tenKhachHang nvarchar(100), @Phai nvarchar(10),@SDT varchar(11), @Email nvarchar(50), @diaChi nvarchar(100), @ghiChu nvarchar(max)
as
	insert into KhachHang 
	values (@tenKhachHang,@Phai,@SDT,@Email,@diaChi,@ghiChu)
--Insert đơn hàng vào database
create proc insert_DonHang
@maDonHang varchar(10),@tenDonHang nvarchar(50),@maLoaiDon varchar(10),@maHinhThuc varchar(10), @maNhanVien varchar(10),
@SDTKhachHang varchar(11),@maKhuyenMai varchar(10),@thoiGianDat datetime, @trangThai int, @ghiChu nvarchar(max),@tongGia money
as
insert into DonHang
values(@maDonHang,@tenDonHang,@maLoaiDon,@maHinhThuc,@maNhanVien,@SDTKhachHang,@maKhuyenMai,@thoiGianDat,@trangThai,@ghiChu,null,@tongGia)
--Insert thông tin đơn hàng
create proc insert_ThongTinDonHang
@maDonHang varchar(10), @maSanPham varchar(10),@giaTien money,@soLuong int,@thanhTien money
as
	insert into ThongTinDonHang
	values(@maDonHang,@maSanPham,@giaTien,@soLuong,@thanhTien)