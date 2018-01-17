use QLMuaBanHangDienTu
go
-- Get ID đơn đặt hàng --
Create proc sp_GetIDPhieuDat
@maddh nchar(10) output
as
begin
   declare @n numeric
   declare @Z nchar(3),@W nchar(5)
   set @Z='DDH'   
   if exists (Select top 1 * From DonDatHang)
       Select @n= max(cast(Substring(MaDonDatHang,4,5) as numeric)) From DonDatHang
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(5))
   While len(@W)<5
      set @W='0'+@W
   set @maddh = @Z+@W
end
go
-- Thêm phiếu đặt -- 
Create proc sp_ThemPD
@maddh varchar(10),
@ngaydat date
as
begin
   Insert into DonDatHang(MaDonDatHang,NgayLap,MaTrangTrangThai,TongTien)
   values (@maddh,@ngaydat,0,0)
end
go
-- Thêm chi tiết phiếu đặt --
Create proc sp_ThemCTPhieuDat
@maddh varchar(10),
@masp varchar(10),
@soluong int
as
begin
  Insert into ChiTietDonDatHang(MaDonDatHang,MaSanPham,SoLuong)
  Values (@maddh,@masp,@soluong)
end
go
-- Xóa phiếu đặt --
Create proc sp_XoaPD
@maddh varchar(10)
as
begin
   Delete from ChiTietDonDatHang Where MaDonDatHang=@maddh
   Delete from DonDatHang Where MaDonDatHang=@maddh
end
go
-- Get ID hóa đơn bán hàng --
Create proc sp_GetIDHoaDon
@mahd nchar(10) output
as
begin
   declare @n numeric
   declare @Z nchar(2),@W nchar(5)
   set @Z='HD'   
   if exists (Select top 1 * From HoaDonBanHang)
       Select @n= max(cast(Substring(MaHoaDonBanHang,3,5) as numeric)) From HoaDonBanHang
   else
       set @n = 0
   set @n=@n+1
   set @W = cast(@n as nchar(5))
   While len(@W)<5
      set @W='0'+@W
   set @mahd = @Z+@W
end
go
-- Thêm hóa đơn --
Create proc sp_ThemHD
@mahd varchar(10),
@ngaylap date,
@makh varchar(10),
@manv varchar(10)
as
begin
   insert into HoaDonBanHang(MaHoaDonBanHang,NgayLap,TongTien,TrangThai,MaKhachHang,MaNhanVien)
   values(@mahd,@ngaylap,0,0,@makh,@manv)
end
go
-- Xóa hóa đơn --
Create proc sp_XoaHD
@mahd nchar(10)
as
begin
   Delete from ChiTietHoaDonBanHang Where MaHoaDonBanHang=@mahd
   Delete from HoaDonBanHang Where MaHoaDonBanHang=@mahd
end
go
--Thêm Chi tiết hóa đơn --
Create proc sp_ThemCTHD
@mahd varchar(10),
@masp varchar(10),
@soluong int
as
begin
   insert into ChiTietHoaDonBanHang(MaHoaDonBanHang,MaSanPham,SoLuong)
   values(@mahd,@masp,@soluong)
end
go
-- Update số lượng tồn kho --
Create proc sp_UpdateSLT
@masp varchar(10),
@soluongban int
as
begin
   -- lấy số lượng tồn ban đầu - số lượng bán --
   declare @soluongton int
   select @soluongton= SoLuongTon
   from SanPham
   where MaSanPham=@masp
   set @soluongton=@soluongton-@soluongban
   Update SanPham set SoLuongTon=@soluongton where MaSanPham=@masp
end
go
--

