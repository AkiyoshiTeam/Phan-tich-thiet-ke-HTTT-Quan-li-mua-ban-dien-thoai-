using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonBanHangDTO
    {
        string _maHoaDonBanHang, _maKhachHang, _maNhanVien;
        DateTime _ngayLap;
        int _tongTien, _trangThai;

        public string MaHoaDonBanHang { get => _maHoaDonBanHang; set => _maHoaDonBanHang = value; }
        public string MaKhachHang { get => _maKhachHang; set => _maKhachHang = value; }
        public string MaNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
        public DateTime NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
        public int TrangThai { get => _trangThai; set => _trangThai = value; }
    }
}
