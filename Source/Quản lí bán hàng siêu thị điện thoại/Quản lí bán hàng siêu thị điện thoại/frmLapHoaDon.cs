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
    public partial class frmLapHoaDon : Form
    {
        int i;
        int Tien;
        public frmLapHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            dtkNgayLap.Value = DateTime.Now;
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.Rows.Clear();
        }

        private void btnLapHoaDonMoi_Click(object sender, EventArgs e)
        {
            i = 0;
            Tien = 0;
            txtTongtien.Text = "0";
            btnLapHoaDonMoi.Enabled = false;
            btnThemSP.Enabled = false;
            pbcheck.Enabled = true;
            btnIn.Enabled = true;
            txtMaKH.ReadOnly = false;
            txtSoHD.Text = HoaDonBanHangBUS.GetIDHoaDon();
            txtMaSP.ResetText();
            txtTenSP.ResetText();
            txtGiamGia.ResetText();
            txtGiaBan.ResetText();
            txtMaKH.ResetText();
            dtkNgayLap.Value = DateTime.Now;
            dgvDanhSach.Rows.Clear();
        }

        private void pbcheck_Click(object sender, EventArgs e)
        {
            bool flag = KhachHangBUS.KiemTraKH(txtMaKH.Text);
            if (flag == false)
            {
                btnThemSP.Enabled = false;
                button1.Enabled = true;
                MessageBox.Show("Khách hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                btnThemSP.Enabled = true;
                txtMaKH.ReadOnly = true;
                button1.Enabled = false;
                txtGiamGia.Text = KhachHangBUS.CapDoGiamGia(txtMaKH.Text);
                MessageBox.Show("Khách hàng tồn tại.", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            if (SanPhamBUS.DanhSachSPTheoMa(txtMaSP.Text).Rows.Count > 0)
            {
                foreach (DataRow row in SanPhamBUS.DanhSachSPTheoMa(txtMaSP.Text).Rows)
                {
                    txtTenSP.Text = row["TenSanPham"].ToString();
                    txtGiaBan.Text = row["GiaBan"].ToString();
                }
            }
            else
            {
                txtTenSP.ResetText();
                txtGiaBan.ResetText();
            }
        }

        void TongTien()
        {
            int TongTien = 0;
            for (int k = 0; k < dgvDanhSach.Rows.Count; k++)
            {
                TongTien = TongTien + (HoaDonBanHangBUS.TinhTongTien(Int32.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString()), Int32.Parse(dgvDanhSach.Rows[k].Cells[3].Value.ToString())));
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
            ChiTietHoaDonBanHangDTO CT = new ChiTietHoaDonBanHangDTO();
            CT.MaSanPham = txtMaSP.Text;
            if (txtSoLuong.Text == "")
                CT.SoLuong = 0;
            else
                CT.SoLuong = Int32.Parse(txtSoLuong.Text);
            if (HoaDonBanHangBUS.KiemTra(CT) != "")
                MessageBox.Show(string.Format("{0}", HoaDonBanHangBUS.KiemTra(CT)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (txtTenSP.Text != "")
            {
                // Đưa giá trị vào DataGridView.
                if (dgvDanhSach.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvDanhSach.Rows)
                    {
                        if (txtMaSP.Text == dgvDanhSach.Rows[j].Cells[0].Value.ToString())
                        {
                            dgvDanhSach.Rows[j].Cells[2].Value = (Int32.Parse(dgvDanhSach.Rows[j].Cells[2].Value.ToString()) + 1).ToString();
                            break;
                        }
                        else if (j == dgvDanhSach.Rows.Count - 1)
                        {
                            dgvDanhSach.Rows.Add();
                            dgvDanhSach.Rows[i].Cells[0].Value = txtMaSP.Text;
                            dgvDanhSach.Rows[i].Cells[1].Value = txtTenSP.Text;
                            dgvDanhSach.Rows[i].Cells[2].Value = txtSoLuong.Text;
                            dgvDanhSach.Rows[i].Cells[3].Value = txtGiaBan.Text;
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
                    dgvDanhSach.Rows[i].Cells[3].Value = txtGiaBan.Text;
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

        private void dgvDanhSach_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            TongTien();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int SoDiem = 0;
            if (HoaDonBanHangBUS.KiemTraChiTietHoaDon(dgvDanhSach.RowCount) == "")
            {
                // Thêm hóa đơn mới.
                HoaDonBanHangDTO HD = new HoaDonBanHangDTO();
                HD.MaHoaDonBanHang = txtSoHD.Text;
                HD.NgayLap = dtkNgayLap.Value;
                HD.MaKhachHang = txtMaKH.Text;
                HD.MaNhanVien = txtMaNV.Text;
                if (HoaDonBanHangBUS.ThemHD(HD) == true)
                {
                    btnLapHoaDonMoi.Enabled = true;
                    pbcheck.Enabled = false;
                    // Thêm chi tiết hóa đơn.
                    for (int k = 0; k < dgvDanhSach.Rows.Count; k++)
                    {
                        ChiTietHoaDonBanHangDTO CT = new ChiTietHoaDonBanHangDTO();
                        CT.MaHoaDonBanHang = txtSoHD.Text;
                        CT.MaSanPham = dgvDanhSach.Rows[k].Cells[0].Value.ToString();
                        CT.SoLuong = int.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString());
                        if (HoaDonBanHangBUS.ThemCTHD(CT) == true)
                        {
                            // Update tổng tiền.
                            if (HoaDonBanHangBUS.UpdateTT(txtSoHD.Text, Tien) == false)
                                MessageBox.Show("Cập nhật tổng tiền thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            // Update số lượng tồn.
                            if (HoaDonBanHangBUS.UpdateSLT(dgvDanhSach.Rows[k].Cells[0].Value.ToString(), int.Parse(dgvDanhSach.Rows[k].Cells[2].Value.ToString())) == false)
                                MessageBox.Show("Cập nhật số lượng tồn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MessageBox.Show("Thêm chi tiết hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Cập nhật điểm cho khách hàng.
                    SoDiem = KhachHangBUS.Congdiem(Tien);
                    if (KhachHangBUS.UpdateDiemKH(txtMaKH.Text, SoDiem) == false)
                        MessageBox.Show("Cập nhật điểm thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnIn.Enabled = false;
                    btnThemSP.Enabled = false;
                    // Xuất ra cystal report.
                    frmXuatHoaDonBanHang frm = new frmXuatHoaDonBanHang(txtSoHD.Text);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Thêm hóa đơn thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show(string.Format("{0}", HoaDonBanHangBUS.KiemTraChiTietHoaDon(dgvDanhSach.RowCount)), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            bool Flag;
            int SL;
            if (txtSoLuong.Text == "")
                SL = 0;
            else
                SL = Int32.Parse(txtSoLuong.Text);
            Flag = HoaDonBanHangBUS.KiemTraSLT(txtMaSP.Text, SL);
            if(Flag == false)
                MessageBox.Show("Số lượng hàng không đủ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTiepNhanKH frm = new frmTiepNhanKH();
            frm.ShowDialog();
        }
    }
}
