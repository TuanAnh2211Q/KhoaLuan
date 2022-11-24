﻿use QLCUAHANGTHUCANNHANH
go
--===================LOẠI ĐỒ ĂN==========================================
--Thêm loại đồ ăn
--drop procedure insert_LoaiDoAn
create procedure insert_LoaiDoAn
@maLoaiDoAn varchar(10), @tenLoaiDoAn nvarchar(50) 
as
insert into LoaiDoAn values (@maLoaiDoAn,@tenLoaiDoAn)
go

--Xóa loại đồ ăn
--drop procedure delete_LoaiDoAn
create procedure delete_LoaiDoAn
@maLoaiDoAn varchar(10)
as
delete from LoaiDoAn where maLoaiDoAn=@maLoaiDoAn
go

--Sửa loại đồ ăn
create procedure update_LoaiDoAn
@maLoaiDoAn varchar(10), @tenLoaiDoAn nvarchar(50) 
as
Update LoaiDoAn set TenLoaiDoAn=@tenLoaiDoAn where MaLoaiDoAn=@maLoaiDoAn
go

--Kiểm tra loại đồ ăn có đồ ăn tồn 
create procedure check_DoAn_LoaiDoAn
@maLoaiDoAn varchar(10)
as
select * from DoAn where maLoaiDoAn =@maLoaiDoAn
go

--Lấy thông tin loại đồ ăn
create procedure select_LoaiDoAn
as
select * from LoaiDoAn
go

--Kiểm tra loại đồ ăn tồn tại
create procedure chect_exist_LoaiDoAn
@maLoaiDoAn varchar(10)
as
select * from LoaiDoAn where maLoaiDoAn=@maLoaiDoAn 
go
--============================ĐỒ ĂN========================

	create procedure show_dsDoAn
	as
	select da.maDoAn, da.tenDoAn, lda.tenLoaiDoAn, ttda.donViBan, ttda.donGia,ttda.ghiChu from DoAn da, ThongTinDoAn ttda,LoaiDoAn lda
	where da.maDoAn=ttda.maDoAn
	and da.maLoaiDoAn=lda.maLoaiDoAn


create procedure insert_DoAn_ThongTinDoAn
@maDoAn nchar(30), @maLoaiDoAn nchar(30), @tenDoAn nvarchar(50),@donViBan nvarchar(10), @donGia money, @ghiChu nvarchar(max)
as
insert into DoAn values(@maDoAn,@maLoaiDoAn,@tenDoAn)
insert into ThongTinDoAn values(@maDoAn,@donViBan,@donGia,@ghiChu)
go

create procedure delete_DoAn_ThongTinDoAn
@maDoAn nchar(30)
as
delete from DoAn where maDoAn=@maDoAn
go
create procedure update_DoAn_ThongTinDoAn
@maDoAn nchar(30), @maLoaiDoAn nchar(30), @tenDoAn nvarchar(50),@donViBan nvarchar(10), @donGia money, @ghiChu nvarchar(max)
as
update DoAn set maLoaiDoAn= @maLoaiDoAn, tenDoAn=@tenDoAn where maDoAn=@maDoAn
update ThongTinDoAn set donViBan=@donViBan,donGia= @donGia,ghiChu=@ghiChu where maDoAn=@maDoAn
go


create procedure select_DoAn_ThanhPhanDoAn @maDoAn nchar(30)
as
select * from ThongTinThanhPhanDoAn where maDoAn=@maDoAn
go


create procedure insert_DoAn_ThanhPhanDoAn @maThanhPhan nchar(30), @tenThanhPhan nvarchar(50), @dinhLuong nvarchar(10), @maDoAn nchar(30)
as 
insert into ThongTinThanhPhanDoAn values (@maThanhPhan,@tenThanhPhan,@dinhLuong,@maDoAn)
go

create procedure update_DoAn_ThanhPhanDoAn @maThanhPhan nchar(30),  @dinhLuong nvarchar(10), @maDoAn nchar(30)
as 
update ThongTinThanhPhanDoAn set dinhLuong=@dinhLuong where maDoAn=@maDoAn and maThanhPhan=@maThanhPhan 
go

create procedure delete_DoAn_ThanhPhanDoAn @maThanhPhan nchar(30), @maDoAn nchar(30)
as 
delete from ThongTinThanhPhanDoAn  where maDoAn=@maDoAn and maThanhPhan=@maThanhPhan 
go
--===========================MẶT HÀNG========================
create procedure select_MatHang
as
select maHang,TenHang from MatHang

--=================================NƯỚC UỐNG==================
create procedure select_NuocUong
as
select * from NuocUong
go

create  procedure insert_to_NuocUong
@maNuocUong nchar(30), @tenNuocUong nvarchar(50), @donViBan nvarchar(10), @donGia money
as
insert into NuocUong values(@maNuocUong,@tenNuocUong,@donViBan,@donGia)
go

create procedure delete_to_NuocUong
@maNuocUong nchar(30)
as
delete from NuocUong where maNuoc=@maNuocUong
go

create procedure update_to_NuocUong
@maNuocUong nchar(30), @tenNuocUong nvarchar(50), @donViBan nvarchar(10), @donGia money
as
update NuocUong set tenNuoc=@tenNuocUong, donViBan=@donViBan, giaBanNuoc=@donGia where maNuoc=@maNuocUong
go

--===================PHÂN QUYỀN============================

