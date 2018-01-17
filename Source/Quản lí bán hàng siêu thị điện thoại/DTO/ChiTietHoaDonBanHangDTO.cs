using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDonBanHangDTO
    {
        string _maSanPham, _maHoaDonBanHang;
        int _soLuong;

        public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
        public string MaHoaDonBanHang { get => _maHoaDonBanHang; set => _maHoaDonBanHang = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
