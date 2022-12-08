

-----------MẶT HÀNG----------
create proc select_MatHang_NCC
@maHang varchar(10)
as
select mh.maNCC
from MatHang mh, NhaCungCap ncc
where mh.maNCC=ncc.maNCC
and mh.maHang=@maHang

--NHẬP KHO----

create  proc check_MaNhapKho
@maNhap varchar(10)
as
select * from NhapKho where maNhap=@maNhap

-------TỒN KHO--------

create proc select_TonKho
as
select ttht.maHang, tenHang, mh.maNCC, tenNCC, ttht.soLuongTon, ttht.tongDonGia
from ThongTinHangTon ttht, MatHang mh, NhaCungCap ncc
where ttht.maHang=mh.maHang
and mh.maNCC=ncc.maNCC
