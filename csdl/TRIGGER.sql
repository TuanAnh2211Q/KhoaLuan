--Trigger tự tạo tài khoản nhân viên

--drop trigger tg_TaoTK
create trigger tg_TaoTK on NhanVien after insert as
begin
declare @tk varchar(10)=(select maNhanVien from inserted),
             @chucdanh varchar(10)=(select maChucDanh from inserted),
			 @quyen varchar(10)
			 if(@chucdanh='CD001')
			    set  @quyen='MQ001' 
			 else
			    set @quyen='MQ002'

            insert into TaiKhoanNhanVien values (@tk, '1',@tk,@quyen)
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


--
create trigger update_quyenTk_nhanvien on NhanVien after update
as
begin
declare @maChucDanh varchar(10)=(select maChucDanh from inserted)
if(@maChucDanh='CD001')
begin
update  TaiKhoanNhanVien
set MaQuyen='MQ001'
where maNhanVien=(select maNhanVien from inserted)
end
else if(@maChucDanh='CD002')
begin
update  TaiKhoanNhanVien
set MaQuyen='MQ002'
where maNhanVien=(select maNhanVien from inserted)
end
end
-------------------------------------------SẢN PHẨM----------------------------------------------------
------ĐỒ ĂN-------------------
--Thêm đồ ăn vào loại sản phẩm
create trigger insert_doAn on DoAn instead of insert as
begin
declare @masp nchar(30)= (select maDoAn from inserted),
             @maLoaiDoAn nchar(30)=(select maLoaiDoAn from inserted),
			 @tenDoAn nvarchar(50)=(select tenDoAn from inserted)
	insert into SanPham values(@masp,'MLSP001')
	insert into DoAn values(@masp,@maLoaiDoAn,@tenDoAn)
end
insert into DoAn values ('MDA001','MLDA001','Burger')
insert into ThongTinDoAn values('MDA001','cái',50000,'burger thơm ngon mời bạn ăn nha')
delete from DoAn where maDoAn='MDA001'

select * from ThongTinDoAn
--Xóa đồ ăn trong loại sản phẩm

create   trigger delete_doAn on DoAn instead of  delete as
begin
alter table DoAn drop constraint fk_DoAn_SanPham
declare @masp nchar(30)= (select maDoAn from deleted)
delete from ThongTinThanhPhanDoAn where maDoAn=@masp
delete from ThongTinDoAn where maDoAn=@masp
delete from SanPham where maSanPham=@masp
delete from DoAn where maDoAn=@masp
alter table DoAn add constraint fk_DoAn_SanPham foreign key (maDoAn) references SanPham(maSanPham)
end


------NƯỚC UỐNG-------------------
------Thêm nước uống----
create trigger insert_NuocUong on NuocUong instead of insert as
begin
declare @masp nchar(30)= (select maNuoc from inserted),
			 @tenNuocUong nvarchar(50)=(select tenNuoc from inserted),
			 @donViBan nvarchar(10)=(select donViBan from inserted),
			 @giaBan money=(select giaBanNuoc from inserted)
insert into SanPham values(@masp,'MLSP002')
insert into NuocUong values(@masp,@tenNuocUong,@donViBan,@giaBan)
end
go

--Xóa nước uống trong loại sản phẩm
create trigger delete_NuocUong on NuocUong instead of  delete as
begin
alter table NuocUong drop constraint fk_NuocUong_SanPham
declare @masp nchar(30)= (select maNuoc from deleted)
delete from SanPham where maSanPham=@masp
delete from NuocUong where maNuoc=@masp
alter table NuocUong add constraint fk_NuocUong_SanPham foreign key (maNuoc) references SanPham(maSanPham)
end
go
-----------------------------------------------------------------------------------------------------------------------------------------------
--------NHÀ CUNG CẤP
--Xóa nhà cung cấp
create trigger delete_NCC on NhaCungCap instead of delete as
begin
declare @maNCC varchar(10)=(select maNCC from deleted)

