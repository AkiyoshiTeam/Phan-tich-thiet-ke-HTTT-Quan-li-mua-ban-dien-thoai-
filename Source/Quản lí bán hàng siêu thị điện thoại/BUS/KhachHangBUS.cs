using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        public static DataTable LoadKhachHangTheoMa(string MaKH)
        {
            return KhachHangDAO.LoadKhachHangTheoMa(MaKH);
        }

        public static bool KiemTraKH(string MaKH)
        {
            DataTable dt = LoadKhachHangTheoMa(MaKH);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
