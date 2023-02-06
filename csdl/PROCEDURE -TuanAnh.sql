

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







---12-1-2023----------

create proc search_KhachHang 
@find nvarchar(max)
as
select * from KhachHang
where tenKhachHang like N'%'+@find+'%'
or Phai like N'%'+@find+'%'
or SDT like '%'+@find+'%'
or Email like '%'+@find+'%'
or diaChi like N'%'+@find+'%'
or ghiChu like N'%'+@find+'%'





---17/1/2022

create proc print_HoaDonBanHang
@maDonHang varchar(10)
as
select dhang.MaDonHang, dhang.TenDonHang, dhang.ThoiGianDat, dhang.TenNhanVien, dhang.TenSanPham, dhang.GiaTien, dhang.SoLuong, dhang.ThanhTien, dhang.TenKhuyenMai
from
(
select dh.maDonHang as MaDonHang, dh.tenDonHang as TenDonHang, dh.thoiGianDat as ThoiGianDat, nv.tenNhanVien as TenNhanVien, da.tenDoAn as TenSanPham, ttdh.giaTien as GiaTien ,ttdh.soLuong as SoLuong, ttdh.thanhTien as ThanhTien , km.tenKhuyenMai as TenKhuyenMai
from DonHang dh, ThongTinDonHang ttdh, DoAn da, NhanVien nv, KhuyenMai km
where dh.maDonHang=ttdh.maDonHang
and ttdh.maSanPham=da.maDoAn
and dh.maNhanVien=nv.maNhanVien
and dh.maKhuyenMai=km.maKhuyenMai
union
select dh.maDonHang as MaDonHang, dh.tenDonHang as TenDonHang, dh.thoiGianDat as ThoiGianDat, nv.tenNhanVien as TenNhanVien, nu.tenNuoc as TenSanPham, ttdh.giaTien as GiaTien ,ttdh.soLuong as SoLuong, ttdh.thanhTien as ThanhTien , km.tenKhuyenMai as TenKhuyenMai
from DonHang dh, ThongTinDonHang ttdh, NuocUong nu, NhanVien nv, KhuyenMai km
where dh.maDonHang=ttdh.maDonHang
and ttdh.maSanPham=nu.maNuoc
and dh.maNhanVien=nv.maNhanVien
and dh.maKhuyenMai=km.maKhuyenMai
)dhang
where dhang.MaDonHang=@maDonHang



create proc print_TongGia
@maDonHang varchar(10)
as
select sum(ThanhTien)
from ThongTinDonHang
where maDonHang=@maDonHang


exec print_HoaDonBanHang 'MHD2899'

set dateformat dmy

--26/01/2023
--Thống kê doanh thu theo ngày-tháng năm
alter proc select_ThongKeDoanhThu
@loaithongke varchar(10), @thoigian datetime
as
if (@loaithongke='ngay')
begin
select dh.maDonHang, dh.tenDonHang, dh.thoiGianDat, dh.tongGia,
(
select sum(dh.tongGia) 
from DonHang dh
where thoiGianDat=@thoigian)  as tongDoanhThu

from DonHang dh
where thoiGianDat=@thoigian
end

else if (@loaithongke='thang')
begin

select dh.maDonHang, dh.tenDonHang, dh.thoiGianDat, dh.tongGia,
(
select sum(dh.tongGia) 
from DonHang dh
where MONTH(thoiGianDat)=Month(@thoigian )and YEAR(thoiGianDat)=Year(@thoigian))  as tongDoanhThu

from DonHang dh
where MONTH(thoiGianDat)=Month(@thoigian )and YEAR(thoiGianDat)=Year(@thoigian)
end

else if(@loaithongke='nam')
begin
select dh.maDonHang, dh.tenDonHang, dh.thoiGianDat, dh.tongGia,
(
select sum(dh.tongGia) 
from DonHang dh
where YEAR(thoiGianDat)=Year(@thoigian))  as tongDoanhThu

from DonHang dh
where YEAR(thoiGianDat)=year(@thoigian)
end


exec select_ThongKeDoanhThu 'thang','23/01/2023'





create proc selectThongKeDoanhThuTheoMocThoiGian
@tg1 varchar(max), @tg2 varchar(max)
as
select dh.maDonHang, dh.tenDonHang, dh.thoiGianDat, dh.tongGia,
(
select sum(dh.tongGia) 
from DonHang dh
where thoiGianDat between @tg1 and @tg2)  as tongDoanhThu

from DonHang dh
where thoiGianDat between @tg1 and @tg2



