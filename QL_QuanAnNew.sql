/*
Created		10/22/2024
Modified		10/25/2024
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
	[MaCV] Integer NOT NULL,
	[TenNV] Nvarchar(255) NOT NULL,
	[SoDT] Varchar(11) NOT NULL,
	[MucLuong] Decimal(18,0) NOT NULL,
Primary Key ([MaNV])
) 
go

Create table [KhachHang]
(
	[MaKH] Integer NOT NULL,
	[TenKH] Nvarchar(255) NOT NULL,
	[SoDT] Varchar(11) NULL,
	[GhiChu] Nvarchar(255) NULL,
Primary Key ([MaKH])
) 
go

Create table [HoaDon]
(
	[MaHD] Integer NOT NULL,
	[MaKH] Integer NOT NULL,
	[MaNV] Integer NOT NULL,
	[MaDT] Integer NOT NULL,
	[NgayLap] Datetime NOT NULL,
	[TongTien] Decimal(10,2) NOT NULL,
Primary Key ([MaHD])
) 
go

Create table [ChiTietHoaDon]
(
	[MaCTHD] Integer NOT NULL,
	[SoLuong] Integer NOT NULL,
	[ThanhTien] Decimal(10,2) NOT NULL,
	[MaHD] Integer NOT NULL,
	[MaMonAn] Integer NOT NULL,
Primary Key ([MaCTHD])
) 
go

Create table [MonAn]
(
	[MaMonAn] Integer NOT NULL,
	[TenMonAn] Nvarchar(255) NOT NULL,
	[GiaBan] Decimal(18,0) NOT NULL,
	[GiaMua] Decimal(18,0) NOT NULL,
	[MaDanhMuc] Integer NOT NULL,
Primary Key ([MaMonAn])
) 
go


Create table [DanhMucMonAn]
(
	[MaDanhMuc] Integer NOT NULL,
	[TenDanhMuc] Nvarchar(255) NOT NULL,
Primary Key ([MaDanhMuc])
) 
go

Create table [TaiKhoan]
(
	[MaTK] Integer NOT NULL,
	[TenDN] Varchar(100) NOT NULL,
	[MatKhau] Varchar(100) NOT NULL,
	[MaNV] Integer NOT NULL,
	[LoaiTK] Varchar(50) NOT NULL,
Primary Key ([MaTK],[MaNV])
) 
go


Create table [ChucVu]
(
	[MaCV] Integer NOT NULL,
	[TenCV] Nvarchar(200) NOT NULL,
Primary Key ([MaCV])
) 
go

Create table [DoanhThu]
(
	[MaDT] Integer NOT NULL,
	[Ngay] Datetime NOT NULL,
	[SLMonAnBanRa] Integer NOT NULL,
	[SLNuocBanRa] Integer NOT NULL,
	[LoiNhuan] Decimal(18,0) NOT NULL,
Primary Key ([MaDT])
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
Alter table [NhanVien] add  foreign key([MaCV]) references [ChucVu] ([MaCV])  on update no action on delete no action 
go
Alter table [HoaDon] add  foreign key([MaDT]) references [DoanhThu] ([MaDT])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


