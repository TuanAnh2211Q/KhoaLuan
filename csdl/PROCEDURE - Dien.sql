use QLCUAHANGTHUCANNHANH
go

--Lấy giá Món ăn
alter proc select_donGia_SanPham
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


--Insert thông tin khách hàng vào database
create proc insert_thongTinKhachHang
@tenKhachHang nvarchar(100), @Phai nvarchar(10),@SDT varchar(11), @Email nvarchar(50), @diaChi nvarchar(100), @ghiChu nvarchar(max)
as
	insert into KhachHang 
	values (@tenKhachHang,@Phai,@SDT,@Email,@diaChi,@ghiChu)