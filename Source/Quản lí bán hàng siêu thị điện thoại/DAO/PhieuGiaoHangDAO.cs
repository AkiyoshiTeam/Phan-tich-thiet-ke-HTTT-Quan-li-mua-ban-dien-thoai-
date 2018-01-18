using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class PhieuGiaoHangDAO
    {
        public static DataTable DanhSachPG()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select * From PhieuGiaoHang";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DanhSachCTPG(string MaPG)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select S.MaSanPham,S.TenSanPham,C.SoLuong " +
                          "from (PhieuGiaoHang P join ChiTietPhieuGiaoHang C on P.MaPhieuGiaoHang=C.MaPhieuGiao) join SanPham S on C.MaSanPham=S.MaSanPham " +
                          "where P.MaPhieuGiaoHang=" + "'" + MaPG + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static bool XoaPG(string MaPG)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaPG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapg", SqlDbType.NChar);
                cmd.Parameters["@mapg"].Value = MaPG;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
