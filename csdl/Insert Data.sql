use QLCUAHANGTHUCANNHANH
go

--==================================== Insert Thông Tin =============================

-------------------------Đồ Ăn----------------
insert into DoAn
values ('SP001','SPDA01',N'Gà Truyền Thống',''),
('SP002','SPDA02','Gà Sốt Cay',''),
('SP003','SPDA03','Gà Sốt Bơ','')


insert into LoaiDoAn
values ('DA01','SPDA01'),
('DA02','SPDA02'),
('DA03','SPDA03')
-------------------------Nước Uống----------------
insert into NuocUong
values ('SP004',N'Coke Lớn','1,5 lít',40000000),
 ('SP005',N'Coke nhỏ','390 ml',25000000),
 ('SP006',N'Fanta Lớn','1,5 lít',40000000)