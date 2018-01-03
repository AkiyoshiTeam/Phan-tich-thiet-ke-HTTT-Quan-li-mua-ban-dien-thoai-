using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonDatHangDTO
    {
        int _soPhieuDat, _soLuong;
        long _donGia;
        string _maSanPham;

        public int SoPhieuDat { get => _soPhieuDat; set => _soPhieuDat = value; }
        public int SoLuong { get => _soLuong; set => _soLuong = value; }
        public long DonGia { get => DonGia1; set => DonGia1 = value; }
        public long DonGia1 { get => _donGia; set => _donGia = value; }
    }
}
