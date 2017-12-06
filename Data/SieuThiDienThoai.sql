CREATE DATABASE [SieuThiDienThoai]
GO
USE [SieuThiDienThoai]
GO
/****** Object:  Table [dbo].[ChiTietDonBaoHanh]    Script Date: 06/12/2017 11:29:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonBaoHanh](
	[SoDonBH] [int] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[MaLoaiBH] [int] NULL,
	[MoTaTinhTrangSP] [nvarchar](1000) NULL,
 CONSTRAINT [PK_ChiTietDonBaoHanh] PRIMARY KEY CLUSTERED 
(
	[SoDonBH] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 06/12/2017 11:29:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[SoHD] [int] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[ThanhTien] [bigint] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuDat]    Script Date: 06/12/2017 11:29:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuDat](
	[SoPhieuDat] [int] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [bigint] NULL,
 CONSTRAINT [PK_ChiTietPhieuDat] PRIMARY KEY CLUSTERED 
(
	[SoPhieuDat] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhapKho]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapKho](
	[SoPN] [int] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[SoPN] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Coupon]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Coupon](
	[MaCoupon] [varchar](10) NOT NULL,
	[TenCoupon] [nvarchar](50) NULL,
	[Loai] [nvarchar](50) NULL,
	[NgayBatDau] [date] NULL,
	[NgayHetHan] [date] NULL,
 CONSTRAINT [PK_Coupon] PRIMARY KEY CLUSTERED 
(
	[MaCoupon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonBaoHanh]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonBaoHanh](
	[SoDonBH] [int] IDENTITY(1,1) NOT NULL,
	[MaNhaCC] [int] NULL,
	[NgayLapDon] [date] NULL,
 CONSTRAINT [PK_DonBaoHanh] PRIMARY KEY CLUSTERED 
(
	[SoDonBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaNSX] [int] IDENTITY(1,1) NOT NULL,
	[TenNSX] [nvarchar](50) NULL,
 CONSTRAINT [PK_HangSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HinhThuc]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThuc](
	[MaHinhThuc] [int] IDENTITY(1,1) NOT NULL,
	[TenHinhThuc] [nvarchar](50) NULL,
 CONSTRAINT [PK_HinhThuc] PRIMARY KEY CLUSTERED 
(
	[MaHinhThuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[SoHD] [int] IDENTITY(1,1) NOT NULL,
	[MaKH] [int] NULL,
	[NgayLap] [date] NULL,
	[NgayGiaoHang] [date] NULL,
	[TongTien] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[SoHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [int] NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[MaLoaiKH] [int] NULL,
	[TenCongTy/DaiLy] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[TenNguoiDaiDien] [nvarchar](50) NULL,
	[DienThoai] [varchar](11) NULL,
	[MaHinhThuc] [int] NULL,
	[DiemTichLuy] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBaoHanh]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBaoHanh](
	[MaLoaiBH] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiBH] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiBaoHanh] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiKhachHang]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiKhachHang](
	[MaLoaiKH] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaLoaiKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoai] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSP] [nvarchar](50) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCung Cap]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCung Cap](
	[MaNhaCC] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [varchar](100) NULL,
	[Fax] [varchar](10) NULL,
	[SoTaiKhoan] [int] NULL,
 CONSTRAINT [PK_NhaCung Cap] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap-SanPham]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap-SanPham](
	[MaNhaCC] [int] NOT NULL,
	[MaSP] [varchar](10) NOT NULL,
 CONSTRAINT [PK_NhaCungCap-SanPham] PRIMARY KEY CLUSTERED 
(
	[MaNhaCC] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatHang]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatHang](
	[SoPhieuDat] [int] IDENTITY(1,1) NOT NULL,
	[MaNhaCC] [int] NULL,
	[NgayDatHang] [date] NULL,
	[NgayHenGH] [date] NULL,
	[TongTien] [bigint] NULL,
	[MaTinhTrang] [int] NULL,
 CONSTRAINT [PK_PhieuDatHang] PRIMARY KEY CLUSTERED 
(
	[SoPhieuDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapKho]    Script Date: 06/12/2017 11:29:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapKho](
	[SoPN] [int] IDENTITY(1,1) NOT NULL,
	[NgayNhapHang] [date] NULL,
	[MaNhaCC] [int] NULL,
 CONSTRAINT [PK_PhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[SoPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuocGia]    Script Date: 06/12/2017 11:29:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuocGia](
	[MaQG] [int] IDENTITY(1,1) NOT NULL,
	[TenQG] [nvarchar](50) NULL,
 CONSTRAINT [PK_QuocGia] PRIMARY KEY CLUSTERED 
(
	[MaQG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 06/12/2017 11:29:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [varchar](10) NOT NULL,
	[TenSP] [nvarchar](50) NULL,
	[DonGia] [bigint] NULL,
	[MaNSX] [int] NULL,
	[MaQG] [int] NULL,
	[TGBaoHanh] [int] NULL,
	[KichThuoc] [varchar](50) NULL,
	[TrongLuong] [int] NULL,
	[HeDieuHanh] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
	[ThongTinKhac] [nvarchar](1000) NULL,
	[MaLoai] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhTrangPhieuDat]    Script Date: 06/12/2017 11:29:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrangPhieuDat](
	[MaTinhTrang] [int] IDENTITY(1,1) NOT NULL,
	[TenTinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TinhTrangPhieuDat] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonBaoHanh_DonBaoHanh] FOREIGN KEY([SoDonBH])
REFERENCES [dbo].[DonBaoHanh] ([SoDonBH])
GO
ALTER TABLE [dbo].[ChiTietDonBaoHanh] CHECK CONSTRAINT [FK_ChiTietDonBaoHanh_DonBaoHanh]
GO
ALTER TABLE [dbo].[ChiTietDonBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonBaoHanh_LoaiBaoHanh] FOREIGN KEY([MaLoaiBH])
REFERENCES [dbo].[LoaiBaoHanh] ([MaLoaiBH])
GO
ALTER TABLE [dbo].[ChiTietDonBaoHanh] CHECK CONSTRAINT [FK_ChiTietDonBaoHanh_LoaiBaoHanh]
GO
ALTER TABLE [dbo].[ChiTietDonBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietDonBaoHanh_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietDonBaoHanh] CHECK CONSTRAINT [FK_ChiTietDonBaoHanh_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([SoHD])
REFERENCES [dbo].[HoaDon] ([SoHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDat_PhieuDatHang] FOREIGN KEY([SoPhieuDat])
REFERENCES [dbo].[PhieuDatHang] ([SoPhieuDat])
GO
ALTER TABLE [dbo].[ChiTietPhieuDat] CHECK CONSTRAINT [FK_ChiTietPhieuDat_PhieuDatHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuDat]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuDat_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuDat] CHECK CONSTRAINT [FK_ChiTietPhieuDat_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapKho_PhieuNhapKho] FOREIGN KEY([SoPN])
REFERENCES [dbo].[PhieuNhapKho] ([SoPN])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuNhapKho_PhieuNhapKho]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapKho_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuNhapKho_SanPham]
GO
ALTER TABLE [dbo].[DonBaoHanh]  WITH CHECK ADD  CONSTRAINT [FK_DonBaoHanh_NhaCung Cap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhaCung Cap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[DonBaoHanh] CHECK CONSTRAINT [FK_DonBaoHanh_NhaCung Cap]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_HinhThuc] FOREIGN KEY([MaHinhThuc])
REFERENCES [dbo].[HinhThuc] ([MaHinhThuc])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_HinhThuc]
GO
ALTER TABLE [dbo].[KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_KhachHang_LoaiKhachHang] FOREIGN KEY([MaLoaiKH])
REFERENCES [dbo].[LoaiKhachHang] ([MaLoaiKH])
GO
ALTER TABLE [dbo].[KhachHang] CHECK CONSTRAINT [FK_KhachHang_LoaiKhachHang]
GO
ALTER TABLE [dbo].[NhaCungCap-SanPham]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap-SanPham_NhaCung Cap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhaCung Cap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[NhaCungCap-SanPham] CHECK CONSTRAINT [FK_NhaCungCap-SanPham_NhaCung Cap]
GO
ALTER TABLE [dbo].[NhaCungCap-SanPham]  WITH CHECK ADD  CONSTRAINT [FK_NhaCungCap-SanPham_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[NhaCungCap-SanPham] CHECK CONSTRAINT [FK_NhaCungCap-SanPham_SanPham]
GO
ALTER TABLE [dbo].[PhieuDatHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatHang_NhaCung Cap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhaCung Cap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[PhieuDatHang] CHECK CONSTRAINT [FK_PhieuDatHang_NhaCung Cap]
GO
ALTER TABLE [dbo].[PhieuDatHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuDatHang_TinhTrangPhieuDat] FOREIGN KEY([MaTinhTrang])
REFERENCES [dbo].[TinhTrangPhieuDat] ([MaTinhTrang])
GO
ALTER TABLE [dbo].[PhieuDatHang] CHECK CONSTRAINT [FK_PhieuDatHang_TinhTrangPhieuDat]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_NhaCung Cap] FOREIGN KEY([MaNhaCC])
REFERENCES [dbo].[NhaCung Cap] ([MaNhaCC])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_NhaCung Cap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HangSanXuat] FOREIGN KEY([MaNSX])
REFERENCES [dbo].[HangSanXuat] ([MaNSX])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HangSanXuat]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LoaiSanPham] ([MaLoai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_QuocGia] FOREIGN KEY([MaQG])
REFERENCES [dbo].[QuocGia] ([MaQG])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_QuocGia]
GO
