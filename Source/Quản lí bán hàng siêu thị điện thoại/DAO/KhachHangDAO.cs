using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public static DataTable LoadKhachHangTheoMa(string MaKH)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"select * " +
                          "from KhachHang " +
                          "where MaKhachHang ='" + MaKH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
