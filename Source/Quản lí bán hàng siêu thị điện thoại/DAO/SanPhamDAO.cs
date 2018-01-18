using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SanPhamDAO
    {
        public static DataTable DanhSachSPTheoNCC(string maNCC)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select MaSanPham From SanPham Where MaNhaCungCap='" + maNCC + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DanhSachSPTheoMa(string maSP)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select * From SanPham Where MaSanPham='" + maSP + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DanhSachSPTheoDDH(string maDH)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select S.MaSanPham From (DonDatHang D join ChiTietDonDatHang C on D.MaDonDatHang=C.MaDonDatHang) join SanPham S on C.MaSanPham=S.MaSanPham Where D.MaDonDatHang='" + maDH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
