using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class HoaDonBanHangBUS
    {
        public static DataTable LoadDSHoaDon()
        {
            return HoaDonBanHangDAO.LoadDSHoaDon();
        }

        public static DataTable LoadDSCTHoaDon(string MaHD)
        {
            return HoaDonBanHangDAO.LoadDSCTHoaDon(MaHD);
        }

        public static string GetIDHoaDon()
        {
            return HoaDonBanHangDAO.GetIDHoaDon();
        }

        public static bool ThemHD(HoaDonBanHangDTO HD)
        {
            return HoaDonBanHangDAO.ThemHD(HD);
        }

        public static bool XoaHD(string MaHD)
        {
            return HoaDonBanHangDAO.XoaHD(MaHD);
        }
        // Kiểm tra thông tin.
        public static string KiemTra(ChiTietHoaDonBanHangDTO CT)
        {
            string thongbao = "";
            if (CT.MaSanPham == "")
                thongbao += "-Mã sản phẩm không được để trống.\n";
            if (CT.SoLuong == 0)
                thongbao += "-Số lượng không được để trống.\n";
            return thongbao;
        }
        // Kiểm tra thông tin chi tiết hóa đơn.
        public static string KiemTraChiTietHoaDon(int count)
        {
            string thongbao = "";
            if (count == 0)
                thongbao += "- Chưa có thêm sản phẩm vào chi tiết hóa đơn.\n";
            return thongbao;
        }
        // Tính tổng tiền.
        public static int TinhTongTien(int SoLuong, int Gia)
        {
            int Tong = 0;
            Tong = SoLuong * Gia;
            return Tong;
        }

        public static bool ThemCTHD(ChiTietHoaDonBanHangDTO CTHD)
        {
            return HoaDonBanHangDAO.ThemCTHD(CTHD);
        }

        public static bool UpdateSLT(string MaSP, int SoLuongBan)
        {
            return HoaDonBanHangDAO.UpdateSLT(MaSP, SoLuongBan);
        }

        public static bool KiemTraSLT(string MaSP, int SL)
        {
            DataTable dt  = SanPhamBUS.DanhSachSPTheoMa(MaSP);
            int soluongton = 0, hieu;
            foreach(DataRow row in dt.Rows)
            {
                soluongton = (int)row["SoLuongTon"];
            }
            hieu = soluongton - SL;
            if (hieu < 0)
                return false;
            else
                return true;
        }

        public static DataSet XuatHoaDonBanHang(string MaHD)
        {
            return HoaDonBanHangDAO.XuatHoaDonBanHang(MaHD);
        }
    }
}
