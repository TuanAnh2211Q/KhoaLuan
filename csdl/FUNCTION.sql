use DB_CUAHANGTHUCANNHANH
go

--Function KTDN
create function KTDN (@taiKhoan nvarchar(10), @matKhau nvarchar(10))
returns table 
as
	return (select TKNV.id,TKNV.matKhau from TaiKhoanNhanVien TKNV
			where TKNV.id=@taiKhoan and TKNV.matKhau=@matKhau)
-- Function DangNhap
create function DangNhap (@taiKhoan nvarchar(10), @matKhau nvarchar(10))
returns table
as
	return(select*from TaiKhoanNhanVien TKNV
		   where TKNV.id = @taiKhoan and TKNV.matKhau= @matKhau)
select * from dbo.DangNhap('admin','admin')