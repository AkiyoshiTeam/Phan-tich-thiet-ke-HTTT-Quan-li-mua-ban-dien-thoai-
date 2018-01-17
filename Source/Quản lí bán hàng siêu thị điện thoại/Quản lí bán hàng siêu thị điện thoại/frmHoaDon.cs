using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void tsbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnLapphieu_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon();
            frm.ShowDialog();
            LoadData();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            tsbtnXoa.Enabled = false;
            dgvDanhSach.DataSource = HoaDonBanHangBUS.LoadDSHoaDon();
            Custom1();
            dgvDanhSach.ClearSelection();
        }

        void Custom1()
        {
            if (!dgvDanhSach.AutoGenerateColumns)
            {
                return;
            }
            dgvDanhSach.AutoGenerateColumns = false;
            dgvDanhSach.Columns.Clear();
            dgvDanhSach.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã hóa đơn";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaHoaDonBanHang";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày lập";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "NgayLap";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tổng tiền (VNĐ)";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "Tongtien";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "0,00";
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã khách hàng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "MaKhachHang";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Họ tên khách hàng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenKhachHang";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã nhân viên";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "MaNhanVien";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Họ tên nhân viên";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenNhanVien";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Trạng thái";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenTrangThai";
            dgvCol.ReadOnly = true;
            dgvDanhSach.Columns.Add(dgvCol);
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnXoa.Enabled = true;
            dgvChiTiet.DataSource = HoaDonBanHangBUS.LoadDSCTHoaDon(dgvDanhSach.CurrentRow.Cells[0].Value.ToString());
            Custom2();
            dgvChiTiet.ClearSelection();
        }

        private void dgvDanhSach_KeyUp(object sender, KeyEventArgs e)
        {
            tsbtnXoa.Enabled = true;
            dgvChiTiet.DataSource = HoaDonBanHangBUS.LoadDSCTHoaDon(dgvDanhSach.CurrentRow.Cells[0].Value.ToString());
            Custom2();
            dgvChiTiet.ClearSelection();
        }

        private void dgvDanhSach_KeyDown(object sender, KeyEventArgs e)
        {
            tsbtnXoa.Enabled = true;
            dgvChiTiet.DataSource = HoaDonBanHangBUS.LoadDSCTHoaDon(dgvDanhSach.CurrentRow.Cells[0].Value.ToString());
            Custom2();
            dgvChiTiet.ClearSelection();
        }

        void Custom2()
        {
            if (!dgvChiTiet.AutoGenerateColumns)
            {
                return;
            }
            dgvChiTiet.AutoGenerateColumns = false;
            dgvChiTiet.Columns.Clear();
            dgvChiTiet.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã sản phẩm";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaSanPham";
            dgvCol.ReadOnly = true;
            dgvCol.Width = 90;
            dgvChiTiet.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên sản phẩm";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenSanPham";
            dgvCol.ReadOnly = true;
            dgvChiTiet.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Số lượng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "SoLuong";
            dgvCol.ReadOnly = true;
            dgvChiTiet.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giá bán (VNĐ)";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "GiaBan";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "0,00";
            dgvChiTiet.Columns.Add(dgvCol);
        }

        void LoadData()
        {
            dgvDanhSach.DataSource = HoaDonBanHangBUS.LoadDSHoaDon();
            Custom1();
            dgvDanhSach.ClearSelection();

            if (dgvDanhSach.Rows.Count > 0)
            {
                dgvChiTiet.DataSource = HoaDonBanHangBUS.LoadDSCTHoaDon(dgvDanhSach.CurrentRow.Cells[0].Value.ToString());
                Custom2();
                dgvChiTiet.ClearSelection();
            }
        }
    }
}
