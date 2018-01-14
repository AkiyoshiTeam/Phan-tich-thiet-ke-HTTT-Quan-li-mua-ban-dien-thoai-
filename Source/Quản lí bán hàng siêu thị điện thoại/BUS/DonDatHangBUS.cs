using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class DonDatHangBUS
    {
        public static DataTable DanhSachPD()
        {
            return DonDatHangDAO.DanhSachPD();
        }

        public static DataTable DanhSachCTPD(string MaPD)
        {
            return DonDatHangDAO.DanhSachCTPD(MaPD);
        }
    }
}