if exists( select * from MatHang where maNCC=@maNCC)
begin
update MatHang set maNCC=null where maNCC=@maNCC
delete from NhaCungCap where maNCC=@maNCC
end

if exists(select * from ThongTinDatHang where maNCC=@maNCC)
begin
update ThongTinDatHang set maNCC=null where maNCC=@maNCC
update DatHang set ghiChu=ghiChu+ N', nhà cung cấp đã ngưng hợp tác ' where maDatHang in (select maDatHang from ThongTinDatHang where maNCC=@maNCC)
delete from NhaCungCap where maNCC=@maNCC
end

if exists(select * from ThongTinNhapKho where maNCC=@maNCC)
begin
update ThongTinNhapKho set maNCC=null where maNCC=@maNCC
update NhapKho set ghiChu=ghiChu+ N', nhà cung cấp đã ngưng hợp tác ' where maNhap in (select maNhap from ThongTinNhapKho where maNCC=@maNCC)
delete from NhaCungCap where maNCC=@maNCC
end
else
begin
delete from NhaCungCap where maNCC=@maNCC
end
end

select * from NhaCungCap
select * from MatHang
select * from ThongTinDatHang
select * from ThongTinNhapKho












---------------------------------ĐẶT HÀNG-------------------------------
--Thêm thông tin đặt hàng
create  trigger trg_insert_ThongTinDatHang on ThongTinDatHang instead of insert
as
begin
declare 
			@madat varchar(10)=(select maDatHang from inserted),
			@mahang varchar(10) =(select maHang from inserted),
			@maNCC varchar(10)=(select mh.maNCC from MatHang mh, inserted i where mh.maHang=i.maHang),
			@soluongdat int=(select soLuongDat from inserted),
			@dongia money=(select donGia from MatHang mh, inserted i where mh.maHang=i.maHang),
			@tongdongia money
			set @tongdongia=@soluongdat*@dongia
			if not exists(select * from ThongTinDatHang  where maHang=@mahang and maDatHang=@madat and maNCC=@maNCC)
			begin
			insert into ThongTinDatHang values(@madat,@mahang,@maNCC,@soluongdat,(select tongDonGia=@tongdongia from inserted))
			end
			else
			begin
			update ThongTinDatHang
			set soLuongDat=soLuongDat+@soluongdat,
		    tongDonGia=tongDonGia+@tongdongia
			where maHang=@mahang and maDatHang=@madat and maNCC=@maNCC
			end
end
go


--Cập nhật thông tin đặt hàng
create  trigger trg_update_ThongTinDatHang on ThongTinDatHang instead of update
as
begin
declare 
			@madat varchar(10)=(select maDatHang from inserted),
			@mahang varchar(10) =(select maHang from inserted),
			@maNCC varchar(10)=(select mh.maNCC from MatHang mh, inserted i where mh.maHang=i.maHang),
			@soluongdat int=(select soLuongDat from inserted),
			@dongia money=(select donGia from MatHang mh, inserted i where mh.maHang=i.maHang),
			@tongdongia money
			set @tongdongia=@soluongdat*@dongia
			
			update ThongTinDatHang
			set soLuongDat=@soluongdat,
		    tongDonGia=@tongdongia
			where maHang=@mahang and maDatHang=@madat and maNCC=@maNCC
