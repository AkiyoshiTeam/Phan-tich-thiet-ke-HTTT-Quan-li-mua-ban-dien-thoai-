using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    public partial class frmXuatHoaDonBanHang : Form
    {
        string MaHD;
        public frmXuatHoaDonBanHang()
        {
            InitializeComponent();
        }

        public frmXuatHoaDonBanHang(string mahd)
        {
            InitializeComponent();
            MaHD = mahd;
        }

        private void frmXuatHoaDonBanHang_Load(object sender, EventArgs e)
        {
            HoaDonBanHang report = new HoaDonBanHang();
            report.SetDataSource(HoaDonBanHangBUS.XuatHoaDonBanHang(MaHD));
            crvHoaDon.ReportSource = report;
        }
    }
}
