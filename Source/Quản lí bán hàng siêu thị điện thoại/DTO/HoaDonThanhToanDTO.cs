using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonThanhToanDTO
    {
        string _maHoaDonThanhToan, _maDonHang;
        int _tongTien;

        public string MaHoaDonThanhToan { get => _maHoaDonThanhToan; set => _maHoaDonThanhToan = value; }
        public string MaDonHang { get => _maDonHang; set => _maDonHang = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
    }
}
