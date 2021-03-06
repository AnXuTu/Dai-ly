USE [master]
GO
/****** Object:  Database [QuanLiDaiLi1]    Script Date: 30/06/2019 4:33:15 PM ******/
CREATE DATABASE [QuanLiDaiLi1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLiDaiLi1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiDaiLi1.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLiDaiLi1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLiDaiLi1_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLiDaiLi1] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLiDaiLi1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLiDaiLi1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLiDaiLi1] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiDaiLi1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLiDaiLi1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLiDaiLi1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLiDaiLi1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLiDaiLi1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLiDaiLi1] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLiDaiLi1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLiDaiLi1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLiDaiLi1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLiDaiLi1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLiDaiLi1]
GO
/****** Object:  Table [dbo].[HoSoDaiLi1]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSoDaiLi1](
	[Id] [nvarchar](128) NOT NULL,
	[TenDaiLy] [nvarchar](100) NULL,
	[IdLoaiDaiLy] [int] NOT NULL,
	[Phone] [nvarchar](100) NULL,
	[Address] [nvarchar](200) NULL,
	[IdQuan] [int] NOT NULL,
	[NgayTiepNhan] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuThuTien1]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuThuTien1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTenDaiLy] [nvarchar](128) NOT NULL,
	[Address] [nvarchar](100) NULL,
	[Phone] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[NgayThuTien] [date] NOT NULL,
	[SoTienThu] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhieuXuatHang1]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatHang1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTenDaiLy] [nvarchar](128) NOT NULL,
	[NgayLapPhieu] [date] NOT NULL,
	[MatHang] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](20) NOT NULL,
	[SoLuong] [int] NOT NULL,
	[DonGia] [float] NOT NULL,
	[ThanhTien] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Quan]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenQuan] [nvarchar](100) NULL,
	[SoDaiLi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[QuyDinh1]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LoaiDaiLy] [nvarchar](100) NULL,
	[SoLuong] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRolee1]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRolee1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Userss1]    Script Date: 30/06/2019 4:33:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Userss1](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](max) NULL,
	[UserName] [nvarchar](100) NULL,
	[Password] [nvarchar](max) NULL,
	[IdRole] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[HoSoDaiLi1] ([Id], [TenDaiLy], [IdLoaiDaiLy], [Phone], [Address], [IdQuan], [NgayTiepNhan]) VALUES (N'2cd4d124-5d43-44cf-a4c2-886f339d8f8a', N'Đại lý 1', 1, N'0977777777', N'Địa chỉ 1', 1, CAST(0x603E0B00 AS Date))
INSERT [dbo].[HoSoDaiLi1] ([Id], [TenDaiLy], [IdLoaiDaiLy], [Phone], [Address], [IdQuan], [NgayTiepNhan]) VALUES (N'945e2121-3481-4c2a-9771-6b52e3e35e5c', N'Đại lý 2', 2, N'0977777777', N'Địa chỉ 2', 2, CAST(0x603E0B00 AS Date))
INSERT [dbo].[HoSoDaiLi1] ([Id], [TenDaiLy], [IdLoaiDaiLy], [Phone], [Address], [IdQuan], [NgayTiepNhan]) VALUES (N'c165392c-2ada-441f-8108-9e3126415cc0', N'Đại lý 3', 3, N'0977777777', N'Địa chỉ 3', 3, CAST(0x603E0B00 AS Date))
SET IDENTITY_INSERT [dbo].[PhieuThuTien1] ON 

INSERT [dbo].[PhieuThuTien1] ([Id], [IdTenDaiLy], [Address], [Phone], [Email], [NgayThuTien], [SoTienThu]) VALUES (37, N'2cd4d124-5d43-44cf-a4c2-886f339d8f8a', N'Địa chỉ 1', N'0977777777', N'123@gmail.com', CAST(0x7E3E0B00 AS Date), 480000)
INSERT [dbo].[PhieuThuTien1] ([Id], [IdTenDaiLy], [Address], [Phone], [Email], [NgayThuTien], [SoTienThu]) VALUES (40, N'945e2121-3481-4c2a-9771-6b52e3e35e5c', N'Địa chỉ 2', N'0977777777', N'123@gmail.com', CAST(0x7E3E0B00 AS Date), 470000)
INSERT [dbo].[PhieuThuTien1] ([Id], [IdTenDaiLy], [Address], [Phone], [Email], [NgayThuTien], [SoTienThu]) VALUES (42, N'c165392c-2ada-441f-8108-9e3126415cc0', N'Địa chỉ 3', N'0977777777', N'123@gmail.com', CAST(0x7E3E0B00 AS Date), 48000)
SET IDENTITY_INSERT [dbo].[PhieuThuTien1] OFF
SET IDENTITY_INSERT [dbo].[PhieuXuatHang1] ON 

INSERT [dbo].[PhieuXuatHang1] ([Id], [IdTenDaiLy], [NgayLapPhieu], [MatHang], [DonViTinh], [SoLuong], [DonGia], [ThanhTien]) VALUES (1, N'2cd4d124-5d43-44cf-a4c2-886f339d8f8a', CAST(0x6A3E0B00 AS Date), N'Giày dép', N'Cái', 5, 100000, 500000)
INSERT [dbo].[PhieuXuatHang1] ([Id], [IdTenDaiLy], [NgayLapPhieu], [MatHang], [DonViTinh], [SoLuong], [DonGia], [ThanhTien]) VALUES (2, N'945e2121-3481-4c2a-9771-6b52e3e35e5c', CAST(0x6A3E0B00 AS Date), N'Áo quần', N'Cái', 5, 100000, 500000)
INSERT [dbo].[PhieuXuatHang1] ([Id], [IdTenDaiLy], [NgayLapPhieu], [MatHang], [DonViTinh], [SoLuong], [DonGia], [ThanhTien]) VALUES (3, N'c165392c-2ada-441f-8108-9e3126415cc0', CAST(0x6A3E0B00 AS Date), N'Sách vở', N'Cái', 5, 10000, 50000)
SET IDENTITY_INSERT [dbo].[PhieuXuatHang1] OFF
SET IDENTITY_INSERT [dbo].[Quan] ON 

INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (1, N'Quận 1', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (2, N'Quận 2', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (3, N'Quận 3', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (4, N'Quận 4', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (5, N'Quận 5', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (7, N'Quận 6', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (9, N'Quận 7', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (10, N'Quận 8', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (11, N'Quận 9', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (12, N'Quận 10', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (13, N'Quận 11', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (14, N'Quận 12', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (15, N'Quận 13', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (16, N'Quận 14', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (17, N'Quận 15', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (18, N'Quận 16', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (19, N'Quận 17', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (20, N'Quận 18', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (21, N'Quận 19', 4)
INSERT [dbo].[Quan] ([id], [TenQuan], [SoDaiLi]) VALUES (22, N'Quận 20', 4)
SET IDENTITY_INSERT [dbo].[Quan] OFF
SET IDENTITY_INSERT [dbo].[QuyDinh1] ON 

INSERT [dbo].[QuyDinh1] ([Id], [LoaiDaiLy], [SoLuong]) VALUES (1, N'1', 20000)
INSERT [dbo].[QuyDinh1] ([Id], [LoaiDaiLy], [SoLuong]) VALUES (2, N'2', 50000)
INSERT [dbo].[QuyDinh1] ([Id], [LoaiDaiLy], [SoLuong]) VALUES (3, N'3', 2000)
SET IDENTITY_INSERT [dbo].[QuyDinh1] OFF
SET IDENTITY_INSERT [dbo].[UserRolee1] ON 

INSERT [dbo].[UserRolee1] ([Id], [DisplayName]) VALUES (1, N'Admin')
INSERT [dbo].[UserRolee1] ([Id], [DisplayName]) VALUES (2, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[UserRolee1] OFF
SET IDENTITY_INSERT [dbo].[Userss1] ON 

INSERT [dbo].[Userss1] ([Id], [DisplayName], [UserName], [Password], [IdRole]) VALUES (1, N'Admin	', N'admin', N'db69fc039dcbd2962cb4d28f5891aae1', 1)
INSERT [dbo].[Userss1] ([Id], [DisplayName], [UserName], [Password], [IdRole]) VALUES (2, N'Nhân viên', N'staff', N'978aae9bb6bee8fb75de3e4830a1be46', 2)
SET IDENTITY_INSERT [dbo].[Userss1] OFF
ALTER TABLE [dbo].[PhieuThuTien1] ADD  DEFAULT ((0)) FOR [SoTienThu]
GO
ALTER TABLE [dbo].[PhieuXuatHang1] ADD  DEFAULT ((0)) FOR [DonGia]
GO
ALTER TABLE [dbo].[HoSoDaiLi1]  WITH CHECK ADD FOREIGN KEY([IdLoaiDaiLy])
REFERENCES [dbo].[QuyDinh1] ([Id])
GO
ALTER TABLE [dbo].[HoSoDaiLi1]  WITH CHECK ADD FOREIGN KEY([IdQuan])
REFERENCES [dbo].[Quan] ([id])
GO
ALTER TABLE [dbo].[PhieuThuTien1]  WITH CHECK ADD FOREIGN KEY([IdTenDaiLy])
REFERENCES [dbo].[HoSoDaiLi1] ([Id])
GO
ALTER TABLE [dbo].[PhieuXuatHang1]  WITH CHECK ADD FOREIGN KEY([IdTenDaiLy])
REFERENCES [dbo].[HoSoDaiLi1] ([Id])
GO
ALTER TABLE [dbo].[Userss1]  WITH CHECK ADD FOREIGN KEY([IdRole])
REFERENCES [dbo].[UserRolee1] ([Id])
GO
USE [master]
GO
ALTER DATABASE [QuanLiDaiLi1] SET  READ_WRITE 
GO
