use QLCUAHANGTHUCANNHANH
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
create  procedure select_MatHang
as
select* from MatHang



create proc insert_MatHang
@maHang varchar(10), @tenHang nvarchar(50), @maNCC varchar(10), @donVi nvarchar(10), @NSX date, @HSD date, @donGia money, @ghiChu nvarchar(max)
as
insert into MatHang values(@maHang,@tenHang,@maNCC,@donVi,@NSX,@HSD,@donGia,@ghiChu)
go

create proc update_MatHang
@maHang varchar(10), @tenHang nvarchar(50), @maNCC varchar(10), @donVi nvarchar(10), @NSX date, @HSD date, @donGia money, @ghiChu nvarchar(max)
as
update  MatHang set tenHang= @tenHang, maNCC=@maNCC, donVi=@donVi, donGia=@donGia, NSX=@NSX, HSD=@HSD, ghiChu=@ghiChu where maHang=@maHang
go

create proc delete_MatHang
@maHang varchar(10)
as
delete from MatHang where maHang=@maHang
go

create proc check_MatHang_ThanhPhan
@maHang varchar(10)
as
select * from ThongTinThanhPhanDoAn tttpda, MatHang mh where mh.maHang=tttpda.maThanhPhan
and tttpda.maThanhPhan=@maHang
go
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
--Update Quyen

create  procedure update_Quyen
@maQuyen varchar(10), @tenQuyen nvarchar(50), @ghiChu nvarchar(max)
as
update PhanQuyen set tenQuyen=@tenQuyen, ghiChu=@ghiChu where maQuyen=@maQuyen

------===================NHÂN VIÊN==============================

--Lấy thông tin nhân viên
create  procedure select_NhanVien
as
select maNhanVien,tenNhanVien, Phai,nv.maChucDanh, tenChucDanh, Email, SDT, diaChi, tenLoaiNhanVien, nv.maLoaiNhanVien
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

--====================TÀI KHOẢN NHÂN VIÊN

create proc select_TKNV
as
select id, tenTaiKhoan,matKhau,ttnn.maNhanVien, tenNhanVien,q.maQuyen from TaiKhoanNhanVien ttnn, NhanVien nv, PhanQuyen q
where ttnn.maNhanVien=nv.maNhanVien
and ttnn.maQuyen=q.maQuyen

create  proc update_QuyenTKNV
@id int, @maQuyen varchar(10)
as
update TaiKhoanNhanVien set maQuyen=@maQuyen where id=@id

create  proc rs_mkTKNV
@id int
as
update TaiKhoanNhanVien set matKhau='1' where id=@id


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
----========Thông Tin Khách Hàng==============
--Lấy thông tin khách hàng
create procedure select_KhachHang
as
	select*from KhachHang
exec dbo.select_KhachHang
--Lấy Giới tính khách hàng
create proc select_GioiTinhKhachHang
as select Phai from KhachHang
exec dbo.select_GioiTinhKhachHang
--Update thông tin khách hàng
alter proc update_KhachHang
 @idKhachHang int,@SDT varchar(11),@tenKhachHang  nvarchar(100), @Phai nvarchar(10), @email nvarchar(50),@diaChi nvarchar(100),@ghiChu nvarchar(max)
as
update KhachHang set SDT=@SDT, tenKhachHang=@tenKhachHang, Phai=@Phai,diaChi=@diaChi,Email=@email,ghiChu=@ghiChu where idKhachHang =@idKhachHang
go
exec dbo.update_KhachHang
--======================NHÀ CUNG CẤP===========
create proc select_NCC
as 
select * from NhaCungCap
go


create proc insert_to_NCC
@maNCC varchar(10), @tenNCC nvarchar(50), @diachiNCC nvarchar(50),@emailNCC varchar(50), @sdtNCC varchar(11), @ghiChu nvarchar(max)
as
insert into NhaCungCap values (@maNCC,@tenNCC,@diachiNCC, @emailNCC,@sdtNCC,@ghiChu)
go

