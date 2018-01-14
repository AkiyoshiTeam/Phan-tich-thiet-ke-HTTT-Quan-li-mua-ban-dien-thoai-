using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonDatHangDTO
    {
        string _maDonDatHang, _maSanPham;
        int _soLuong;

        public string MaDonDatHang { get => _maDonDatHang; set => _maDonDatHang = value; }
        public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
