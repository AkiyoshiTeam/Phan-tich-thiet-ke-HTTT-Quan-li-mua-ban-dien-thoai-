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
    public class DonDatHangBUS
    {
        public static DataTable DanhSachPD()
        {
            return DonDatHangDAO.DanhSachPD();
        }

        public static DataTable DanhSachCTPD(string MaPD)
        {
            return DonDatHangDAO.DanhSachCTPD(MaPD);
        }

        public static string GetIDPhieuDat()
        {
            return DonDatHangDAO.GetIDPhieuDat();
        }

        public static bool ThemPD(DonDatHangDTO DDH)
        {
            return DonDatHangDAO.ThemPD(DDH);
        }

        public static string KiemTra(ChiTietDonDatHangDTO CT, string TenSP, string LoaiSP)
        {
            string thongbao = "";
            if (CT.MaSanPham == "")
                thongbao += "-Mã sản phẩm không được để trống.\n";
            if (CT.SoLuong == 0)
                thongbao += "-Số lượng không được để trống.\n";
            if (TenSP =="")
                thongbao += "-Tên sản phẩm không được để trống.\n";
            if(LoaiSP=="")
                thongbao += "-Loại sản phẩm không được để trống.\n";
            return thongbao;
        }

        public static bool ThemCTPD(ChiTietDonDatHangDTO PD)
        {
            return DonDatHangDAO.ThemCTPD(PD);
        }

        public static DataSet XuatDonDatHang(string MaDDH)
        {
            return DonDatHangDAO.XuatDonDatHang(MaDDH);
        }

        public static bool XoaPD(string MaDDH)
        {
            return DonDatHangDAO.XoaPD(MaDDH);
        }

        public static int TinhTongTien(int SoLuong, int Gia)
        {
            int Tong = 0;
            Tong = SoLuong * Gia;
            return Tong;
        }

        public static bool UpdateTT(string MaDDH, int TongTien)
        {
            return DonDatHangDAO.UpdateTT(MaDDH, TongTien);
        }

        public static DataTable DanhSachDDHTheoMaPG(string MaPG)
        {
            return DonDatHangDAO.DanhSachDDHTheoMaPG(MaPG);
        }
    }
}