create proc update_to_NCC
@maNCC varchar(10), @tenNCC nvarchar(50), @diachiNCC nvarchar(50),@emailNCC varchar(50), @sdtNCC varchar(11), @ghiChu nvarchar(max)
as
update NhaCungCap
set tenNCC=@tenNCC, diaChiNCC=@diachiNCC, emailNCC=@emailNCC,sdtNCC=@sdtNCC,ghiChu=@ghiChu where maNCC=@maNCC
go

create proc delete_to_NCC
@maNCC varchar(10)
as
delete from NhaCungCap where maNCC=@maNCC
go

--=====================LOẠI KHUYẾN MÃI============
create proc select_LoaiKM
as
select* from LoaiKhuyenMai

create proc insert_LoaiKM
@maLoai varchar(10), @tenLoai nvarchar(50)
as
insert into LoaiKhuyenMai values (@maLoai,@tenLoai)

create proc update_LoaiKM
@maLoai varchar(10), @tenLoai nvarchar(50)
as
update LoaiKhuyenMai set tenLoaiKhuyenMai=@tenLoai where maLoaiKhuyenMai=@maLoai

create proc delete_LoaiKM
@maLoai varchar(10)
as
delete LoaiKhuyenMai where maLoaiKhuyenMai=@maLoai


-----------------=KHUYẾN MÃI--------------------

create proc select_KhuyenMai
as
select*from KhuyenMai

create proc insert_KM
@maKM varchar(10), @tenKM nvarchar(50), @maLoaiKM varchar(10), @mucGiam float
as
insert into KhuyenMai values(@maKM,@tenKM,@maLoaiKM,@mucGiam)

create  proc update_KM
@maKM varchar(10), @tenKM nvarchar(50), @maLoaiKM varchar(10), @mucGiam float
as
update KhuyenMai set tenKhuyenMai=@tenKM,maLoaiKhuyenMai=@maLoaiKM, mucGiam=@mucGiam where maKhuyenMai=@maKM

create proc delete_KM
@maKM varchar(10)
as
delete from KhuyenMai where maKhuyenMai=@maKM


-----------------=THÔNG TIN KHUYẾN MÃI--------------------
create proc select_TTSP
as
select maSanPham, tenDoAn as tenSanPham from  SanPham sp, DoAn da
where da.maDoAn=sp.maSanPham
Union
select maSanPham , tenNuoc as tenSanPham from SanPham sp, NuocUong n
where n.maNuoc=sp.maSanPham



create proc select_ThongTinKhuyenMai
@maKhuyenMai varchar(10)
as
select maKhuyenMai,maSanPham,da.tenDoAn as TenSanPham,ngayBatDau,ngayKetThuc,ghiChu from ThongTinKhuyenMai ttkm,DoAn da
where ttkm.maSanPham=da.maDoAn and maKhuyenMai=@maKhuyenMai
union
select maKhuyenMai,maSanPham,n.tenNuoc as TenSanPham,ngayBatDau,ngayKetThuc,ghiChu from ThongTinKhuyenMai ttkm,NuocUong n
where ttkm.maSanPham=n.maNuoc and maKhuyenMai=@maKhuyenMai


create proc insert_ThongTinKhuyenMai
@maKM varchar(10), @maSP varchar(10), @ngayBD datetime, @ngayKT datetime, @ghiChu nvarchar(max)
as
insert into ThongTinKhuyenMai values (@maKM,@maSP,@ngayBD,@ngayKT,@ghiChu)

create proc update_ThongTinKhuyenMai
@maKM varchar(10), @maSP varchar(10), @ngayBD datetime, @ngayKT datetime, @ghiChu nvarchar(max)
as
update ThongTinKhuyenMai set ngayBatDau=@ngayBD, ngayKetThuc=@ngayKT, ghiChu=@ghiChu where maKhuyenMai=@maKM and maSanPham=@maSP


create proc delete_ThongTinKhuyenMai
@maKM varchar(10), @maSP varchar(10)
as
delete from ThongTinKhuyenMai where maKhuyenMai=@maKM and maSanPham=@maSP




