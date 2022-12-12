

-----------MẶT HÀNG----------
create proc select_MatHang_NCC
@maHang varchar(10)
as
select mh.maNCC
from MatHang mh, NhaCungCap ncc
where mh.maNCC=ncc.maNCC
and mh.maHang=@maHang

create proc select_DonGia_MatHang
@maHang varchar(10)
as 
select donGia
from MatHang where maHang=@maHang

--NHẬP KHO----

create proc check_MaNhapKho
@maNhap varchar(100)
as
select * from NhapKho where maNhap=@maNhap

-------TỒN KHO--------

create  proc select_TonKho
as
select ttht.maHang, tenHang, mh.maNCC, tenNCC, ttht.soLuongTon, ttht.tongDonGia
from ThongTinHangTon ttht, MatHang mh, NhaCungCap ncc
where ttht.maHang=mh.maHang
and mh.maNCC=ncc.maNCC


create  proc select_SoLuong_TonKho
@maHang varchar(10)
as
select soLuongTon
from ThongTinHangTon
where maHang=@maHang


-----------Xuất kho---------------------
create proc select_XuatKho
as
select* from XuatKho
go 

create proc insert_XuatKho 
@maXuat varchar(10), @ngayXuat datetime, @trangThai bit
as
insert into XuatKho values (@maXuat,@ngayXuat,@trangThai)

create proc insert_ThongTinXuatKho
@maXuat varchar(10), @maHang varchar(10), @soLuong int, @ghiChu nvarchar(max), @tongDonGia money
as
insert into ThongTinXuatKho values(@maXuat,@maHang,@soLuong,@ghiChu,@tongDonGia)

create proc update_PhieuXuat
@maXuat varchar(10)
as
update XuatKho set trangThai=1  where maXuat=@maXuat
go

create proc select_SoLuong_ThongTinXuatKho
@maXuat varchar(10),@maHang varchar(10)
as
select soLuong from ThongTinXuatKho where maXuat=@maXuat and maHang=@maHang
go

create proc delete_XuatKho
@maXuat varchar(10)
as 
delete from XuatKho where maXuat=@maXuat





create  proc check_PhieuXuat
@maXuat varchar(100)
as
select maXuat from XuatKho where maXuat=@maXuat
go


create proc check_ThongTinPhieuXuat
@maXuat varchar(100)
as
select maXuat from ThongTinXuatKho where maXuat=@maXuat
go

create  proc select_ThongTinPhieuXuat
@maXuat varchar(10)
as
select ttxk.maHang, mh.tenHang, ttxk.soLuong,ttxk.ghiChu,ttxk.tongDonGia
from ThongTinXuatKho  ttxk, MatHang mh
where ttxk.maHang=mh.maHang
and ttxk.maXuat=@maXuat
go





