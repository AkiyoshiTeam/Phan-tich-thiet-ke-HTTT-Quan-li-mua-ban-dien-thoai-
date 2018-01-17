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
    public partial class frmXuatDonDatHang : Form
    {
        string MaDDH;
        public frmXuatDonDatHang()
        {
            InitializeComponent();
        }

        public frmXuatDonDatHang(string maddh)
        {
            InitializeComponent();
            MaDDH = maddh;
        }

        private void frmXuatDonDatHang_Load(object sender, EventArgs e)
        {
            DonDatHang report = new DonDatHang();
            report.SetDataSource(DonDatHangBUS.XuatDonDatHang(MaDDH));
            crvDonDatHang.ReportSource = report;
        }
    }
}
