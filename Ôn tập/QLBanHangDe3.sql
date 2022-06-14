CREATE DATABASE QLBANHANGDE3
GO
USE QLBANHANGDE3;
Go

CREATE TABLE LOAIMATHANG(
	MaLoai int identity(1,1) not null primary key,
	TenLoai nvarchar(100)
	)
Go
CREATE TABLE MATHANG(
	MaMatHang int identity(1,1) not null primary key,
	TenMatHang nvarchar(1000) not null,
	LoaiMatHang int not null foreign key references LOAIMATHANG(MaLoai),
	SoLuongTon int not null default 0,
	DonGia int not null
)
Go

INSERT INTO LOAIMATHANG VALUES (N'Áo khoác')
INSERT INTO LOAIMATHANG VALUES (N'Quần jean')
INSERT INTO LOAIMATHANG VALUES (N'Áo thun')
INSERT INTO LOAIMATHANG VALUES (N'Áo sơ mi')
INSERT INTO LOAIMATHANG VALUES (N'Váy')

INSERT INTO MATHANG VALUES (N'Áo khoác gió nam', 1, 10, 300000)
INSERT INTO MATHANG VALUES (N'Áo khoác gió nữ', 1, 15, 220000)
INSERT INTO MATHANG VALUES (N'Quần jean nam', 2, 20, 250000)
INSERT INTO MATHANG VALUES (N'Quần jean nữ', 2, 13, 170000)
INSERT INTO MATHANG VALUES (N'Áo thun nam', 3, 23, 120000)
INSERT INTO MATHANG VALUES (N'Áo thun nữ', 3, 45, 100000)
INSERT INTO MATHANG VALUES (N'Áo sơ mi nữ', 4, 35, 100000)
INSERT INTO MATHANG VALUES (N'Váy ngắn', 5, 25, 110000)
INSERT INTO MATHANG VALUES (N'Váy dài', 5, 30, 130000)
INSERT INTO MATHANG VALUES (N'Set váy', 5, 40, 280000)

create proc ThemMatHang
@mamh int output,@TenMH nvarchar(1000), @loaiMH int, @slTon int, @donGia int
as
	INSERT INTO MATHANG VALUES (@TenMH, @loaiMH, @slTon, @donGia)
	set @mamh = scope_identity()
--drop proc ThemMatHang
exec ThemMatHang @mamh output,@TenMH, @loaiMH, @slTon, @donGia
----
create proc CapNhatMatHang
@mamh int output,@TenMH nvarchar(1000), @loaiMH int, @slTon int, @donGia int
as
begin
	update mathang set TenMatHang = @TenMH, LoaiMatHang = @loaiMH, SoLuongTon = @slTon, DonGia = @donGia where MaMatHang = @mamh
end
--drop proc CapNhatMatHang
exec CapNhatMatHang @mamh, @TenMH,@loaiMH,@slTon,@donGia
select * from mathang
Select MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia from MatHang, LoaiMatHang
---
create proc ThemLoaiMH
@maloai int output,@TenLoai nvarchar(1000)
as
	INSERT INTO LOAIMATHANG VALUES (@TenLoai)
	set @maloai = scope_identity()
--drop proc ThemMatHang
exec ThemLoaiMH @maloai output, @TenLoai
select * from loaimathang

---
select MaMatHang, TenMatHang, TenLoai, SoLuongTon, DonGia from MatHang, LoaiMatHang

