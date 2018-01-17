using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        string _maNhaCungCap, _tenNhaCungCap;

        public string MaNhaCungCap { get => _maNhaCungCap; set => _maNhaCungCap = value; }
        public string TenNhaCungCap { get => _tenNhaCungCap; set => _tenNhaCungCap = value; }
    }
}
