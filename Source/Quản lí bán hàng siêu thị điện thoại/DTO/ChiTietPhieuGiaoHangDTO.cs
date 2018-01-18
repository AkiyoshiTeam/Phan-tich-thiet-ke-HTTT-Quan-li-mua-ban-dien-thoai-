using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietPhieuGiaoHangDTO
    {
        string _maPhieuGiao, _maSanPham;
        int _soLuong;

        public string MaPhieuGiao { get => _maPhieuGiao; set => _maPhieuGiao = value; }
        public string MaSanPham { get => _maSanPham; set => _maSanPham = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
    }
}
