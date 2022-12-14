

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
go

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



--12/12/2022--

ALTER proc [dbo].[select_to_PhieuNhapTemp]
@maDat varchar(10)
as
if not exists(select maTra from TraHang th, DatHang hd where th.maDatHang=hd.maDatHang)
begin
select  ttdh.maHang , ttdh.maNCC , ttdh.soLuongDat as soLuongNhap, ttdh.tongDonGia as tongDonGia
from ThongTinDatHang ttdh
where ttdh.maDatHang=@maDat
end

else
begin
select thongTinNhap.maHang, thongTinNhap.maNCC, SUM(thongTinNhap.SoLuongNhap)as soLuongNhap ,SUM (thongTinNhap.TongDonGia) as tongDonGia
from (
select  ttdh.maHang , ttdh.maNCC , ttdh.soLuongDat as soLuongNhap, ttdh.tongDonGia as tongDonGia
from ThongTinDatHang ttdh,TraHang th
where ttdh.maDatHang=th.maDatHang and th.maDatHang=@maDat
union
select ttth.maHang , ttth.maNCC , (-1)*ttth.soLuong as soLuongDat, (-1)*ttth.tongDonGia as tongDonGia
from ThongTinTraHang ttth, TraHang th
where ttth.maTra=th.maTra 
and ttth.maTra=(select maTra from TraHang th, DatHang hd where th.maDatHang=hd.maDatHang and th.maDatHang=@maDat)
) thongTinNhap
group by  thongTinNhap.maHang, thongTinNhap.maNCC
end


create  proc select_KhoBan
as
select kb.maHang, mh.tenHang, sum(kb.soLuong) as soLuong, sum(kb.tongGia) as tongGia,kb.maXuat
from KhoBan kb, MatHang mh
where kb.maHang=mh.maHang
group by kb.maHang,mh.tenHang,kb.maXuat




create proc select_TenKhuyenMai
@maKhuyenMai varchar(10)
as
select tenKhuyenMai from KhuyenMai where maKhuyenMai=@maKhuyenMai
go


create  proc select_TenNhanVien
@maNhanVien varchar(10)
as select tenNhanVien from NhanVien where maNhanVien=@maNhanVien
go


create proc select_TenLoaiDon
@maLoaiDon varchar(10)
as 
select tenLoaiDon from LoaiDonHang where maLoaiDon=@maLoaiDon
go


ALTER procedure [dbo].[update_DoAn_ThanhPhanDoAn] @maThanhPhan nchar(30),@tenThanhPhan nvarchar(50),  @dinhLuong nvarchar(10), @maDoAn nchar(30),@soLuong int
as 
update ThongTinThanhPhanDoAn set dinhLuong=@dinhLuong, soLuong=@soLuong, tenThanhPhan=@tenThanhPhan where maDoAn=@maDoAn and maThanhPhan=@maThanhPhan 


create proc select_donViThanhPhan
@maThanhPhan varchar(10)
as
select donVi from MatHang where maHang=@maThanhPhan




--14/12/2022

create  proc check_ThongTinDonHang_KhoBan
@maSanPham varchar(10),@soLuong int
as
if ((select maLoaiSanPham from SanPham where maSanPham=@maSanPham)='MLSP001')
begin
select kb.maHang, kb.soLuong-(@soLuong*tttpda.soLuong) as soLuong
from SanPham sp, ThongTinThanhPhanDoAn tttpda,MatHang mh,KhoBan kb
where sp.maSanPham=tttpda.maDoAn
and mh.maHang=tttpda.maThanhPhan
and kb.maHang=tttpda.maThanhPhan
and sp.maSanPham=@maSanPham
end
else if ((select maLoaiSanPham from SanPham where maSanPham=@maSanPham)='MLSP002')
begin
select maHang, (soLuong-@soLuong) as soLuong
from KhoBan where maHang=@maSanPham
end



create proc select_id_KhachHang
@sdt varchar(10)
as
select idKhachHang from KhachHang where sdt=@sdt