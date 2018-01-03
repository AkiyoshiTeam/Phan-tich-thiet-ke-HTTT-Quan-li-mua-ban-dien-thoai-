using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinhTrangPhieuDatDTO
    {
        int _maTinhTrang;
        string _tenTinhTrang;

        public string TenTinhTrang { get => _tenTinhTrang; set => _tenTinhTrang = value; }
        public int MaTinhTrang { get => _maTinhTrang; set => _maTinhTrang = value; }
    }
}
