namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmLapPhieuGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuGiaoHang));
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLapPhieuMoi = new System.Windows.Forms.Button();
            this.cboMaDH = new System.Windows.Forms.ComboBox();
            this.dtkNgayGiao = new System.Windows.Forms.DateTimePicker();
            this.btnGhiPhieu = new System.Windows.Forms.Button();
            this.txtSoPG = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaPGNCC = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Số lượng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 117);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Enabled = false;
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.Location = new System.Drawing.Point(634, 46);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(138, 33);
            this.btnThemSP.TabIndex = 6;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSP.UseVisualStyleBackColor = true;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(76, 30);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(136, 26);
            this.txtMaSP.TabIndex = 10;
            this.txtMaSP.TabStop = false;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(315, 50);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(302, 26);
            this.txtTenSP.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(76, 69);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(136, 26);
            this.txtSoLuong.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên SP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã SP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPGNCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnLapPhieuMoi);
            this.groupBox1.Controls.Add(this.cboMaDH);
            this.groupBox1.Controls.Add(this.dtkNgayGiao);
            this.groupBox1.Controls.Add(this.btnGhiPhieu);
            this.groupBox1.Controls.Add(this.txtSoPG);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 113);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu giao hàng";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(566, 68);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(95, 31);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "Lưu và In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuMoi
            // 
            this.btnLapPhieuMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieuMoi.Image")));
            this.btnLapPhieuMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapPhieuMoi.Location = new System.Drawing.Point(566, 27);
            this.btnLapPhieuMoi.Name = "btnLapPhieuMoi";
            this.btnLapPhieuMoi.Size = new System.Drawing.Size(206, 31);
            this.btnLapPhieuMoi.TabIndex = 5;
            this.btnLapPhieuMoi.Text = "Lập phiếu mới";
            this.btnLapPhieuMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapPhieuMoi.UseVisualStyleBackColor = true;
            // 
            // cboMaDH
            // 
            this.cboMaDH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaDH.FormattingEnabled = true;
            this.cboMaDH.Location = new System.Drawing.Point(367, 29);
            this.cboMaDH.Name = "cboMaDH";
            this.cboMaDH.Size = new System.Drawing.Size(175, 27);
            this.cboMaDH.TabIndex = 5;
            // 
            // dtkNgayGiao
            // 
            this.dtkNgayGiao.Enabled = false;
            this.dtkNgayGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkNgayGiao.Location = new System.Drawing.Point(118, 71);
            this.dtkNgayGiao.Name = "dtkNgayGiao";
            this.dtkNgayGiao.Size = new System.Drawing.Size(144, 26);
            this.dtkNgayGiao.TabIndex = 4;
            // 
            // btnGhiPhieu
            // 
            this.btnGhiPhieu.Enabled = false;
            this.btnGhiPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiPhieu.Image")));
            this.btnGhiPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhiPhieu.Location = new System.Drawing.Point(676, 68);
            this.btnGhiPhieu.Name = "btnGhiPhieu";
            this.btnGhiPhieu.Size = new System.Drawing.Size(96, 31);
            this.btnGhiPhieu.TabIndex = 3;
            this.btnGhiPhieu.Text = "Ghi phiếu ";
            this.btnGhiPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhiPhieu.UseVisualStyleBackColor = true;
            // 
            // txtSoPG
            // 
            this.txtSoPG.Location = new System.Drawing.Point(118, 30);
            this.txtSoPG.Name = "txtSoPG";
            this.txtSoPG.ReadOnly = true;
            this.txtSoPG.Size = new System.Drawing.Size(144, 26);
            this.txtSoPG.TabIndex = 3;
            this.txtSoPG.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày giao hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã đơn hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu giao:";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(12, 603);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 31);
            this.btnThoat.TabIndex = 33;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 59);
            this.label1.TabIndex = 29;
            this.label1.Text = "PHIẾU GIAO HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(12, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 287);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu giao hàng";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.colXoa});
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 25);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(762, 247);
            this.dgvDanhSach.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 116;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column5.HeaderText = "Số lượng";
            this.Column5.Name = "Column5";
            this.Column5.Width = 89;
            // 
            // colXoa
            // 
            this.colXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colXoa.HeaderText = "Xóa";
            this.colXoa.Image = ((System.Drawing.Image)(resources.GetObject("colXoa.Image")));
            this.colXoa.Name = "colXoa";
            this.colXoa.Width = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã phiếu giao NCC:";
            // 
            // txtMaPGNCC
            // 
            this.txtMaPGNCC.Location = new System.Drawing.Point(411, 71);
            this.txtMaPGNCC.Name = "txtMaPGNCC";
            this.txtMaPGNCC.Size = new System.Drawing.Size(131, 26);
            this.txtMaPGNCC.TabIndex = 7;
            this.txtMaPGNCC.TabStop = false;
            // 
            // frmLapPhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 640);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu giao hàng";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLapPhieuMoi;
        private System.Windows.Forms.ComboBox cboMaDH;
        private System.Windows.Forms.DateTimePicker dtkNgayGiao;
        private System.Windows.Forms.Button btnGhiPhieu;
        private System.Windows.Forms.TextBox txtSoPG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn colXoa;
        private System.Windows.Forms.TextBox txtMaPGNCC;
        private System.Windows.Forms.Label label6;
    }
}