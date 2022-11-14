--Trigger tự tạo tài khoản nhân viên

--drop trigger tg_TaoTK
create trigger tg_TaoTK on NhanVien after insert as
begin
declare @tk varchar(10)=(select maNhanVien from inserted)
 insert into TaiKhoanNhanVien values (@tk, '1',@tk,'MQ002') 
end
go 

--drop trigger tg_XoaTK
create trigger tg_XoaTK on NhanVien instead of delete as
begin
declare @tk varchar(10)=(select maNhanVien from deleted)
if(@tk in (select tenTaiKhoan from TaiKhoanNhanVien where tenTaiKhoan=@tk))
begin
delete from TaiKhoanNhanVien where tenTaiKhoan=@tk
delete from NhanVien where maNhanVien=@tk
end
end
go







