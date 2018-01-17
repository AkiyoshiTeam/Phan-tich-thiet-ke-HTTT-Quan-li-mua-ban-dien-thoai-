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
   Insert into DonDatHang(MaDonDatHang,NgayLap,MaTrangTrangThai)
   values (@maddh,@ngaydat,0)
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

