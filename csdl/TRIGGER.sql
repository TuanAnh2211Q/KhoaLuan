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
create  trigger delete_doAn on DoAn instead of  delete as
begin
alter table DoAn drop constraint fk_DoAn_SanPham
declare @masp nchar(30)= (select maDoAn from deleted)
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

--Xóa đồ ăn trong loại sản phẩm
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

--Cập nhật tổng giá thông tin đặt hàng
create  trigger insert_update_TongGia_DatHang on ThongTinDatHang instead of
insert,update as
begin
declare
			@maDatHang varchar(10),
			@maNCC varchar(10),
			 @donGia money,
             @maHang varchar(10),
             @soLuongDat int,
			 @tongDonGia money
			 set @maHang=(select maHang from inserted)
			 set @soLuongDat= (select soLuongDat from inserted)
			 set @donGia=( select mh.donGia from MatHang mh, inserted where inserted.maHang=mh.maHang)
			 set @maDatHang=(select maDatHang from inserted)
			 set @maNCC=(select maNCC from inserted)
			 set @tongDonGia=@soLuongDat*@donGia
		     if exists( select * from ThongTinDatHang where maHang=@maHang and maNCC=@maNCC and maDatHang=@maDatHang)
			 begin
			 if exists(select * from ThongTinDatHang where tongDonGia is null)
			 begin
			       update ThongTinDatHang
				   set tongDonGia=0
				   	 update ThongTinDatHang
			 set soLuongDat=soLuongDat+@soLuongDat,
			      tongDonGia=tongDonGia+@tongDonGia
				  where maHang=@maHang and maNCC=@maNCC and maDatHang=@maDatHang
			 end
			 else
			 begin
			  update ThongTinDatHang
			 set soLuongDat=soLuongDat+@soLuongDat,
			      tongDonGia=tongDonGia+@tongDonGia
				  where maHang=@maHang and maNCC=@maNCC and maDatHang=@maDatHang
			 end
			end
			else
			begin
			insert into ThongTinDatHang values(@maDatHang,@maHang,@maNCC,@soLuongDat,@tongDonGia)
			end
			 end
      --select * from ThongTinDatHang
	   --insert into ThongTinDatHang values ('MD001','MH002','NCC001',1,null)











----Cập nhật tổng giá thông tin phiếu nhập
create  trigger insert_update_TongGia_NhapKho on ThongTinNhapKho instead of insert,update as
begin 
	     declare
		    @maNhap varchar(10),
			@maNCC varchar(10),
			 @donGia money,
             @maHang varchar(10),
             @soLuongNhap int,
			 @tongDonGia money
			 set @maHang=(select maHang from inserted)
			 set @soLuongNhap= (select soLuong from inserted)
			 set @donGia=( select mh.donGia from MatHang mh, inserted where inserted.maHang=mh.maHang)
			 set @maNhap=(select maNhap from inserted)
			 set @maNCC=(select maNCC from inserted)
			 set @tongDonGia=@soLuongNhap*@donGia
		     if exists( select * from ThongTinNhapKho where maHang=@maHang and maNCC=@maNCC and maNhap=@maNhap)
			 begin
			 if exists(select * from ThongTinNhapKho where tongDonGia is null)
			 begin
			       update ThongTinNhapKho
				   set tongDonGia=0
				   	 update ThongTinNhapKho
			 set  soLuong=soLuong+@soLuongNhap,
			      tongDonGia=tongDonGia+@tongDonGia
				  where maHang=@maHang  and maNCC=@maNCC and maNhap=@maNhap
			 end
			 else
			 begin
			  update ThongTinNhapKho
			 set soLuong=soLuong+@soLuongNhap,
			      tongDonGia=tongDonGia+@tongDonGia
				  where maHang=@maHang  and maNCC=@maNCC and maNhap=@maNhap
			 end
			end
			else
			begin
			insert into ThongTinNhapKho values(@maNhap,@maHang,@maNCC,@soLuongNhap,@tongDonGia)
			end
end
go

--select * from ThongTinNhapKho
--	   insert into ThongTinNhapKho values ('MN001','MH001','NCC001',1,null)

