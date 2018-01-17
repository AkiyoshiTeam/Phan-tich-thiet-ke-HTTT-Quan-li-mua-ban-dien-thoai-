using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class NhaCungCapBUS
    {
        public static DataTable DanhSachNCC()
        {
            return NhaCungCapDAO.DanhSachNCC();
        }
    }
}
