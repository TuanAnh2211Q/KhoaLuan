﻿-------------NHẬP KHO------------
create trigger trg_insert_ThongTinNhapKho on ThongTinNhapKho after insert
as
begin

declare 
			@maNCC varchar(10)= (select maNCC from inserted),
			@maHang varchar(10)=(select maHang from inserted),
			@soLuong int=(select soLuong from inserted),
			@tongDonGia money=(select tongDonGia from inserted)

			if not exists(select * from ThongTinHangTon where maHang=@maHang)
			begin
			insert into ThongTinHangTon
			values (@maHang,@soLuong,@tongDonGia)
			end
			else
			begin
			update ThongTinHangTon
			set soLuongTon=soLuongTon+@soLuong,
			tongDonGia=tongDonGia+@tongDonGia
			end
end

create trigger trg_insert_ThongTinXuatKho on ThongTinXuatKho instead of insert, update
as
begin
declare 
			@maXuat varchar(10)=(select maXuat from inserted),
			@maHang varchar(10)=(select maHang from inserted),
			@soLuong int=(select soLuong from inserted),
			@donGia money=(select donGia from inserted,MatHang  mh where inserted.maHang=mh.maHang),
			@ghiChu nvarchar(max)=(select ghiChu from inserted),
			@tongDonGia money
		     set @tongdongia=@soLuong*@donGia
			if not exists(select * from ThongTinXuatKho where maXuat=@maXuat and maHang=@maHang)
			begin
			insert into ThongTinXuatKho values (@maXuat,@maHang,@soLuong,@ghiChu,(select tongDonGia=@tongDonGia from inserted))
			end
			else
			begin
			update ThongTinXuatKho
			set soLuong=soLuong+@soLuong,
					tongDonGia=tongDonGia+@tongDonGia
					where maXuat=@maXuat and maHang=@maHang
			end

end

create trigger trg_delete_PhieuXuat on XuatKho instead of delete
as
begin
declare 
@maXuat varchar(10) =(select maXuat from deleted)
delete from ThongTinXuatKho where maXuat=@maXuat
delete from XuatKho where maXuat=@maXuat
end

create  trigger trg_duyet_PhieuXuat on XuatKho after insert, update
as
begin
declare
@maXuat varchar(10),
@maHang varchar(10),
@soLuong int,
@ghiChu nvarchar(max),
@tongDonGia money

DECLARE thongTinPhieuXuat CURSOR FOR  -- khai báo con trỏ cursorProduct
SELECT inserted.maXuat,maHang,soLuong,ghiChu,tongDonGia FROM inserted,ThongTinXuatKho ttxk where ttxk.maXuat=inserted.maXuat     -- dữ liệu trỏ tới
Open thongTinPhieuXuat
FETCH NEXT FROM thongTinPhieuXuat
      INTO @maXuat, @maHang,@soLuong,@ghiChu,@tongDonGia

WHILE @@FETCH_STATUS = 0   
begin
insert into KhoBan values(@maHang,@soLuong,@tongDonGia,@maXuat)
update ThongTinHangTon
set soLuongTon=soLuongTon-@soLuong,
	 tongDonGia=tongDonGia-@tongDonGia
WHERE maHang=@maHang

FETCH NEXT FROM thongTinPhieuXuat
INTO @maXuat, @maHang,@soLuong,@ghiChu,@tongDonGia
end
close thongTinPhieuXuat
Deallocate thongTinPhieuXuat
end



--ĐẶT HÀNG
ALTER  trigger [dbo].[trg_insertPhieuDat] on [dbo].[DatHang] instead of insert
 as
 begin
 declare 
    @maphieu varchar(10)=(select maDatHang from inserted),
	@ngayDat datetime =(select ngayDatHang from inserted),
	@ngayGiao datetime =(select ngayDuKienGiao from inserted),
	@ghiChu nvarchar(max)=(select ghiChu from inserted),
	@phuongThuc nvarchar(50)=(select phuongThucThanhToan from inserted),
	@trangThai bit=0

 insert into DatHang values(@maPhieu,@ngayDat,@ngayGiao,@ghiChu,@phuongThuc,(select trangThai=@trangThai from inserted))
 end