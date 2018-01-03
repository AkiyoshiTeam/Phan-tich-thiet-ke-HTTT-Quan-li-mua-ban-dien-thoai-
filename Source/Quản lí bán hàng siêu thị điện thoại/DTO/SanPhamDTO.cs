using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        string _maSP, _tenSP, _kichThuoc, _heDieuHanh, _thongTinKhac;
        long _donGia;
        int _maNSX, _maQG, _tGBaoHanh, _trongLuong, _soLuong, _maLoai;

        public string MaSP { get => _maSP; set => _maSP = value; }
        public string TenSP { get => _tenSP; set => _tenSP = value; }
        public string KichThuoc { get => _kichThuoc; set => _kichThuoc = value; }
        public string HeDieuHanh { get => _heDieuHanh; set => _heDieuHanh = value; }
        public string ThongTinKhac { get => _thongTinKhac; set => _thongTinKhac = value; }
        public long DonGia { get => _donGia; set => _donGia = value; }
        public int MaNSX { get => _maNSX; set => _maNSX = value; }
        public int MaQG { get => _maQG; set => _maQG = value; }
        public int TGBaoHanh { get => _tGBaoHanh; set => _tGBaoHanh = value; }
        public int TrongLuong { get => _trongLuong; set => _trongLuong = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public int MaLoai { get => _maLoai; set => _maLoai = value; }
    }
}
