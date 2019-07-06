create database QuanLiDaiLi1
go

use QuanLiDaiLi1
go

create table QuyDinh1 
(
	Id int identity(1,1) primary key,
	LoaiDaiLy nvarchar(100),
	SoLuong int not null 
)
go
create table Quan
(
	id int identity(1,1) primary key,
	TenQuan nvarchar(100),
	SoDaiLi int not null
)

create table HoSoDaiLi1
(
	Id nvarchar(128) primary key,
	TenDaiLy nvarchar(100) ,
	IdLoaiDaiLy int not null,
	Phone nvarchar(100),
	Address nvarchar(200),
	IdQuan int not null,
	NgayTiepNhan Date not null,
	
	
	foreign key(IdLoaiDaiLy) references QuyDinh1(Id),
	foreign key(IdQuan) references Quan(Id),
)
go


create table PhieuThuTien1
(
	Id int identity(1,1) primary key,
	IdTenDaiLy nvarchar(128)not null,	
	Address nvarchar(100),
	Phone nvarchar(100),
	Email nvarchar(100),
	NgayThuTien date not null,
	SoTienThu float default 0,

	foreign key(IdTenDaiLy) references HoSoDaiLi1(Id)
)
go
create table PhieuXuatHang1
(
	Id int identity(1,1) primary key,
	IdTenDaiLy nvarchar(128) not null,
	NgayLapPhieu date not null,
	MatHang nvarchar(50) not null,
	DonViTinh nvarchar(20) not null,
	SoLuong int not null,
	DonGia float default 0 not null,
	ThanhTien int not null
	

	foreign key(IdTenDaiLy) references HoSoDaiLi1(Id)
)
go

create table UserRolee1
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max)
)
go

insert into UserRolee1(DisplayName) values(N'Admin')
go
insert into UserRolee1(DisplayName) values(N'Nhân viên')
go

create table Userss1
(
	Id int identity(1,1) primary key,
	DisplayName nvarchar(max),
	UserName nvarchar(100),
	Password nvarchar(max),
	IdRole int not null

	foreign key (IdRole) references UserRolee1(Id)
)
go
insert into Userss1(DisplayName, Username, Password, IdRole) values(N'Admin	', N'admin', N'db69fc039dcbd2962cb4d28f5891aae1', 1)
go
insert into Userss1(DisplayName, Username, Password, IdRole) values(N'Nhân viên', N'staff', N'978aae9bb6bee8fb75de3e4830a1be46', 2)
go