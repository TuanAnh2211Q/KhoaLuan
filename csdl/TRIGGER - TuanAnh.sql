-------------NHẬP KHO------------
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



 ---12-12-2022






create trigger trg_update_KhoBan on ThongTinDonHang instead of insert
as
begin
declare
@maThanhPhan varchar(10),
@soLuongDung int,
@donGia money,
@maDonHang varchar(10)= (select maDonHang from inserted),
@maSanPham varchar(10)=(select maSanPham from inserted),
@giaTien money =(select giaTien from inserted),
@soLuong int=(select soLuong from inserted),
@thanhTien money =(select thanhTien from inserted),
@maLoaiSanPham varchar(10)=(select maLoaiSanPham from inserted,SanPham where inserted.maSanPham=SanPham.maSanPham)
if(@maLoaiSanPham='MLSP001')
begin
DECLARE capNhatKhoBan CURSOR FOR  
select tttpda.maThanhPhan, (i.soLuong*tttpda.soLuong) as soLuongCheBien,donGia
from inserted i , SanPham sp, ThongTinThanhPhanDoAn tttpda, MatHang mh
where i.maSanPham=sp.maSanPham
and mh.maHang=tttpda.maThanhPhan
and sp.maSanPham=tttpda.maDoAn     -- dữ liệu trỏ tới

Open capNhatKhoBan

FETCH NEXT FROM capNhatKhoBan
      INTO @maThanhPhan, @soLuongDung,@donGia

WHILE @@FETCH_STATUS = 0   
begin
update KhoBan
set soLuong=soLuong-@soLuongDung,
	tongGia=tongGia-(@donGia*@soLuongDung)
where maHang=@maThanhPhan

FETCH NEXT FROM capNhatKhoBan
INTO @maThanhPhan,@soLuongDung,@donGia
end
close capNhatKhoBan
Deallocate capNhatKhoBan
end
else if (@maLoaiSanPham='MLSP002')
begin
DECLARE capNhatKhoBan_Nuoc CURSOR FOR  
select i.maSanPham,i.SoLuong, donGia
from inserted i , SanPham sp, MatHang mh
where i.maSanPham=sp.maSanPham
and mh.maHang=sp.maSanPham
and sp.maLoaiSanPham='MLSP002'     -- dữ liệu trỏ tới

Open capNhatKhoBan_Nuoc

FETCH NEXT FROM capNhatKhoBan_Nuoc
      INTO @maThanhPhan, @soLuongDung,@donGia

WHILE @@FETCH_STATUS = 0   
begin
update KhoBan
set soLuong=soLuong-@soLuongDung,
	tongGia=tongGia-(@donGia*@soLuongDung)
where maHang=@maThanhPhan

FETCH NEXT FROM capNhatKhoBan_Nuoc
INTO @maThanhPhan,@soLuongDung,@donGia
end
close capNhatKhoBan_Nuoc
Deallocate capNhatKhoBan_Nuoc
end


end



	create trigger trg_insert_KhachHang on KhachHang instead of insert
	as
	begin

	declare @tenKH nvarchar(50) =(select tenKhachHang from inserted),
				@phai nvarchar(50)=(select Phai from inserted),
				@sdt varchar(11)=(select SDT from inserted),
				@email varchar(50)=(select Email from inserted),
				@diachi nvarchar(100)=(select diaChi from inserted),
				@ghichu nvarchar(max)=(select ghiChu from inserted)

				if exists(select * from KhachHang where SDT=@sdt )
				begin
				update KhachHang set Phai=@phai, Email=@email, diaChi=@diachi,ghiChu=@ghichu where SDT=@sdt
				end
				else
				insert into KhachHang values (@tenKH,@phai,@sdt,@email,@diachi,@ghichu)
	end





