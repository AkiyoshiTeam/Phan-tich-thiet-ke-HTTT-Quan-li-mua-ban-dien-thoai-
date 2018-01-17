using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class SanPhamBUS
    {
        public static DataTable DanhSachSPTheoNCC(string maNCC)
        {
            return SanPhamDAO.DanhSachSPTheoNCC(maNCC);
        }

        public static DataTable DanhSachSPTheoMa(string maSP)
        {
            return SanPhamDAO.DanhSachSPTheoMa(maSP);
        }
    }
}
