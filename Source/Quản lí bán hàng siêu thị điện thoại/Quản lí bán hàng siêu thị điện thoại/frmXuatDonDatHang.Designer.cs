namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmXuatDonDatHang
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
            this.crvDonDatHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvDonDatHang
            // 
            this.crvDonDatHang.ActiveViewIndex = -1;
            this.crvDonDatHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDonDatHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvDonDatHang.Location = new System.Drawing.Point(0, 0);
            this.crvDonDatHang.Name = "crvDonDatHang";
            this.crvDonDatHang.Size = new System.Drawing.Size(713, 381);
            this.crvDonDatHang.TabIndex = 0;
            // 
            // frmXuatDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 381);
            this.Controls.Add(this.crvDonDatHang);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXuatDonDatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất đơn đặt hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmXuatDonDatHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDonDatHang;
    }
}