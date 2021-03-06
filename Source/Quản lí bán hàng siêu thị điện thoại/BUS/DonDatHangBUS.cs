﻿using System;
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
        public static DataTable DanhSachTTPD()
        {
            return DonDatHangDAO.DanhSachTTPD();
        }

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
        // Kiểm tra thông tin.
        public static string KiemTra(ChiTietDonDatHangDTO CT, string TenSP, string GiaSP)
        {
            string thongbao = "";
            if (CT.MaSanPham == "")
                thongbao += "-Mã sản phẩm không được để trống.\n";
            if (CT.SoLuong == 0)
                thongbao += "-Số lượng không được để trống.\n";
            if (TenSP =="")
                thongbao += "-Tên sản phẩm không được để trống.\n";
            if(GiaSP=="")
                thongbao += "-Giá sản phẩm không được để trống.\n";
            return thongbao;
        }
        // Kiểm tra thông tin chi tiết đơn đặt hàng.
        public static string KiemTraChiTietDonDatHang(int count)
        {
            string thongbao = "";
            if (count == 0)
                thongbao += "- Chưa có thêm sản phẩm vào chi tiết đơn đặt hàng.\n";
            return thongbao;
        }
        // kiểm tra số lượng hàng giữa đơn đặt hàng và phiếu giao hàng để cập nhật trạng thái.
        public static int KiemTraSLHang(string MaDDH)
        {
            int flag = 0;
            int TongSLHangDDH = 0, TongSLHangPGH = 0; 
            // Lấy tổng số lượng hàng của đơn đặt hàng. 
            foreach (DataRow row in DonDatHangBUS.TongSLHangDDH(MaDDH).Rows)
            {
                TongSLHangDDH = (int)row["TongSLHangDDH"];
            }
            // Lấy tổng số lượng hàng của các phiếu giao hàng
            foreach (DataRow row in PhieuGiaoHangBUS.TongSLHangPGH(MaDDH).Rows)
            {
                try
                {
                    TongSLHangPGH = (int)row["TongSLHangPGH"];
                }
                catch
                {
                    TongSLHangPGH = 0;
                }
            }
            if (TongSLHangDDH == TongSLHangPGH)
                flag = 0;
            else if (TongSLHangDDH > TongSLHangPGH)
                flag = 1;
            else if (TongSLHangPGH == 0)
                flag = -1;
            return flag;
        }
        // Kiểm tra trạng thái đơn dặt hàng hàng.
        public static bool KiemTraTrangTháiDDH(int MaTT)
        {
            bool flag;
            if (MaTT == 3)
                flag = false;
            else
                flag = true;
            return flag;
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
        // Tính tổng tiền.
        public static int TinhTongTien(int SoLuong, int Gia)
        {
            int Tong = 0;
            Tong = SoLuong * Gia;
            return Tong;
        }

        public static DataTable DanhSachDDHTheoMaPG(string MaPG)
        {
            return DonDatHangDAO.DanhSachDDHTheoMaPG(MaPG);
        }

        public static DataTable DanhSachPDCoTrangThaiDaXacNhanVaChuaNhanHangDu()
        {
            return DonDatHangDAO.DanhSachPDCoTrangThaiDaXacNhanVaChuaNhanHangDu();
        }

        public static bool UpdateTrangThai(string MaDDH, int MaTT)
        {
            return DonDatHangDAO.UpdateTrangThai(MaDDH, MaTT);
        }

        public static DataTable TongSLHangDDH(string MaDDH)
        {
            return DonDatHangDAO.TongSLHangDDH(MaDDH);
        }
    }
}
