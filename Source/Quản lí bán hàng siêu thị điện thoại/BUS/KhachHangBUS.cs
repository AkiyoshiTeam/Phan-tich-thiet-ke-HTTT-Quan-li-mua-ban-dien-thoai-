using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data;

namespace BUS
{
    public class KhachHangBUS
    {
        public static DataTable LoadKhachHangTheoMa(string MaKH)
        {
            return KhachHangDAO.LoadKhachHangTheoMa(MaKH);
        }
        // Kiểm tra khách hàng tồn tại.
        public static bool KiemTraKH(string MaKH)
        {
            DataTable dt = LoadKhachHangTheoMa(MaKH);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        // Kiểm tra cấp độ giảm giá theo điểm khách hàng.
        public static string CapDoGiamGia(string MaKH)
        {
            string capdo = "";
            int diem = 0;
            DataTable dt = KhachHangBUS.LoadKhachHangTheoMa(MaKH);
            foreach(DataRow row in dt.Rows)
            {
                diem = (int)row["Diem"];
            }

            if (150 <= diem && diem < 300)
                capdo = "1";
            else if (300 <= diem && diem < 500)
                capdo = "2";
            else if (500 <= diem && diem < 800)
                capdo = "3";
            else if (800 <= diem && diem < 1000)
                capdo = "4";
            else if (diem >= 1000)
                capdo = "5";
            return capdo;
        }
        // Kiểm tra để cộng điểm theo giá trị hóa đơn.
        public static int Congdiem(int TongTien)
        {
            int diem = 0;
            if (1000000 <= TongTien && TongTien < 2000000)
                diem = 10;
            else if (2000000 <= TongTien && TongTien < 3000000)
                diem = 25;
            else if (3000000 <= TongTien && TongTien < 4000000)
                diem = 40;
            else if (4000000 <= TongTien && TongTien < 5000000)
                diem = 55;
            else if (5000000 <= TongTien && TongTien < 6000000)
                diem = 70;
            else if (TongTien >= 6000000)
                diem = 90;
            return diem;
        }

        public static bool UpdateDiemKH(string MaKH, int Diemsau)
        {
            return KhachHangDAO.UpdateDiemKH(MaKH, Diemsau);
        }
    }
}
