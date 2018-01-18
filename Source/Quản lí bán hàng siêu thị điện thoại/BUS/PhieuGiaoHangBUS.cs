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
    public class PhieuGiaoHangBUS
    {
        public static DataTable DanhSachPG()
        {
            return PhieuGiaoHangDAO.DanhSachPG();
        }

        public static DataTable DanhSachCTPG(string MaPG)
        {
            return PhieuGiaoHangDAO.DanhSachCTPG(MaPG);
        }

        public static bool XoaPG(string MaPG)
        {
            return PhieuGiaoHangDAO.XoaPG(MaPG);
        }
    }
}
