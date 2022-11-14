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

--===================PHÂN QUYỀN============================

--Lấy thông tin quyền
create procedure select_PhanQuyen
as
select*from PhanQuyen
go
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

exec DangNhap 'Admin','123456'

