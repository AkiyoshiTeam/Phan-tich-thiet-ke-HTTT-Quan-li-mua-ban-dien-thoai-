using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonBaoHanhDTO
    {
        int _soDonBH, _maNhaCC;
        DateTime _ngayLapDon;

        public DateTime NgayLapDon { get => _ngayLapDon; set => _ngayLapDon = value; }
        public int SoDonBH { get => _soDonBH; set => _soDonBH = value; }
        public int MaNhaCC { get => _maNhaCC; set => _maNhaCC = value; }
    }
}
