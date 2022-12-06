use QLCUAHANGTHUCANNHANH
go

alter table SanPham add constraint fk_SanPham_LoaiSanPham foreign key (maLoaiSanPham) references LoaiSanPham(maLoaiSanPham)
go

 alter table DoAn add constraint fk_DoAn_SanPham foreign key(maDoAn)references SanPham(maSanPham)
 go

  alter table NuocUong add constraint fk_NuocUong_SanPham foreign key(maNuoc) references SanPham(maSanPham)
  go


   alter table DoAn add constraint fk_LoaiDoAn_DoAn foreign key (MaLoaiDoAn) references LoaiDoAn (maLoaiDoAn)
 go
alter table ThongTinDoAn add constraint fk_DoAn_ThongTinDoAn foreign key (maDoAn) references DoAn (maDoAn)
 go






  alter table MatHang
  add constraint fk_MatHang_NhaCungCap foreign key (maNCC) references NhaCungCap(maNCC)
  go
  alter table ThongTinThanhPhanDoAn
  add constraint fk_ThongTinThanhPhanDoAn_MatHang foreign key (maThanhPhan) references MatHang(maHang)
  go
  alter table ThongTinThanhPhanDoAn
  add constraint fk_ThongTinThanhPhanDoAn_DoAn foreign key (maDoAn) references DoAn(maDoAn)
  go



  alter table ThongTinHangTon
  add constraint fk_ThongTinHangTon_MatHang foreign key (maHang) references MatHang(maHang)
  go




     alter table ThongTinDatHang
  add constraint fk_ThongTinDatHang_NhaCungCap foreign  key (maNCC) references NhaCungCap(maNCC)
  go
  alter table ThongTinDatHang
  add constraint fk_ThongTinDatHang_DatHang foreign  key (maDatHang) references DatHang(maDatHang)
  go
   alter table ThongTinDatHang
  add constraint fk_ThongTinDatHang_MatHang foreign  key (maHang) references MatHang(maHang)
  go


      alter table NhapKho
  add constraint fk_NhapKho_DatHang foreign key (maDatHang) references DatHang(maDatHang)
  go
  alter table ThongTinNhapKho
  add constraint fk_ThongTinNhapKho_NhapKho foreign key (maNhap) references NhapKho(maNhap)
  go
    alter table ThongTinNhapKho
  add constraint fk_ThongTinNhapKho_MatHang foreign key (maHang) references MatHang(maHang)
  go
      alter table ThongTinNhapKho
  add constraint fk_ThongTinChiTietNhapKho_NhaCungCap foreign key (maNCC) references NhaCungCap(maNCC)
  go


  
 alter table TraHang 
 add constraint fk_TraHang_DatHang foreign key (maDatHang) references DatHang(maDatHang)
go
alter table ThongTinTraHang 
 add constraint fk_ThongTinTraHang_TraHang foreign key (maTra) references TraHang(maTra)
go
alter table ThongTinTraHang 
 add constraint fk_ThongTinTraHang_NhaCungCap foreign key (maNCC) references NhaCungCap(maNCC)
go
alter table ThongTinTraHang 
 add constraint fk_ThongTinTraHang_MatHang foreign key (maHang) references MatHang(maHang)
