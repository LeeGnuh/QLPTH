Go
Create database Demo3Layer
Use Demo3Layer

Go
Create table DanhMuc
(
    MaDM int primary key ,
    TenDM nvarchar(200),    
);

Go
Create table SanPham
(
	MaSP int primary key,
	TenSP nvarchar(200),
	GiaSP int,
	MaDM int,
	
	CONSTRAINT fk_SanPham_DanhMuc FOREIGN KEY (MaDM) REFERENCES DanhMuc (MaDM)
);

Go
Create table NguoiDung
(
	MaND int primary key,
	TenND nvarchar(200),
	Uname nvarchar(200),
	UPass varchar(200),
);

Go
Create table HoaDon
(
	MaHD int primary key,
	MaND int,
	NgayTao varchar(200),
	 
	CONSTRAINT fk_HoaDon_NguoiDung FOREIGN KEY (MaND) REFERENCES NguoiDung (MaND)
);

Go
Create table ChiTietHD
(
	MaHD int,
	MaSP int,
	SoLuong int,
	Primary key (MaHD,MaSP),

	CONSTRAINT fk_ChiTietHD_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon (MaHD),
	CONSTRAINT fk_ChiTietHD_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham (MaSP)
);

insert into DanhMuc (MaDM, TenDM) VALUES (1, N'Sữa');
insert into DanhMuc (MaDM, TenDM) VALUES (2, N'Trứng');
insert into DanhMuc (MaDM, TenDM) VALUES (3, N'Thịt');

insert into SanPham(MaSP, TenSP, GiaSP, MaDM) VALUES (1, N'Sữa hộp Vinamilk', 5000, 1);
insert into SanPham(MaSP, TenSP, GiaSP, MaDM) VALUES (2, N'Sữa đặc TH true MILK', 10000, 1);
insert into SanPham(MaSP, TenSP, GiaSP, MaDM) VALUES (3, N'Trứng gà', 2500, 2);
insert into SanPham(MaSP, TenSP, GiaSP, MaDM) VALUES (4, N'Trứng vịt', 3000, 2);
insert into SanPham(MaSP, TenSP, GiaSP, MaDM) VALUES (5, N'Thịt heo', 19000, 3);
insert into SanPham(MaSP, TenSP, GiaSP, MaDM) VALUES (6, N'Thịt bò', 21000, 3);

insert into NguoiDung(MaND, TenND, Uname, UPass) VALUES (1, N'Bà hàng xóm', N'hangxomthanthien', '123456');

insert into HoaDon(MaHD, MaND, NgayTao) VALUES (1, 1, '01/06/2022');

insert into ChiTietHD(MaHD, MaSP, SoLuong) VALUES (1, 1, 12);
insert into ChiTietHD(MaHD, MaSP, SoLuong) VALUES (1, 3, 20);
insert into ChiTietHD(MaHD, MaSP, SoLuong) VALUES (1, 4, 5);

