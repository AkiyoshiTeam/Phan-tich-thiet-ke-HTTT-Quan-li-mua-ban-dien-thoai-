using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuGiaoHangDTO
    {
        string _maPhieuGiaoHang, _maDonDatHang, _maPhieuGiaoHangNhaCC;
        DateTime _ngayGiao;

        public string MaPhieuGiaoHang { get => _maPhieuGiaoHang; set => _maPhieuGiaoHang = value; }
        public string MaDonDatHang { get => _maDonDatHang; set => _maDonDatHang = value; }
        public string MaPhieuGiaoHangNhaCC { get => _maPhieuGiaoHangNhaCC; set => _maPhieuGiaoHangNhaCC = value; }
        public DateTime NgayGiao { get => _ngayGiao; set => _ngayGiao = value; }
    }
}
