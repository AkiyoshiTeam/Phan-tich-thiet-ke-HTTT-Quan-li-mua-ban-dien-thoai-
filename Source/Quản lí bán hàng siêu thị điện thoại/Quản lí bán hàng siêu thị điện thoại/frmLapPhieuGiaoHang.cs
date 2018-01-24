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
    public partial class frmLapPhieuGiaoHang : Form
    {
        int i;
        public frmLapPhieuGiaoHang()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLapPhieuGiaoHang_Load(object sender, EventArgs e)
        {
            cboMaDH.DataSource = DonDatHangBUS.DanhSachPDCoTrangThaiDaXacNhanVaChuaNhanHangDu();
            cboMaDH.DisplayMember = "MaDonDatHang";
            cboMaDH.ValueMember = "MaDonDatHang";
            dgvDanhSach.AllowUserToAddRows = false;
            dtkNgayGiao.Value = DateTime.Now;
            dgvDanhSach.Rows.Clear();
            btnLapPhieuMoi.Enabled = false;
            txtMaPGNCC.ReadOnly = false;
        }

        private void btnLapPhieuMoi_Click(object sender, EventArgs e)
        {
            i = 0;
            btnLapPhieuMoi.Enabled = false;
            btnThemSP.Enabled = true;
            btnIn.Enabled = true;
            cboMaDH.Enabled = false;
            txtMaPGNCC.ReadOnly = true;
            txtSoPG.Text = PhieuGiaoHangBUS.GetIDPhieuGiao();
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtSoLuong.ResetText();
            dtkNgayGiao.Value = DateTime.Now;
            dgvDanhSach.Rows.Clear();
            // Thêm vào auto complete.
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            foreach (DataRow row in SanPhamBUS.DanhSachSPTheoDDH(cboMaDH.SelectedValue.ToString()).Rows)
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
                }
            }
            else
            {
                txtTenSP.ResetText();
                txtSoLuong.ResetText();
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int j = 0;
            btnIn.Enabled = true;
            ChiTietPhieuGiaoHangDTO CT = new ChiTietPhieuGiaoHangDTO();
            CT.MaSanPham = txtMaSP.Text;
            if (txtSoLuong.Text == "")
                CT.SoLuong = 0;
            else
                CT.SoLuong = Int32.Parse(txtSoLuong.Text);
            if (PhieuGiaoHangBUS.KiemTra(CT, txtTenSP.Text) != "")
                MessageBox.Show(string.Format("{0}", PhieuGiaoHangBUS.KiemTra(CT, txtTenSP.Text)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                i--;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (PhieuGiaoHangBUS.KiemTraChiTietPhieuGiao(dgvDanhSach.RowCount) == "")
            {
                // Thêm phiếu giao mới.
                PhieuGiaoHangDTO PG = new PhieuGiaoHangDTO();
                PG.MaPhieuGiaoHang = txtSoPG.Text;
                PG.NgayGiao = dtkNgayGiao.Value;
                PG.MaDonDatHang = cboMaDH.SelectedValue.ToString();
                PG.MaPhieuGiaoHangNhaCC = txtMaPGNCC.Text;
                txtMaPGNCC.ReadOnly = false;
                if (PhieuGiaoHangBUS.ThemPG(PG) == true)
                {
                    btnLapPhieuMoi.Enabled = true;
                    cboMaDH.Enabled = true;
                    // Thêm chi tiết phiếu giao.
                    for (int k = 0; k < dgvDanhSach.Rows.Count; k++)
                    {
                        ChiTietPhieuGiaoHangDTO CT = new ChiTietPhieuGiaoHangDTO();
                        CT.MaPhieuGiao = txtSoPG.Text;
                        CT.MaSanPham = dgvDanhSach.Rows[k].Cells[0].Value.ToString();
                        CT.SoLuong = int.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString());
                        if (PhieuGiaoHangBUS.ThemCTPG(CT) == true)
                        {
                            // Update số lượng tồn.
                            if (PhieuGiaoHangBUS.UpdateSLTsaunhanhang(dgvDanhSach.Rows[k].Cells[0].Value.ToString(), int.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString())) == false)
                                MessageBox.Show("Cập nhật số lượng tồn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Thêm chi tiết phiếu giao hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnIn.Enabled = false;
                    btnThemSP.Enabled = false;
                    // Xuất ra cystal report
                    frmXuatPhieuGiaoHang frm = new frmXuatPhieuGiaoHang(txtSoPG.Text);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Thêm phiếu giao hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(string.Format("{0}", PhieuGiaoHangBUS.KiemTraChiTietPhieuGiao(dgvDanhSach.RowCount)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtMaPGNCC_TextChanged(object sender, EventArgs e)
        {
            if (txtMaPGNCC.Text == "")
                btnLapPhieuMoi.Enabled = false;
            else
                btnLapPhieuMoi.Enabled = true;
        }
    }
}
