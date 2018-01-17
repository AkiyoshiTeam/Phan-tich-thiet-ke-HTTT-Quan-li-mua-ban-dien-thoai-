using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HoaDonBanHangBUS
    {
        public static DataTable LoadDSHoaDon()
        {
            return HoaDonBanHangDAO.LoadDSHoaDon();
        }

        public static DataTable LoadDSCTHoaDon(string MaHD)
        {
            return HoaDonBanHangDAO.LoadDSCTHoaDon(MaHD);
        }
    }
}