end
 go

 insert into ThongTinDatHang values ('MD001','MH002',null,1,null)

 update ThongTinDatHang
 set soLuongDat=3 where maDatHang='MD001' and maHang='MH001' and maNCC='NCC001'

 select * from ThongTinDatHang



 --Xóa phiếu đặt
 create trigger trg_deletePhieuDat on DatHang instead of delete
 as
 begin
 delete from ThongTinDatHang where maDatHang=(select maDatHang from deleted)
 delete from DatHang where maDatHang=(select maDatHang from deleted)
 end

 create  trigger trg_insertPhieuDat on DatHang instead of insert
 as
 begin
 declare 
    @maphieu varchar(10)=(select maDatHang from inserted),
	@ngayDat datetime =(select ngayDatHang from inserted),
	@ngayGiao datetime =(select ngayDuKienGiao from inserted),
	@ghiChu nvarchar(max)=(select ghiChu from inserted),
	@phuongThuc nvarchar(5)=(select phuongThucThanhToan from inserted),
	@trangThai bit=0

 insert into DatHang values(@maPhieu,@ngayDat,@ngayGiao,@ghiChu,@phuongThuc,(select trangThai=@trangThai from inserted))
 end


 ---------------TRẢ HÀNG---------------------------------------


 set dateformat dmy

 exec insert_DatHang  'MD002','20/11/2022','20/12/2022','Không có gì','Chuyển khoản'

















 ----------NHẬP KHO-----------------------------------
----Thêm tổng giá thông tin phiếu nhập
create  trigger insert_TongGia_NhapKho on ThongTinNhapKho instead of insert as
begin 
	     declare
		    @maNhap varchar(10)=(select maNhap from inserted),
			@maNCC varchar(10)=(select mh.maNCC from  MatHang mh, inserted where inserted.maHang=mh.maHang ),
			 @donGia money=( select mh.donGia from MatHang mh, inserted where inserted.maHang=mh.maHang),
             @maHang varchar(10)=(select maHang from inserted),
             @soLuongNhap int= (select soLuong from inserted),
			 @tongDonGia money
			 
			 set @tongDonGia=@soLuongNhap*@donGia
			 	if not exists(select * from ThongTinNhapKho where maHang=@maHang and maNhap=@maNhap and maNCC=@maNCC)
			begin
			insert into ThongTinNhapKho values(@maNhap,@maNCC,@maHang,@soLuongNhap,(select tongDonGia=@tongDonGia from inserted))
			end
			else
			begin
			update ThongTinNhapKho
			set soLuong=soLuong+@soLuongNhap,
		    tongDonGia=tongDonGia+@tongDonGia
			where maHang=@maHang and maNhap=@maNhap and maNCC=@maNCC
			end
		  
end
go

insert into ThongTinNhapKho values('MN001',null,'MH001',1,null)
select * from ThongTinNhapKho

--Cập nhật thông tin phiếu nhập
create trigger update_TongGia_NhapKho on ThongTinNhapKho instead of update as
begin 
	     declare
		    @maNhap varchar(10)=(select maNhap from inserted),
			@maNCC varchar(10)=(select mh.maNCC from  MatHang mh, inserted where inserted.maHang=mh.maHang ),
			 @donGia money=( select mh.donGia from MatHang mh, inserted where inserted.maHang=mh.maHang),
             @maHang varchar(10)=(select maHang from inserted),
             @soLuongNhap int= (select soLuong from inserted),
			 @tongDonGia money
			 
			 set @tongDonGia=@soLuongNhap*@donGia
			update ThongTinNhapKho
			set soLuong=@soLuongNhap,
		    tongDonGia=@tongDonGia
			where maHang=@maHang and maNhap=@maNhap and maNCC=@maNCC
			
		  
end
go
--select * from ThongTinNhapKho
--	   insert into ThongTinNhapKho values ('MN001','MH001','NCC001',1,null)
--update ThongTinNhapKho set soLuong=5 where maHang='MH002' and maNhap='MN001'




















--======================KHUYẾN MÃI===========================
create trigger delete_on_KhuyenMai on KhuyenMai instead of delete
as
declare @maKhuyenMai varchar(10)=(select maKhuyenMai from deleted)
delete from ThongTinKhuyenMai where maKhuyenMai=@maKhuyenMai
delete from KhuyenMai where maKhuyenMai=@maKhuyenMai