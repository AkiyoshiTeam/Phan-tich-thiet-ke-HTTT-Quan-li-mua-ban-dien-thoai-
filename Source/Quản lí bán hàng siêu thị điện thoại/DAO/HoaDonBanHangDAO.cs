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
    }
}
