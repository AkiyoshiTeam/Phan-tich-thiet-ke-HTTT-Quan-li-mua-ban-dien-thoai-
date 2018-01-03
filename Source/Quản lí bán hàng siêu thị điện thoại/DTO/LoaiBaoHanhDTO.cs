using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiBaoHanhDTO
    {
        int _maLoaiBH;
        string _tenLoaiBH;

        public int MaLoaiBH { get => _maLoaiBH; set => _maLoaiBH = value; }
        public string TenLoaiBH { get => _tenLoaiBH; set => _tenLoaiBH = value; }
    }
}