--27/1/2022
alter PROCEDURE select_ThongKeDoanhThuTheoQuy
(
    @nam int,
    @quyList VARCHAR(max)
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @quy INT;
    DECLARE @tuNgay varchar(max);
    DECLARE @denNgay varchar(max);

    SET @quy = 1;
    WHILE (@quy <= 4)
    BEGIN
       IF (@quy = 1)
        BEGIN
            SET @tuNgay =convert(Varchar(max),@nam)+'-01-01';
            SET @denNgay = convert(Varchar(max),@nam)+'-03-31';
        END
        ELSE IF (@quy = 2)
        BEGIN
            SET @tuNgay = convert(Varchar(max),@nam)+'-04-01';
            SET @denNgay =convert(Varchar(max),@nam)+'-06-30';
        END
        ELSE IF (@quy = 3)
        BEGIN
            SET @tuNgay =convert(Varchar(max),@nam)+'-07-01';
            SET @denNgay =convert(Varchar(max),@nam)+'-09-30';
        END
        ELSE
        BEGIN
            SET @tuNgay =convert(Varchar(max),@nam)+'-10-10';
            SET @denNgay =convert(Varchar(max),@nam)+'-12-31';
        END


        IF CHARINDEX(CONVERT(VARCHAR(10), @quy), @quyList) > 0
        BEGIN
            SELECT dh.maDonHang, dh.tenDonHang, dh.thoiGianDat, dh.tongGia,(select sum(dh.tongGia) from DonHang dh  WHERE dh.thoiGianDat BETWEEN @tuNgay AND @denNgay)  as tongDoanhThu
            FROM DonHang dh
            WHERE thoiGianDat BETWEEN @tuNgay AND @denNgay;
        END

        SET @quy = @quy + 1;
    END
END




create proc select_NguyenLieuBan_NTN
 @loai varchar(max), @ngay datetime
as
if(@loai='ngay')
begin
select tttpda.maThanhPhan,mh.tenHang,(ttdh.soLuong*tttpda.soLuong) as soLuong, (ttdh.soLuong*tttpda.soLuong*donGia) as TongGiaBan,
(
select sum((ttdh.soLuong*tttpda.soLuong*donGia))
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn) as TongGia
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn
and dh.thoiGianDat=@ngay
end
else if(@loai='thang')
begin
select tttpda.maThanhPhan,mh.tenHang,(ttdh.soLuong*tttpda.soLuong) as soLuong, (ttdh.soLuong*tttpda.soLuong*donGia) as TongGiaBan,
(
select sum((ttdh.soLuong*tttpda.soLuong*donGia))
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn) as TongGia
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn
and MONTH(dh.thoiGianDat)=MONTH(@ngay)
end
else if(@loai='nam')
begin
select tttpda.maThanhPhan,mh.tenHang,(ttdh.soLuong*tttpda.soLuong) as soLuong, (ttdh.soLuong*tttpda.soLuong*donGia) as TongGiaBan,
(
select sum((ttdh.soLuong*tttpda.soLuong*donGia))
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn) as TongGia
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn
and YEAR(dh.thoiGianDat)=YEAR(@ngay)
end

--exec select_NguyenLieuBan_NTN 'nam','2023'

create  proc select_NguyenLieuBan_MTG
@tg1 datetime,@tg2 datetime
as
select tttpda.maThanhPhan,mh.tenHang,(ttdh.soLuong*tttpda.soLuong) as soLuong, (ttdh.soLuong*tttpda.soLuong*donGia) as TongGiaBan,
(
select sum((ttdh.soLuong*tttpda.soLuong*donGia))
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn) as TongGia
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn
and dh.thoiGianDat between @tg1 and @tg2

----------------------

create PROCEDURE  select_NguyenLieuBan_Q
(
    @nam int,
    @quyList VARCHAR(max)
)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @quy INT;
    DECLARE @tuNgay varchar(max);
    DECLARE @denNgay varchar(max);

    SET @quy = 1;
    WHILE (@quy <= 4)
    BEGIN
       IF (@quy = 1)
        BEGIN
            SET @tuNgay =convert(Varchar(max),@nam)+'-01-01';
            SET @denNgay = convert(Varchar(max),@nam)+'-03-31';
        END
        ELSE IF (@quy = 2)
        BEGIN
            SET @tuNgay = convert(Varchar(max),@nam)+'-04-01';
            SET @denNgay =convert(Varchar(max),@nam)+'-06-30';
        END
        ELSE IF (@quy = 3)
        BEGIN
            SET @tuNgay =convert(Varchar(max),@nam)+'-07-01';
            SET @denNgay =convert(Varchar(max),@nam)+'-09-30';
        END
        ELSE
        BEGIN
            SET @tuNgay =convert(Varchar(max),@nam)+'-10-10';
            SET @denNgay =convert(Varchar(max),@nam)+'-12-31';
        END


        IF CHARINDEX(CONVERT(VARCHAR(10), @quy), @quyList) > 0
        BEGIN
            select tttpda.maThanhPhan,mh.tenHang,(ttdh.soLuong*tttpda.soLuong) as soLuong, (ttdh.soLuong*tttpda.soLuong*donGia) as TongGiaBan,
(
select sum((ttdh.soLuong*tttpda.soLuong*donGia))
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn) as TongGia
from ThongTinDonHang ttdh , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh, DonHang dh
where ttdh.maSanPham=sp.maSanPham
and ttdh.maDonHang=dh.maDonHang
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn
and dh.thoiGianDat BETWEEN @tuNgay AND @denNgay;
        END

        SET @quy = @quy + 1;
    END
END



exec select_NguyenLieuBan_Q '2023','4'





create proc select_LoaiKhach
as
	select * from LoaiKhachHang
