use QLMuaBanHangDienTu
go
-- Get ID đơn đặt hàng --
Select D.MaDonDatHang, D.NgayLap, T.TenTrangThai
From DonDatHang D join TrangThaiDonDatHang T on D.MaTrangTrangThai = T.MaTrangThaiDonDatHang
Where T.TenTrangThai= N'Chưa xác nhận' or T.TenTrangThai= N'Đã xác nhận'