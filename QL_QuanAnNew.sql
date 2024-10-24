/*
Created		10/22/2024
Modified		10/24/2024
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/


Create table [NhanVien]
(
	[MaNV] Integer NOT NULL,
	[TenNV] Nvarchar(255) NOT NULL,
	[SoDT] Varchar(11) NULL,
	[MucLuong] Decimal(18,0) NULL,
	[MaCV] Integer NOT NULL,
Primary Key ([MaNV])
) 
go

Create table [KhachHang]
(
	[MaKH] Integer NOT NULL,
	[TenKH] Nvarchar(255) NULL,
	[SoDT] Varchar(11) NULL,
Primary Key ([MaKH])
) 
go

Create table [HoaDon]
(
	[MaHD] Integer NOT NULL,
	[NgayLap] Datetime NULL,
	[TongTien] Decimal(10,2) NULL,
	[MaKH] Integer NOT NULL,
	[MaBan] Integer NOT NULL,
	[MaTT] Integer NOT NULL,
	[MaNV] Integer NOT NULL,
Primary Key ([MaHD])
) 
go

Create table [ChiTietHoaDon]
(
	[MaCTHD] Integer NOT NULL,
	[SoLuong] Integer NULL,
	[ThanhTien] Decimal(10,2) NULL,
	[MaHD] Integer NOT NULL,
	[MaMonAn] Integer NOT NULL,
Primary Key ([MaCTHD])
) 
go

Create table [MonAn]
(
	[MaMonAn] Integer NOT NULL,
	[TenMonAn] Nvarchar(255) NULL,
	[Gia] Decimal(10,2) NULL,
	[MaDanhMuc] Integer NOT NULL,
Primary Key ([MaMonAn])
) 
go

Create table [DanhMucMonAn]
(
	[MaDanhMuc] Integer NOT NULL,
	[TenDanhMuc] Nvarchar(255) NULL,
Primary Key ([MaDanhMuc])
) 
go

Create table [BanAn]
(
	[MaBan] Integer NOT NULL,
	[TenBan] Nvarchar(255) NULL,
	[TrangThai] Nvarchar(255) NULL,
Primary Key ([MaBan])
) 
go

Create table [ThanhToan]
(
	[MaTT] Integer NOT NULL,
	[PhuongThucTT] Nvarchar(255) NULL,
	[NgayThanhToan] Datetime NULL,
Primary Key ([MaTT])
) 
go

Create table [TaiKhoan]
(
	[TenDN] Char(1) NOT NULL,
	[MatKhau] Char(1) NULL,
	[LoaiTK] Char(1) NULL,
	[MaNV] Integer NOT NULL,
Primary Key ([TenDN],[MaNV])
) 
go

Create table [ChucVu]
(
	[MaCV] Integer NOT NULL,
	[TenCV] Nvarchar(200) NULL,
Primary Key ([MaCV])
) 
go


Alter table [HoaDon] add  foreign key([MaNV]) references [NhanVien] ([MaNV])  on update no action on delete no action 
go
Alter table [TaiKhoan] add  foreign key([MaNV]) references [NhanVien] ([MaNV])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaKH]) references [KhachHang] ([MaKH])  on update no action on delete no action 
go
Alter table [ChiTietHoaDon] add  foreign key([MaHD]) references [HoaDon] ([MaHD])  on update no action on delete no action 
go
Alter table [ChiTietHoaDon] add  foreign key([MaMonAn]) references [MonAn] ([MaMonAn])  on update no action on delete no action 
go
Alter table [MonAn] add  foreign key([MaDanhMuc]) references [DanhMucMonAn] ([MaDanhMuc])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaBan]) references [BanAn] ([MaBan])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaTT]) references [ThanhToan] ([MaTT])  on update no action on delete no action 
go
Alter table [NhanVien] add  foreign key([MaCV]) references [ChucVu] ([MaCV])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


