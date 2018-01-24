using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DonDatHangDAO
    {
        public static DataTable DanhSachTTPD()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select * From TrangThaiDonDatHang where MaTrangThaiDonDatHang between 1 and 3";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DanhSachPD()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select D.MaDonDatHang, D.NgayLap,D.TongTien, T.TenTrangThai" +
                           " From DonDatHang D join TrangThaiDonDatHang T on D.MaTrangTrangThai = T.MaTrangThaiDonDatHang" +
                           " Where T.TenTrangThai= N'Chưa xác nhận' or T.TenTrangThai= N'Đã xác nhận'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DanhSachCTPD(string MaPD)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select SP.MaSanPham, SP.TenSanPham, SP.GiaMua, CT.SoLuong " +
                          "From (DonDatHang D join ChiTietDonDatHang CT on D.MaDonDatHang=CT.MaDonDatHang) join SanPham SP on CT.MaSanPham=SP.MaSanPham " +
                          "Where D.MaDonDatHang =" + "'" + MaPD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static string GetIDPhieuDat()
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_GetIDPhieuDat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maddh", SqlDbType.NChar);
            cmd.Parameters["@maddh"].Direction = ParameterDirection.Output;
            cmd.Parameters["@maddh"].Size = 10;
            cmd.ExecuteNonQuery();
            string MaDDH = cmd.Parameters["@maddh"].Value.ToString();
            con.Close();
            return MaDDH;
        }

        public static bool ThemPD(DonDatHangDTO DDH)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemPD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maddh", SqlDbType.VarChar);
                cmd.Parameters.Add("@ngaydat", SqlDbType.Date);
              
                cmd.Parameters["@maddh"].Value = DDH.MaDonDatHang;
                cmd.Parameters["@ngaydat"].Value = DDH.NgayLap;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool ThemCTPD(ChiTietDonDatHangDTO PD)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemCTPhieuDat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maddh", SqlDbType.VarChar);
                cmd.Parameters.Add("@masp", SqlDbType.VarChar);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);

                cmd.Parameters["@maddh"].Value = PD.MaDonDatHang;
                cmd.Parameters["@masp"].Value = PD.MaSanPham;
                cmd.Parameters["@soluong"].Value = PD.SoLuong;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet XuatDonDatHang(string MaDDH)
        {
            SqlConnection con = DataProvider.Connection();
            DataSet dtset = new DataSet();
            string sql = @"Select D.MaDonDatHang,D.NgayLap,S.MaSanPham,S.TenSanPham,C.SoLuong,S.GiaMua,D.TongTien " +
                          "From (DonDatHang D join ChiTietDonDatHang C on D.MaDonDatHang=C.MaDonDatHang) join SanPham S on C.MaSanPham=S.MaSanPham " +
                          "Where D.MaDonDatHang ='" + MaDDH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtset, "dtDonDatHang");
            con.Close();
            return dtset;
        }

        public static bool XoaPD(string MaDDH)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaPD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maddh", SqlDbType.NChar);
                cmd.Parameters["@maddh"].Value = MaDDH;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateTT(string MaDDH, int TongTien)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                string sql = @"Update DonDatHang set TongTien='" + TongTien.ToString() + "' Where MaDonDatHang='" + MaDDH + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable DanhSachDDHTheoMaPG(string MaPG)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select D.MaDonDatHang,D.NgayLap,D.TongTien, D.MaTrangTrangThai " +
                          "From (DonDatHang D join PhieuGiaoHang P on D.MaDonDatHang=P.MaDonDatHang) join TrangThaiDonDatHang T on D.MaTrangTrangThai=T.MaTrangThaiDonDatHang " +
                          "Where P.MaPhieuGiaoHang =" + "'" + MaPG + "' and (T.TenTrangThai=N'Chưa nhận hàng đủ' or T.TenTrangThai=N'Đã thanh toán' or T.TenTrangThai= N'Đã xác nhận')";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable DanhSachPDCoTrangThaiDaXacNhanVaChuaNhanHangDu()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select D.MaDonDatHang" +
                           " From DonDatHang D join TrangThaiDonDatHang T on D.MaTrangTrangThai = T.MaTrangThaiDonDatHang" +
                           " Where T.TenTrangThai= N'Chưa nhận hàng đủ' or T.TenTrangThai= N'Đã xác nhận'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static bool UpdateTrangThai(string MaDDH, int MaTT)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                string sql = @"Update DonDatHang set MaTrangTrangThai='" + MaTT.ToString() + "' Where MaDonDatHang='" + MaDDH + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataTable TongSLHangDDH(string MaDDH)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select SUM(C.SoLuong) as 'TongSLHangDDH' " +
                          "From DonDatHang D join ChiTietDonDatHang C on D.MaDonDatHang=C.MaDonDatHang " +
                          "Where D.MaDonDatHang =" + "'" + MaDDH + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
