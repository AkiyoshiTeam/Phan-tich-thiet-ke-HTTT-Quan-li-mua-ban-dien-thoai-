using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHangDTO
    {
        string _maDonDatHang;
        DateTime _ngayLap;
        int _maTrangThai, _tongTien;

        public string MaDonDatHang { get => _maDonDatHang; set => _maDonDatHang = value; }
        public DateTime NgayLap { get => _ngayLap; set => _ngayLap = value; }
        public int MaTrangThai { get => _maTrangThai; set => _maTrangThai = value; }
        public int TongTien { get => _tongTien; set => _tongTien = value; }
    }
}
