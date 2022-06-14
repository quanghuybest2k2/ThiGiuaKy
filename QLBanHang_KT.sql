
CREATE DATABASE [QLBanHang]
GO

USE [QLBanHang]
GO

/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/6/2022 10:13:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] int IDENTITY(1,1) PRIMARY KEY,
	[TenKH] [nvarchar](50) NOT NULL,
	[SoDienThoai] [nchar](11) NOT NULL,
	[DiaChiGH] [nvarchar](100) NULL)
GO
/****** Object:  Table [dbo].[LoaiMatHang]    Script Date: 6/6/2022 10:13:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiMatHang](
	[MaLoai] int IDENTITY(1,1) PRIMARY KEY,
	[TenLoai] [nvarchar](50) NOT NULL)
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 6/6/2022 10:13:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[MaMatHang] int IDENTITY(1,1) PRIMARY KEY,
	[TenMatHang] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [int] NOT NULL,
	[MaNCC] int NOT NULL,
	[MaLoai] int NOT NULL)
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 6/6/2022 10:13:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] int IDENTITY(1,1) PRIMARY KEY,
	[TenNhaCC] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[SoDienThoai] [nvarchar](11) NOT NULL,
	[MoTa] [nvarchar](100) NULL)
GO

INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Nga', N'0985785745 ', NULL)
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Trần Văn C', N'0842156971 ', N'56/45 Lê Đại Hành')
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Ngô Mộng Nấm', N'0842147876 ', N'26 Cô Giang')
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Lê Văn Tú', N'0896135248 ', N'11/1 Chi Lăng')
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Võ Tuấn', N'0689971324 ', N'52 Tôn Thất Tùng')
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Phan Uyển Nhi', N'0369974325 ', N'19 Trần Phú')
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Trần Quốc', N'0364687165 ', N'25 Vạn Kiếp')
INSERT [dbo].[KhachHang] ([TenKH], [SoDienThoai], [DiaChiGH]) VALUES (N'Trinh Nhat Truong', N'0985732435 ', NULL)
GO
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Bia')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Dầu ăn')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Nước ngọt')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Hạt nêm')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Bột giặt')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Kem đánh răng')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Sữa')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Nước mắm')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Giấy ăn')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Mì tôm')
INSERT [dbo].[LoaiMatHang] ([TenLoai]) VALUES (N'Kẹo')
GO
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Bia 333', 20, 330000, 1,1)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Bia saigon', 20, 350000, 1,1)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai] )VALUES (N'Bia Heniken', 30, 460000, 1,1)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Bia tiger thường', 20, 390000, 1,1)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Bia tiger bạc', 20, 400000, 1,1)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Dầu Neptune 1l', 20, 33000, 2,2)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Dầu Neptune 2l', 20, 64000, 2,2)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Dầu Neptune 5l', 20, 256000, 2,2)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Dầu Simply 1l', 30, 38000, 2,2)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Dầu Simply 2l', 24, 267000, 2,2)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Dầu Simply 5l', 15, 2265000, 2,2)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Pepsi lon', 30, 2200000, 3,3)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Pepsi chai 500ml', 52, 2160000, 3,3)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Coca lon', 35, 2200000, 3,3)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Coca chai 500ml', 24, 2160000, 3,3)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Hạt nêm Knorr 500g',20,  436000, 4,4)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Hạt nêm Knorr 1kg',24,  270000, 4,4)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Hạt nêm Neptune 500g', 33, 31000, 4,4)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Omo 500g', 14, 429000, 5,5)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Omo 1kg', 3, 455000, 5,5)
INSERT [dbo].[MatHang] ([TenMatHang], [SoLuong], [DonGia], [MaNCC], [MaLoai]) VALUES (N'Surf 1kg', 1, 48000, 5,5)
GO
INSERT [dbo].[NhaCungCap] ([TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (N'Đại lý ABC', N'2 An Dương Vương - P2', N'0263345545', N'Bia Sài gòn')
INSERT [dbo].[NhaCungCap] ([TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (N'Đại lý Hoàng Thu', N'16 Phù Đổng Thiên Vương', N'0917465276', N'Bia ken, tiger')
INSERT [dbo].[NhaCungCap] ([TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (N'Uniliver', N'29 Bùi Thị Xuân', N'02633349878', N'Bột giăt, bột nêm Neptune')
INSERT [dbo].[NhaCungCap] ([TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (N'Pepsi Co', N'123 Nguyên Tử Lực', N'02633247343', N'Sản phẩm nước ngọt Pepsi, hạt nêm Knorr')
INSERT [dbo].[NhaCungCap] ([TenNhaCC], [DiaChi], [SoDienThoai], [MoTa]) VALUES (N'Cty Thành Công', N'234 Trần Quý Cáp', N'0983434634', N'Bột giặt Surf')
GO

ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_LoaiMH] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiMatHang] ([MaLoai])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_LoaiMH]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_NhaCC] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_NhaCC]
GO
----
INSERT into KhachHang VALUES (N'Đoàn Quang Huy', N'0859476166', NULL)
select * from khachhang
update khachhang set TenKH = N'Đoàn Quang Huy', SoDienThoai = 9874561230, diachigh = N'Phan Rang' where makh = 26
select mamathang, tenmathang, soluong, dongia, dongia * soluong as thanhtien from mathang
---
select * from nhacungcap

---- Them
create proc ThemNhaCungCap
@MaNhaCC int output, @TenNhaCC nvarchar(50), @DiaChi nvarchar(100), @SoDienThoai nvarchar(11), @MoTa nvarchar(100)
as
	insert into NhaCungCap values(@TenNhaCC, @DiaChi, @SoDienThoai, @MoTa)
	set @MaNhaCC = scope_identity()
exec ThemNhaCungCap @MaNhaCC output, @TenNhaCC, @DiaChi, @SoDienThoai, @MoTa
--- cap nhat
create proc CapNhatNhaCungCap
@MaNhaCC int output, @TenNhaCC nvarchar(50), @DiaChi nvarchar(100), @SoDienThoai nvarchar(11), @MoTa nvarchar(100)
as
	update NhaCungCap set TenNhaCC = @TenNhaCC, DiaChi = @DiaChi, SoDienThoai = @SoDienThoai, MoTa = @MoTa where MaNhaCC = @MaNhaCC
--exec CapNhatNhaCungCap @MaNhaCC, @TenNhaCC, @DiaChi, @SoDienThoai, @MoTa
exec CapNhatNhaCungCap 2, N'Thành thành công', N'Ninh Thuận', N'6626262', N'Bia ngon 3 miền nè'
Select MaNhaCC, TenNhaCC from NhaCungCap
