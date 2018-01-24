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

        public static string GetIDPhieuGiao()
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_GetIDPhieuGiao", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mapg", SqlDbType.NChar);
            cmd.Parameters["@mapg"].Direction = ParameterDirection.Output;
            cmd.Parameters["@mapg"].Size = 10;
            cmd.ExecuteNonQuery();
            string MaPG = cmd.Parameters["@mapg"].Value.ToString();
            con.Close();
            return MaPG;
        }

        public static bool ThemPG(PhieuGiaoHangDTO PG)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemPG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapg", SqlDbType.VarChar);
                cmd.Parameters.Add("@ngaygiao", SqlDbType.Date);
                cmd.Parameters.Add("@madh", SqlDbType.VarChar);
                cmd.Parameters.Add("@mapgncc", SqlDbType.VarChar);

                cmd.Parameters["@mapg"].Value = PG.MaPhieuGiaoHang;
                cmd.Parameters["@ngaygiao"].Value = PG.NgayGiao;
                cmd.Parameters["@madh"].Value = PG.MaDonDatHang;
                cmd.Parameters["@mapgncc"].Value = PG.MaPhieuGiaoHangNhaCC;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ThemCTPG(ChiTietPhieuGiaoHangDTO CT)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemCTPG", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mapg", SqlDbType.VarChar);
                cmd.Parameters.Add("@masp", SqlDbType.VarChar);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);

                cmd.Parameters["@mapg"].Value = CT.MaPhieuGiao;
                cmd.Parameters["@masp"].Value = CT.MaSanPham;
                cmd.Parameters["@soluong"].Value = CT.SoLuong;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateSLTsaunhanhang(string MaSP, int SoLuongNhap)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_UpdateSLTsaunhanhang", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@masp", SqlDbType.NChar);
                cmd.Parameters.Add("@soluongnhap", SqlDbType.Int);
                cmd.Parameters["@masp"].Value = MaSP;
                cmd.Parameters["@soluongnhap"].Value = SoLuongNhap;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet XuatPhieuGiaoHang(string MaPG)
        {
            SqlConnection con = DataProvider.Connection();
            DataSet dtset = new DataSet();
            string sql = @"Select P.MaPhieuGiaoHang,P.NgayGiao,P.MaDonDatHang,S.MaSanPham,S.TenSanPham,C.SoLuong " +
                          "From (PhieuGiaoHang P join ChiTietPhieuGiaoHang C on P.MaPhieuGiaoHang=C.MaPhieuGiao) join SanPham S on C.MaSanPham=S.MaSanPham " +
                          "Where P.MaPhieuGiaoHang ='" + MaPG + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtset, "dtPhieuGiaoHang");
            con.Close();
            return dtset;
        }

        public static DataTable TongSLHangPGH(string MaDDH)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select SUM(C.SoLuong) as 'TongSLHangPGH' " +
                          "From (PhieuGiaoHang P join ChiTietPhieuGiaoHang C on P.MaPhieuGiaoHang=C.MaPhieuGiao) join DonDatHang D on D.MaDonDatHang=P.MaDonDatHang " +
                          "Where D.MaDonDatHang =" + "'" + MaDDH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