go



      alter table ThongTinXuatKho
  add constraint fk_ThongTinXuatKho_MatHang foreign key (maHang) references MatHang(maHang)
  go
     alter table ThongTinXuatKho
  add constraint fk_ThongTinXuatKho_XuatKho foreign key (maXuat) references XuatKho(maXuat)
  go



  alter table KhuyenMai
  add constraint fk_KhuyenMai_LoaiKhuyenMai foreign key (maLoaiKhuyenMai) references LoaiKhuyenMai(maLoaiKhuyenMai)
  go
  alter table ThongTinKhuyenMai
  add constraint fk_ThongTinKhuyenMai_KhuyenMai foreign key (maKhuyenMai) references KhuyenMai(MaKhuyenMai)
  go
  alter table ThongTinKhuyenMai
  add constraint fk_ThongTinKhuyenMai_SanPham foreign key(maSanPham) references SanPham(maSanPham)
  go




  alter table NhanVien
  add constraint fk_NhanVien_LoaiNhanVien foreign key (maLoaiNhanVien) references LoaiNhanVien(maLoaiNhanVien)
  go

    alter table NhanVien
  add constraint fk_NhanVien_ChucDanh foreign key (maChucDanh) references ChucDanh(maChucDanh)
  go


  alter table ThongTinCaLam
  add constraint fk_ThongTinCaLam_CaLam foreign key (maCaLam) references CaLam(maCaLam)
  go

    alter table ChamCong
  add constraint fk_ChamCong_NhanVien foreign key (maNhanVien) references NhanVien(maNhanVien)
  go

  alter table ChamCong
  add constraint fk_ChamCong_CaLam foreign key
  (maCaLam) references CaLam(maCaLam)
 go


 alter table ThongTinPhucLoi
 add constraint fk_ThongTinPhucLoi_PhucLoi foreign key (maPhucLoi) references PhucLoi(maPhucLoi)
 go

  alter table ThongTinPhucLoi
 add constraint fk_ThongTinPhucLoi_NhanVien foreign key (maNhanVien) references NhanVien(maNhanVien)
 go


 alter table ThongTinViPham
 add constraint fk_ThongTinViPham_ViPham foreign key (maViPham) references ViPham(maViPham)
 go

  alter table ThongTinViPham
 add constraint fk_ThongTinViPham_NhanVien foreign key (maNhanVien) references NhanVien(maNhanVien) 
 go


 alter table TaiKhoanNhanVien
 add constraint fk_TaiKhoanNhanVien_PhanQuyen foreign key (maQuyen) references PhanQuyen(maQuyen)
 go

 alter table TaiKhoanNhanVien
 add constraint fk_TaiKhoanNhanVien_NhanVien foreign key (tenTaiKhoan) references NhanVien(maNhanVien)
 go

 alter table DonHang
 add constraint fk_DonHang_LoaiDonHang foreign key (maLoaiDon) references LoaiDonHang(maLoaiDon)
 go

 alter table ThongTinDonHang
 add constraint fk_ThongTinDonHang_DonHang foreign key (maDonHang) references DonHang(maDonHang)
 go

  alter table DonHang
 add constraint fk_DonHang_HinhThucThanhToan foreign key (maHinhThuc) references HinhThucThanhToan(maHinhThuc)
 go

 
 alter table DonHang
 add constraint fk_DonHang_NhanVien foreign key (maNhanVien) references NhanVien(maNhanVien)
 go

 alter table DonHang
 add constraint fk_DonHang_KhachHang foreign key (SDTKhachHang) references KhachHang(SDT)
 go

 alter table DonHang
 add constraint fk_DonHang_KhuyenMai foreign key (maKhuyenMai) references KhuyenMai(maKhuyenMai)
go

 alter table ThongTinDonHang
 add constraint fk_ThongTinDonHang_SanPham foreign key (maSanPham) references SanPham(maSanPham)
 go



 alter table HoaDon
 add constraint fk_HoaDon_LoaiHoaDon foreign key(maLoaiHoaDon) references LoaiHoaDon(maLoaiHoaDon)
 go

  alter table HoaDon
 add constraint fk_HoaDon_DatHang foreign key(maHoaDon) references DatHang(maDatHang)
 go

   alter table HoaDon
 add constraint fk_HoaDon_NhapKho foreign key(maHoaDon) references NhapKho(maNhap)
 go

   alter table HoaDon
 add constraint fk_HoaDon_XuatKho foreign key(maHoaDon) references XuatKho(maXuat)
 go

   alter table HoaDon
 add constraint fk_HoaDon_TraHang foreign key(maHoaDon) references TraHang(maTra)
 go



  alter table HoaDon
 add constraint fk_HoaDon_maNhanVien foreign key(maNhanVien) references NhanVien(maNhanVien)
 go

 alter table DanhGia
 add constraint fk_DanhGia_KhachHang foreign key (SDTKhachHang) references KhachHang(SDT)
 go

  alter table DanhGia
 add constraint fk_DanhGia_SanPham foreign key (maSanPham) references SanPham(maSanPham)
 go
