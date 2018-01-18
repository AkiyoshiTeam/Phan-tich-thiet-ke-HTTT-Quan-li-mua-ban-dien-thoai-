namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmXuatPhieuGiaoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatPhieuGiaoHang));
            this.crvPhieuGiaoHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPhieuGiaoHang
            // 
            this.crvPhieuGiaoHang.ActiveViewIndex = -1;
            this.crvPhieuGiaoHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPhieuGiaoHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPhieuGiaoHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPhieuGiaoHang.Location = new System.Drawing.Point(0, 0);
            this.crvPhieuGiaoHang.Name = "crvPhieuGiaoHang";
            this.crvPhieuGiaoHang.Size = new System.Drawing.Size(879, 426);
            this.crvPhieuGiaoHang.TabIndex = 0;
            // 
            // frmXuatPhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 426);
            this.Controls.Add(this.crvPhieuGiaoHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXuatPhieuGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất phiếu giao hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatPhieuGiaoHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPhieuGiaoHang;
    }
}