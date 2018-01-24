using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class PhieuGiaoHangBUS
    {
        public static DataTable DanhSachPG()
        {
            return PhieuGiaoHangDAO.DanhSachPG();
        }

        public static DataTable DanhSachCTPG(string MaPG)
        {
            return PhieuGiaoHangDAO.DanhSachCTPG(MaPG);
        }

        public static bool XoaPG(string MaPG)
        {
            return PhieuGiaoHangDAO.XoaPG(MaPG);
        }

        public static string GetIDPhieuGiao()
        {
            return PhieuGiaoHangDAO.GetIDPhieuGiao();
        }

        public static bool ThemPG(PhieuGiaoHangDTO PG)
        {
            return PhieuGiaoHangDAO.ThemPG(PG);
        }
        // Kiểm tra thông tin.
        public static string KiemTra(ChiTietPhieuGiaoHangDTO CT, string TenSP)
        {
            string thongbao = "";
            if (CT.MaSanPham == "")
                thongbao += "-Mã sản phẩm không được để trống.\n";
            if (CT.SoLuong == 0)
                thongbao += "-Số lượng không được để trống.\n";
            if (TenSP == "")
                thongbao += "-Tên sản phẩm không được để trống.\n";
            return thongbao;
        }
        // Kiểm tra thông tin chi tiết phiếu giao.
        public static string KiemTraChiTietPhieuGiao(int count)
        {
            string thongbao = "";
            if (count == 0)
                thongbao += "- Chưa có thêm sản phẩm vào chi tiết phiếu giao hàng.\n";
            return thongbao;
        }
        
        public static bool ThemCTPG(ChiTietPhieuGiaoHangDTO CT)
        {
            return PhieuGiaoHangDAO.ThemCTPG(CT);
        }

        public static bool UpdateSLTsaunhanhang(string MaSP, int SoLuongNhap)
        {
            return PhieuGiaoHangDAO.UpdateSLTsaunhanhang(MaSP, SoLuongNhap);
        }

        public static DataSet XuatPhieuGiaoHang(string MaPG)
        {
            return PhieuGiaoHangDAO.XuatPhieuGiaoHang(MaPG);
        }

        public static DataTable TongSLHangPGH(string MaDDH)
        {
            return PhieuGiaoHangDAO.TongSLHangPGH(MaDDH);
        }
    }
}
