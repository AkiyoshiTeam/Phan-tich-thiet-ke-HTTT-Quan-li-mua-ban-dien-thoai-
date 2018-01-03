using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatHangDTO
    {
        int _soPhieuDat, _maNhaCC, _maTinhTrang;
        long _tongTien;
        DateTime _ngayDatHang, _ngayHenGH;

        public int SoPhieuDat { get => _soPhieuDat; set => _soPhieuDat = value; }
        public int MaNhaCC { get => _maNhaCC; set => _maNhaCC = value; }
        public int MaTinhTrang { get => _maTinhTrang; set => _maTinhTrang = value; }
        public long TongTien { get => _tongTien; set => _tongTien = value; }
        public DateTime NgayDatHang { get => _ngayDatHang; set => _ngayDatHang = value; }
        public DateTime NgayHenGH { get => _ngayHenGH; set => _ngayHenGH = value; }
    }
}
