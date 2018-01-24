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
    public partial class frmPhieuGiaoHang : Form
    {
        public frmPhieuGiaoHang()
        {
            InitializeComponent();
        }

        private void tsbtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            tsbtnXoa.Enabled = false;
            dgvDanhSachPG.DataSource = PhieuGiaoHangBUS.DanhSachPG();
            Custom1();
            dgvDanhSachPG.ClearSelection();
        }

        void Custom1()
        {
            if (!dgvDanhSachPG.AutoGenerateColumns)
            {
                return;
            }
            dgvDanhSachPG.AutoGenerateColumns = false;
            dgvDanhSachPG.Columns.Clear();
            dgvDanhSachPG.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã phiếu giao hàng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaPhieuGiaoHang";
            dgvCol.ReadOnly = true;
            dgvDanhSachPG.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày giao";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "NgayGiao";
            dgvCol.ReadOnly = true;
            dgvDanhSachPG.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã đơn đặt hàng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "MaDonDatHang";
            dgvCol.ReadOnly = true;
            dgvDanhSachPG.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã phiếu giao của nhà cung cấp";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "MaPhieuGiaoHangNhaCC";
            dgvCol.ReadOnly = true;
            dgvDanhSachPG.Columns.Add(dgvCol);
        }

        private void dgvDanhSachPG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tsbtnXoa.Enabled = true;
            dgvChiTietPG.DataSource = PhieuGiaoHangBUS.DanhSachCTPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
            Custom2();
            dgvChiTietPG.ClearSelection();
            dgvDanhSachPD.DataSource = DonDatHangBUS.DanhSachDDHTheoMaPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
            Custom3();
            dgvChiTietPD.DataSource = DonDatHangBUS.DanhSachCTPD(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString());
            Custom4();
            dgvChiTietPD.ClearSelection();
        }

        private void dgvDanhSachPG_KeyUp(object sender, KeyEventArgs e)
        {
            tsbtnXoa.Enabled = true;
            dgvChiTietPG.DataSource = PhieuGiaoHangBUS.DanhSachCTPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
            Custom2();
            dgvChiTietPG.ClearSelection();
            dgvDanhSachPD.DataSource = DonDatHangBUS.DanhSachDDHTheoMaPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
            Custom3();
            dgvChiTietPD.DataSource = DonDatHangBUS.DanhSachCTPD(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString());
            Custom4();
            dgvChiTietPD.ClearSelection();
        }

        private void dgvDanhSachPG_KeyDown(object sender, KeyEventArgs e)
        {
            tsbtnXoa.Enabled = true;
            dgvChiTietPG.DataSource = PhieuGiaoHangBUS.DanhSachCTPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
            Custom2();
            dgvChiTietPG.ClearSelection();
            dgvDanhSachPD.DataSource = DonDatHangBUS.DanhSachDDHTheoMaPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
            Custom3();
            dgvChiTietPD.DataSource = DonDatHangBUS.DanhSachCTPD(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString());
            Custom4();
            dgvChiTietPD.ClearSelection();
        }

        void Custom2()
        {
            if (!dgvChiTietPG.AutoGenerateColumns)
            {
                return;
            }
            dgvChiTietPG.AutoGenerateColumns = false;
            dgvChiTietPG.Columns.Clear();
            dgvChiTietPG.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã sản phẩm";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaSanPham";
            dgvCol.ReadOnly = true;
            dgvChiTietPG.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên sản phẩm";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenSanPham";
            dgvCol.ReadOnly = true;
            dgvChiTietPG.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Số lượng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "SoLuong";
            dgvCol.ReadOnly = true;
            dgvChiTietPG.Columns.Add(dgvCol);
        }

        void Custom3()
        {
            if (!dgvDanhSachPD.AutoGenerateColumns)
            {
                return;
            }
            dgvDanhSachPD.AutoGenerateColumns = false;
            dgvDanhSachPD.Columns.Clear();
            dgvDanhSachPD.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã đơn đặt hàng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaDonDatHang";
            dgvCol.ReadOnly = true;
            dgvDanhSachPD.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Ngày lập";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "NgayLap";
            dgvCol.ReadOnly = true;
            dgvDanhSachPD.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tổng tiền";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TongTien";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "0,00";
            dgvDanhSachPD.Columns.Add(dgvCol);

            DataGridViewComboBoxColumn dgvCo = new DataGridViewComboBoxColumn();
            dgvCo.HeaderText = "Trạng thái";
            dgvCo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCo.DataSource = DonDatHangBUS.DanhSachTTPD();
            dgvCo.DisplayMember = "TenTrangThai";
            dgvCo.ValueMember = "MaTrangThaiDonDatHang";
            dgvCo.DataPropertyName = "MaTrangTrangThai";
            dgvCo.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            dgvCo.ReadOnly = true;
            dgvDanhSachPD.Columns.Add(dgvCo);
        }

        void Custom4()
        {
            if (!dgvChiTietPD.AutoGenerateColumns)
            {
                return;
            }
            dgvChiTietPD.AutoGenerateColumns = false;
            dgvChiTietPD.Columns.Clear();
            dgvChiTietPD.AllowUserToAddRows = false;

            DataGridViewTextBoxColumn dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Mã sản phẩm";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "MaSanPham";
            dgvCol.ReadOnly = true;
            dgvChiTietPD.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Tên sản phẩm";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "TenSanPham";
            dgvCol.ReadOnly = true;
            dgvChiTietPD.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Số lượng";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCol.DataPropertyName = "SoLuong";
            dgvCol.ReadOnly = true;
            dgvChiTietPD.Columns.Add(dgvCol);

            dgvCol = new DataGridViewTextBoxColumn();
            dgvCol.HeaderText = "Giá";
            dgvCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCol.DataPropertyName = "GiaMua";
            dgvCol.ReadOnly = true;
            dgvCol.DefaultCellStyle.Format = "0,00";
            dgvChiTietPD.Columns.Add(dgvCol);
        }

        private void tsbtnXoa_Click(object sender, EventArgs e)
        {
            if (PhieuGiaoHangBUS.XoaPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString()) == true)
            {
                LoadData();
            }
            else
                MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        void LoadData()
        {
            // Cập nhật trạng thái đơn dặt hàng.
            if (dgvDanhSachPD.Rows.Count > 0)
            {
                if (DonDatHangBUS.KiemTraSLHang(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString()) == 0)
                {
                    if (DonDatHangBUS.UpdateTrangThai(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString(), 3) == false)
                    {
                        MessageBox.Show("Cập nhật trạng thái thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (DonDatHangBUS.KiemTraSLHang(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString()) == 1)
                {
                    if (DonDatHangBUS.UpdateTrangThai(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString(), 2) == false)
                    {
                        MessageBox.Show("Cập nhật trạng thái thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (DonDatHangBUS.KiemTraSLHang(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString()) == -1)
                {
                    if (DonDatHangBUS.UpdateTrangThai(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString(), 1) == false)
                    {
                        MessageBox.Show("Cập nhật trạng thái thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            // Load data.
            dgvDanhSachPG.DataSource = PhieuGiaoHangBUS.DanhSachPG();
            Custom1();
            dgvDanhSachPG.ClearSelection();
            if (dgvDanhSachPG.Rows.Count > 0)
            {
                dgvChiTietPG.DataSource = PhieuGiaoHangBUS.DanhSachCTPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
                Custom2();
                dgvChiTietPG.ClearSelection();
                dgvDanhSachPD.DataSource = DonDatHangBUS.DanhSachDDHTheoMaPG(dgvDanhSachPG.CurrentRow.Cells[0].Value.ToString());
                Custom3();
                dgvChiTietPD.DataSource = DonDatHangBUS.DanhSachCTPD(dgvDanhSachPD.CurrentRow.Cells[0].Value.ToString());
                Custom4();
                dgvChiTietPD.ClearSelection();
            }
            else
            {
                dgvChiTietPG.DataSource = null;
                dgvDanhSachPD.DataSource = null;
                dgvChiTietPD.DataSource = null;
            }   
        }

        private void tsbtnLapphieu_Click(object sender, EventArgs e)
        {
            frmLapPhieuGiaoHang frm = new frmLapPhieuGiaoHang();
            frm.ShowDialog();
            LoadData();
        }
    }
}
