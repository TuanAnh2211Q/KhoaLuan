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
