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
    public class HoaDonBanHangDAO
    {
        public static DataTable LoadDSHoaDon()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"select H.MaHoaDonBanHang,H.NgayLap,H.TongTien,K.MaKhachHang,K.TenKhachHang,N.MaNhanVien,N.TenNhanVien,T.TenTrangThai " +
                          "from ((HoaDonBanHang H join TrangThaiHoaDonBanHang T on H.TrangThai=T.MaTrangThaiHoaDonBanHang) join NhanVien N on H.MaNhanVien=N.MaNhanVien) join KhachHang K on H.MaKhachHang=K.MaKhachHang " +
                          "where T.TenTrangThai=N'Chưa thanh toán' or T.TenTrangThai=N'Đã thanh toán'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static DataTable LoadDSCTHoaDon(string MaHD)
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"select S.MaSanPham,S.TenSanPham,C.SoLuong,S.GiaBan " +
                          "from (HoaDonBanHang H join ChiTietHoaDonBanHang C on H.MaHoaDonBanHang=C.MaHoaDonBanHang) join SanPham S on C.MaSanPham=S.MaSanPham " +
                          "where H.MaHoaDonBanHang ='" + MaHD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }

        public static string GetIDHoaDon()
        {
            SqlConnection con = DataProvider.Connection();
            SqlCommand cmd = new SqlCommand("sp_GetIDHoaDon", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@mahd", SqlDbType.NChar);
            cmd.Parameters["@mahd"].Direction = ParameterDirection.Output;
            cmd.Parameters["@mahd"].Size = 10;
            cmd.ExecuteNonQuery();
            string MaSach = cmd.Parameters["@mahd"].Value.ToString();
            con.Close();
            return MaSach;
        }

        public static bool ThemHD(HoaDonBanHangDTO HD)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemHD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahd", SqlDbType.VarChar);
                cmd.Parameters.Add("@ngaylap", SqlDbType.Date);
                cmd.Parameters.Add("@makh", SqlDbType.VarChar);
                cmd.Parameters.Add("@manv", SqlDbType.VarChar);
                cmd.Parameters.Add("@tongtien", SqlDbType.Int);

                cmd.Parameters["@mahd"].Value = HD.MaHoaDonBanHang;
                cmd.Parameters["@ngaylap"].Value = HD.NgayLap;
                cmd.Parameters["@makh"].Value = HD.MaKhachHang;
                cmd.Parameters["@manv"].Value = HD.MaNhanVien;
                cmd.Parameters["@tongtien"].Value = HD.TongTien;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool XoaHD(string MaHD)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_XoaHD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahd", SqlDbType.NChar);
                cmd.Parameters["@mahd"].Value = MaHD;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ThemCTHD(ChiTietHoaDonBanHangDTO CTHD)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_ThemCTHD", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@mahd", SqlDbType.VarChar);
                cmd.Parameters.Add("@masp", SqlDbType.VarChar);
                cmd.Parameters.Add("@soluong", SqlDbType.Int);
                cmd.Parameters["@mahd"].Value = CTHD.MaHoaDonBanHang;
                cmd.Parameters["@masp"].Value = CTHD.MaSanPham;
                cmd.Parameters["@soluong"].Value = CTHD.SoLuong;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool UpdateSLT(string MaSP, int SoLuongBan)
        {
            try
            {
                SqlConnection con = DataProvider.Connection();
                SqlCommand cmd = new SqlCommand("sp_UpdateSLT", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@masp", SqlDbType.NChar);
                cmd.Parameters.Add("@soluongban", SqlDbType.Int);
                cmd.Parameters["@masp"].Value = MaSP;
                cmd.Parameters["@soluongban"].Value = SoLuongBan;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static DataSet XuatHoaDonBanHang(string MaHD)
        {
            SqlConnection con = DataProvider.Connection();
            DataSet dtset = new DataSet();
            string sql = @"Select H.MaHoaDonBanHang, H.NgayLap, H.TongTien, K.TenKhachHang, N.TenNhanVien, S.MaSanPham, S.TenSanPham, C.SoLuong, S.GiaBan " +
                          "From (((HoaDonBanHang H join ChiTietHoaDonBanHang C on H.MaHoaDonBanHang=C.MaHoaDonBanHang)join SanPham S on S.MaSanPham=C.MaSanPham) join NhanVien N on H.MaNhanVien=N.MaNhanVien) join KhachHang K on H.MaKhachHang=K.MaKhachHang " +
                          "Where H.MaHoaDonBanHang ='" + MaHD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dtset, "dtHoaDonBanHang");
            con.Close();
            return dtset;
        }
    }
}
