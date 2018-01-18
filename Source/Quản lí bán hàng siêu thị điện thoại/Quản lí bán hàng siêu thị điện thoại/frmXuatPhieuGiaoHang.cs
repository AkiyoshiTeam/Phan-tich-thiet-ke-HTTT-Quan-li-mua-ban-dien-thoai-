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
    public partial class frmXuatPhieuGiaoHang : Form
    {
        string MaPG;
        public frmXuatPhieuGiaoHang()
        {
            InitializeComponent();
        }

        public frmXuatPhieuGiaoHang(string mapg)
        {
            InitializeComponent();
            MaPG = mapg;
        }

        private void frmXuatPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            PhieuGiaoHang report = new PhieuGiaoHang();
            report.SetDataSource(PhieuGiaoHangBUS.XuatPhieuGiaoHang(MaPG));
            crvPhieuGiaoHang.ReportSource = report;
        }
    }
}
