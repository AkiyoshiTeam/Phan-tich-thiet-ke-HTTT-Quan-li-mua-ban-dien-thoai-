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
using DTO;

namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    public partial class frmLapPhieuDat : Form
    {
        int i;
        public frmLapPhieuDat()
        {
            InitializeComponent();
        }

        private void frmLapPhieuDat_Load(object sender, EventArgs e)
        {
            cboNCC.DataSource = NhaCungCapBUS.DanhSachNCC();
            cboNCC.DisplayMember = "TenNhaCungCap";
            cboNCC.ValueMember = "MaNhaCungCap";
            dgvDanhSach.AllowUserToAddRows = false;
            dtkNgayDat.Value = DateTime.Now;
            dgvDanhSach.Rows.Clear();
        }

        private void btnLapPhieuMoi_Click(object sender, EventArgs e)
        {
            i = 0;
            btnGhiPhieu.Enabled = true;
            btnLapPhieuMoi.Enabled = false;
            btnThemSP.Enabled = false;
            txtSoPĐ.Text = DonDatHangBUS.GetIDPhieuDat();
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtSoLuong.ResetText();
            txtLoaiSP.ResetText();
            dtkNgayDat.Value = DateTime.Now;
            dgvDanhSach.Rows.Clear();
        }

        private void btnGhiPhieu_Click(object sender, EventArgs e)
        {
            DonDatHangDTO DDH = new DonDatHangDTO();
            DDH.MaDonDatHang = txtSoPĐ.Text;
            DDH.NgayLap = dtkNgayDat.Value;

            if(DonDatHangBUS.ThemPD(DDH) == true)
            {
                btnLapPhieuMoi.Enabled = true;
                btnThemSP.Enabled = true;
                btnGhiPhieu.Enabled = false;
                cboNCC.Enabled = false;
                btnIn.Enabled = true;

                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                foreach (DataRow row in SanPhamBUS.DanhSachSPTheoNCC(cboNCC.SelectedValue.ToString()).Rows)
                {
                    auto.Add(row["MaSanPham"].ToString());
                }
                txtMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaSP.AutoCompleteCustomSource = auto;
            }
            else
                MessageBox.Show("Thêm phiếu đặt hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (SanPhamBUS.DanhSachSPTheoMa(txtMaSP.Text).Rows.Count > 0)
            {
                foreach (DataRow row in SanPhamBUS.DanhSachSPTheoMa(txtMaSP.Text).Rows)
                {
                    txtTenSP.Text = row["TenSanPham"].ToString();
                    txtLoaiSP.Text = row["TenLoaiSanPham"].ToString();
                }
            }
            else
            {
                txtTenSP.ResetText();
                txtLoaiSP.ResetText();
                txtSoLuong.ResetText();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int j = 0;
            ChiTietDonDatHangDTO CT = new ChiTietDonDatHangDTO();
            CT.MaSanPham = txtMaSP.Text;
            if(txtSoLuong.Text=="")
                CT.SoLuong = 0;
            else
                CT.SoLuong = Int32.Parse(txtSoLuong.Text);
            if (DonDatHangBUS.KiemTra(CT, txtTenSP.Text,txtLoaiSP.Text) != "")
                MessageBox.Show(string.Format("{0}", DonDatHangBUS.KiemTra(CT, txtTenSP.Text, txtLoaiSP.Text)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Đưa giá trị vào DataGridView
                if (dgvDanhSach.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (txtMaSP.Text == dgvDanhSach.Rows[j].Cells[0].Value.ToString())
                        {
                            dgvDanhSach.Rows[j].Cells[2].Value = (Int32.Parse(dgvDanhSach.Rows[j].Cells[2].Value.ToString()) + Int32.Parse(txtSoLuong.Text)).ToString();
                            break;
                        }
                        else if (j == dgvDanhSach.Rows.Count - 1)
                        {
                            dgvDanhSach.Rows.Add();
                            dgvDanhSach.Rows[i].Cells[0].Value = txtMaSP.Text;
                            dgvDanhSach.Rows[i].Cells[1].Value = txtTenSP.Text;
                            dgvDanhSach.Rows[i].Cells[2].Value = txtSoLuong.Text;
                            i++;
                            break;
                        }
                        j++;
                    }
                }
                else
                {
                    dgvDanhSach.Rows.Add();
                    dgvDanhSach.Rows[i].Cells[0].Value = txtMaSP.Text;
                    dgvDanhSach.Rows[i].Cells[1].Value = txtTenSP.Text;
                    dgvDanhSach.Rows[i].Cells[2].Value = txtSoLuong.Text;
                    i++;
                }
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                dgvDanhSach.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < dgvDanhSach.Rows.Count; k++)
            {
                ChiTietDonDatHangDTO PN = new ChiTietDonDatHangDTO();
                PN.MaDonDatHang = txtSoPĐ.Text;
                PN.MaSanPham = dgvDanhSach.Rows[k].Cells[0].Value.ToString();
                PN.SoLuong = int.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString());
                if (DonDatHangBUS.ThemCTPD(PN) == true)
                {
                    btnIn.Enabled = false;
                }
                else
                    MessageBox.Show("Thêm chi tiết phiếu đặt hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Xuất ra cystal report
            frmXuatDonDatHang frm = new frmXuatDonDatHang(txtSoPĐ.Text);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
