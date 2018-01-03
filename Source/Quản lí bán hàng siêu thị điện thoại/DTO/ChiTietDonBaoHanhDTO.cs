using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDonBaoHanhDTO
    {
        int _soDonBH, _maLoaiBH;
        string _maSP, _moTaTinhTrangSP;

        public string MaSP { get => _maSP; set => _maSP = value; }
        public string MoTaTinhTrangSP { get => _moTaTinhTrangSP; set => _moTaTinhTrangSP = value; }
        public int SoDonBH { get => _soDonBH; set => _soDonBH = value; }
        public int MaLoaiBH { get => _maLoaiBH; set => _maLoaiBH = value; }
    }
}
