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
        int Tien;
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
            Tien = 0;
            txtTongtien.Text = "0";
            btnLapPhieuMoi.Enabled = false;
            btnThemSP.Enabled = true;
            cboNCC.Enabled = false;
            btnIn.Enabled = true;
            txtSoPĐ.Text = DonDatHangBUS.GetIDPhieuDat();
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtSoLuong.ResetText();
            txtGia.ResetText();
            dtkNgayDat.Value = DateTime.Now;
            dgvDanhSach.Rows.Clear();
            // Thêm vào auto complete.
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (DataRow row in SanPhamBUS.DanhSachSPTheoNCC(cboNCC.SelectedValue.ToString()).Rows)
            {
                auto.Add(row["MaSanPham"].ToString());
            }
            txtMaSP.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtMaSP.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtMaSP.AutoCompleteCustomSource = auto;
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (SanPhamBUS.DanhSachSPTheoMa(txtMaSP.Text).Rows.Count > 0)
            {
                foreach (DataRow row in SanPhamBUS.DanhSachSPTheoMa(txtMaSP.Text).Rows)
                {
                    txtTenSP.Text = row["TenSanPham"].ToString();
                    txtGia.Text = row["GiaMua"].ToString();
                }
            }
            else
            {
                txtTenSP.ResetText();
                txtGia.ResetText();
                txtSoLuong.ResetText();
            }
        }

        void TongTien()
        {
            int TongTien = 0;
            for (int k = 0; k < dgvDanhSach.Rows.Count; k++)
            {
                TongTien = TongTien + (DonDatHangBUS.TinhTongTien(Int32.Parse(dgvDanhSach.Rows[k].Cells[3].Value.ToString()), Int32.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString())));
            }
            txtTongtien.Text = String.Format("{0:0,0}", TongTien);
            Tien = TongTien;
            if (Tien <= 40000000)
                btnIn.Enabled = true;
            else if (Tien > 40000000)
                btnIn.Enabled = false;
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int j = 0;
            ChiTietDonDatHangDTO CT = new ChiTietDonDatHangDTO();
            CT.MaSanPham = txtMaSP.Text;
            if (txtSoLuong.Text=="")
                CT.SoLuong = 0;
            else
                CT.SoLuong = Int32.Parse(txtSoLuong.Text);
            if (DonDatHangBUS.KiemTra(CT, txtTenSP.Text,txtGia.Text) != "")
                MessageBox.Show(string.Format("{0}", DonDatHangBUS.KiemTra(CT, txtTenSP.Text, txtGia.Text)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Đưa giá trị vào DataGridView.
                if (dgvDanhSach.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (txtMaSP.Text == dgvDanhSach.Rows[j].Cells[0].Value.ToString())
                        {
                            dgvDanhSach.Rows[j].Cells[3].Value = (Int32.Parse(dgvDanhSach.Rows[j].Cells[3].Value.ToString()) + Int32.Parse(txtSoLuong.Text)).ToString();
                            break;
                        }
                        else if (j == dgvDanhSach.Rows.Count - 1)
                        {
                            dgvDanhSach.Rows.Add();
                            dgvDanhSach.Rows[i].Cells[0].Value = txtMaSP.Text;
                            dgvDanhSach.Rows[i].Cells[1].Value = txtTenSP.Text;
                            dgvDanhSach.Rows[i].Cells[2].Value = txtGia.Text;
                            dgvDanhSach.Rows[i].Cells[3].Value = txtSoLuong.Text;
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
                    dgvDanhSach.Rows[i].Cells[2].Value = txtGia.Text;
                    dgvDanhSach.Rows[i].Cells[3].Value = txtSoLuong.Text;
                    i++;
                }
                // Tính tổng tiền.
                TongTien();
            }
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                dgvDanhSach.Rows.RemoveAt(e.RowIndex);
                i--;
                TongTien();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (DonDatHangBUS.KiemTraChiTietDonDatHang(dgvDanhSach.RowCount) == "")
            {
                // Thêm đơn đặt hàng.
                DonDatHangDTO DDH = new DonDatHangDTO();
                DDH.MaDonDatHang = txtSoPĐ.Text;
                DDH.NgayLap = dtkNgayDat.Value;
                if (DonDatHangBUS.ThemPD(DDH) == true)
                {
                    btnLapPhieuMoi.Enabled = true;
                    btnThemSP.Enabled = false;
                    cboNCC.Enabled = true;
                    // Thêm chi tiết đơn đặt hàng.
                    for (int k = 0; k < dgvDanhSach.Rows.Count; k++)
                    {
                        ChiTietDonDatHangDTO PN = new ChiTietDonDatHangDTO();
                        PN.MaDonDatHang = txtSoPĐ.Text;
                        PN.MaSanPham = dgvDanhSach.Rows[k].Cells[0].Value.ToString();
                        PN.SoLuong = int.Parse(dgvDanhSach.Rows[k].Cells[3].Value.ToString());
                        if (DonDatHangBUS.ThemCTPD(PN) == true)
                        {
                            btnIn.Enabled = false;
                            // Update tổng tiền.
                            if (DonDatHangBUS.UpdateTT(txtSoPĐ.Text, Tien) == false)
                                MessageBox.Show("Cập nhật tổng tiền thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Thêm chi tiết phiếu đặt hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Xuất ra cystal report.
                    frmXuatDonDatHang frm = new frmXuatDonDatHang(txtSoPĐ.Text);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Thêm phiếu đặt hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(string.Format("{0}", DonDatHangBUS.KiemTraChiTietDonDatHang(dgvDanhSach.RowCount)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dgvDanhSach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TongTien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