--Lấy thông tin quyền
create procedure select_PhanQuyen
as
select*from PhanQuyen
go
exec dbo.select_PhanQuyen
------===================NHÂN VIÊN==============================

--Lấy thông tin nhân viên
create  procedure select_NhanVien
as
select maNhanVien,tenNhanVien, Phai, tenChucDanh, Email, SDT, diaChi, tenLoaiNhanVien
from NhanVien nv, ChucDanh cd, LoaiNhanVien lnv
where nv.maChucDanh=cd.maChucDanh
and nv.maLoaiNhanVien=lnv.maLoaiNhanVien
and maNhanVien !='Admin'
go

--Thêm nhân viên
create  procedure insert_NhanVien
@maNhanVien varchar(10), @tenNhanVien nvarchar(100), @Phai nvarchar(5), @SDT varchar(11), @Email varchar(50), @diaChi nvarchar(50),
@maChucDanh varchar(10), @maLoaiNhanVien varchar(10)
as
insert into NhanVien values(@maNhanVien, @tenNhanVien, @Phai, @SDT, @Email, @diaChi, @maChucDanh, @maLoaiNhanVien)
go
--Xóa nhân viên
create procedure delete_NhanVien
@maNhanVien varchar(10)
as
delete from NhanVien where maNhanVien=@maNhanVien
go

--Kiểm tra nhân viên
create procedure check_exist_NhanVien
@maNhanVien varchar(10)
as
select maNhanVien from NhanVien where maNhanVien=@maNhanVien
go

--Sửa thông tin nhân viên
	create procedure update_NhanVien
	@maNhanVien varchar(10), @tenNhanVien nvarchar(100), @Phai nvarchar(5), @SDT varchar(11), @Email varchar(50), @diaChi nvarchar(50),
	@maChucDanh varchar(10), @maLoaiNhanVien varchar(10)
	as
	update NhanVien 
	set
	 tenNhanVien=@tenNhanVien, 
	 Phai=@Phai, 
	 SDT=@SDT, 
	 Email=@Email, 
	 diaChi=@diaChi, 
	 maChucDanh=@maChucDanh, 
	 maLoaiNhanVien=@maLoaiNhanVien
	 where maNhanVien=@maNhanVien
	go

--------------------------------LOẠI NHÂN VIÊN---------------------
create procedure select_LoaiNhanVien
as
select maLoaiNhanVien, tenLoaiNhanVien from LoaiNhanVien
go
----------------------------CHỨC DANH--------------------
create  procedure select_ChucDanh
as 
select maChucDanh,tenChucDanh from ChucDanh where maChucDanh!='Admin'
go

--===================Đăng nhập===========

create procedure DangNhap
@tenTaiKhoan varchar(10), @matKhau varchar(50)
as
select tenTaiKhoan, matKhau,maQuyen from TaiKhoanNhanVien where tenTaiKhoan=@tenTaiKhoan and matKhau=@matKhau
go

create  procedure check_Quyen_DangNhap
@tenTaiKhoan varchar(10)
as
select maQuyen from TaiKhoanNhanVien where tenTaiKhoan=@tenTaiKhoan
go


create procedure doi_MatKhau_TaiKhoanNhanVien
@tenTaiKhoan varchar(10), @matKhauCu varchar(50), @matKhauMoi varchar(50)
as
if( @matKhauCu= (select matKhau from TaiKhoanNhanVien where tenTaiKhoan=@tenTaiKhoan))
begin
    update TaiKhoanNhanVien set matKhau=@matKhauMoi where tenTaiKhoan=@tenTaiKhoan
	end
go

-----==========================NHẬP KHO==============

create procedure select_NhapKho
as
select * from NhapKho
go

create procedure select_DatHang
as
select * from DatHang where maDatHang in (select maDatHang from NhapKho)
go


--=========================THÔNG TIN CHI TIẾT PHIẾU NHẬP=====
create procedure select_ThongTinNhapKho
@maNhap varchar(10)
as
select * from ThongTinNhapKho where maNhap=@maNhap
go

----========PHIẾU ĐẶT HÀNG==============
create  procedure select_DatHang
as
select maDatHang, ngayDatHang,ngayDuKienGiao,phuongThucThanhToan,ghiChu from DatHang
go
--Tổng giá phiếu đặt

create  procedure tongGia_DatHang
as
select sum(tongDonGia) from ThongTinDatHang
go


create  procedure select_ThongTinDatHang
@maDatHang varchar(10)
as
select mh.tenHang, ttdt.soLuongDat, ncc.tenNCC ,ttdt.tongDonGia from ThongTinDatHang ttdt, MatHang mh,
NhaCungCap ncc 
where ttdt.maHang=mh.maHang
and ncc.maNCC=ttdt.maNCC
and ttdt.maDatHang=@maDatHang
go
----========ORDER==============
-- Lấy thông tin món ăn chính
alter proc Load_MonAnChin
as  select*from DoAn where maLoaiDoAn='LDA01'
exec dbo.Load_MonAnChin
--Lấy thông tin món ăn phụ
create proc Load_MonAnPhu
as  select*from DoAn where maLoaiDoAn='LDA02'
exec dbo.Load_MonAnPhu
--Lấy thông tin nước
alter proc Load_NuocUong	
as select tenNuoc from NuocUong
exec dbo.Load_NuocUong
--Lấy thông tin kích cở nước
create proc load_KichCoNuoc
as select donViBan from NuocUong	
exec dbo.load_KichCoNuoc
