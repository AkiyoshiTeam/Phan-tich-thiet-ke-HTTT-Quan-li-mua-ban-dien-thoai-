using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonDatHangDAO
    {
        public static DataTable DanhSachPD()
        {
            SqlConnection con = DataProvider.Connection();
            DataTable dt = new DataTable();
            string sql = @"Select D.MaDonDatHang, D.NgayLap, T.TenTrangThai" +
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
            string sql = @"Select SP.MaSanPham, SP.TenSanPham, CT.SoLuong " +
                          "From (DonDatHang D join ChiTietDonDatHang CT on D.MaDonDatHang=CT.MaDonDatHang) join SanPham SP on CT.MaSanPham=SP.MaSanPham " +
                          "Where D.MaDonDatHang =" + "'" + MaPD + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
