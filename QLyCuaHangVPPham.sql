---tao csdl----
create database QLyCuaHangVpPham

on 
(
        Name = Qly_CH_data,
		filename = 'D:\QLyCuaHangVpPham\test\qly_ch.mdf',
		size = 5,
		maxsize = 10,
		filegrowth = 2
		)
log on 
(
        Name = ql_ch_log,
		filename ='D:\QLyCuaHangVpPham\qly_ch.ldf',
		size = 5mb,
		filegrowth = 2mb
		)
-----------------------------


---tao bang---


create table TheLoai (
MaLoai char(10) primary key,
TenLoai nvarchar (50),
)


create table DVTinh
(
MaDV char (10) primary key ,
TenDV nvarchar (50),
)

create table ChatLieu(
MaCL char (10) primary key,
TenCL nvarchar (50),)

create table Mau(
MaMau char (10) primary key,
TenM nvarchar(50),
)
create table CongDung(
MaCD char(10) primary key ,
TenCD nvarchar(50),)

create table NuocSX(
MaNc char (10) primary key,
TenNc nvarchar(50),
)

create table DMVPP(

MaVPP char (10) primary key,
TenVPP nvarchar (50),
MaLoai char (10),
MaDV char (10),
MaCl char (10),
MaM char (10),
MaCD char (10),
MaNc char (10),
SoLuong bigint ,
Anh image ,
DonGN money,
DonGB money,
)
    create table NhanVien
	(
	MaNV char (10) primary key,
	TenNV nvarchar (10),
	GioiTinh char (10),
	Ngaysinh Datetime ,
	DT bigint,
	DiaChi nvarchar (50),
	MaCa char (10),
	MaCV char(10),
	)
	create table HDB(
	SoHDB bigint primary key,
	MaNV char(10),
	NgayBan datetime ,
	MaKH char (10),
	TongTien money,
	)
	create table HDN
	(
	SoHDN bigint primary key ,
	MaNV Char (10),
	NgayNhap Datetime,
	MaNCC char (10),
	TongTien money,
	)

	create table KhachHang(
	MaKH char (10) primary key ,
	TenKH nvarchar (50),
	Diachi nvarchar (50),
	DienThoai bigint ,
	)
	create table CV
	(
	MaCV char (10) primary key,
	TenCV nvarchar (50),
	)

	create table ChiTietHDB
	(
	SoHDB char (10) primary key ,
	MaVPP char (10),
	Soluong bigint ,
	DonGia money,
	Giamgia int, 
	ThanhTien money ,
	)
	Create table ChitietHDN
	( SoHDN char (10) primary key,
	  MaVPP char (10),
	  Soluong bigint ,
	  DonGia money,
	  Giamgia int,
	  Thanhtien money)

	  create table NhaCungCap(
	  MaNCC char (10) primary key ,
	  TenNCC nvarchar (50),
	  DiaChi nvarchar(50),
	  DienThoai bigint)

	  create table CaLam
	  (
	  MaC char(10),
	  TenC nvarchar (50),)



