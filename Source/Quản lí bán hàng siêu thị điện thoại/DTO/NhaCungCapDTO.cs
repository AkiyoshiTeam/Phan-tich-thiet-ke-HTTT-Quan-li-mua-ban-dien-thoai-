using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCapDTO
    {
        int _maNhaCC, _soTaiKhoan;
        string _tenNhaCC, _diaChi, _dienThoai, _fax;

        public string TenNhaCC { get => _tenNhaCC; set => _tenNhaCC = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string DienThoai { get => _dienThoai; set => _dienThoai = value; }
        public string Fax { get => _fax; set => _fax = value; }
        public int MaNhaCC { get => _maNhaCC; set => _maNhaCC = value; }
        public int SoTaiKhoan { get => _soTaiKhoan; set => _soTaiKhoan = value; }
    }
}
