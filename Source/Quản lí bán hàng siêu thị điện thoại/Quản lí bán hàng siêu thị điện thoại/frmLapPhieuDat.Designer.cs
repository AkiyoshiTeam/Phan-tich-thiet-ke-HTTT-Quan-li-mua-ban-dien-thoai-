namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmLapPhieuDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapPhieuDat));
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLapPhieuMoi = new System.Windows.Forms.Button();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.dtkNgayDat = new System.Windows.Forms.DateTimePicker();
            this.btnGhiPhieu = new System.Windows.Forms.Button();
            this.txtSoPĐ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(76, 30);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(136, 26);
            this.txtMaSP.TabIndex = 10;
            this.txtMaSP.TabStop = false;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(316, 69);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(302, 26);
            this.txtGia.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(12, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 287);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết phiếu đặt";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.colXoa});
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 25);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(762, 246);
            this.dgvDanhSach.TabIndex = 3;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellEndEdit);
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
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giá";
            this.Column3.Name = "Column3";
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
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(316, 30);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(302, 26);
            this.txtTenSP.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(12, 602);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 31);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(76, 69);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(136, 26);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnLapPhieuMoi);
            this.groupBox1.Controls.Add(this.cboNCC);
            this.groupBox1.Controls.Add(this.dtkNgayDat);
            this.groupBox1.Controls.Add(this.btnGhiPhieu);
            this.groupBox1.Controls.Add(this.txtSoPĐ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 113);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(529, 68);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(104, 31);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "Lưu và In";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLapPhieuMoi
            // 
            this.btnLapPhieuMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieuMoi.Image")));
            this.btnLapPhieuMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapPhieuMoi.Location = new System.Drawing.Point(389, 68);
            this.btnLapPhieuMoi.Name = "btnLapPhieuMoi";
            this.btnLapPhieuMoi.Size = new System.Drawing.Size(125, 31);
            this.btnLapPhieuMoi.TabIndex = 5;
            this.btnLapPhieuMoi.Text = "Lập phiếu mới";
            this.btnLapPhieuMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapPhieuMoi.UseVisualStyleBackColor = true;
            this.btnLapPhieuMoi.Click += new System.EventHandler(this.btnLapPhieuMoi_Click);
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(484, 29);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(288, 27);
            this.cboNCC.TabIndex = 5;
            // 
            // dtkNgayDat
            // 
            this.dtkNgayDat.Enabled = false;
            this.dtkNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkNgayDat.Location = new System.Drawing.Point(110, 71);
            this.dtkNgayDat.Name = "dtkNgayDat";
            this.dtkNgayDat.Size = new System.Drawing.Size(234, 26);
            this.dtkNgayDat.TabIndex = 4;
            // 
            // btnGhiPhieu
            // 
            this.btnGhiPhieu.Enabled = false;
            this.btnGhiPhieu.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiPhieu.Image")));
            this.btnGhiPhieu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhiPhieu.Location = new System.Drawing.Point(647, 68);
            this.btnGhiPhieu.Name = "btnGhiPhieu";
            this.btnGhiPhieu.Size = new System.Drawing.Size(125, 31);
            this.btnGhiPhieu.TabIndex = 3;
            this.btnGhiPhieu.Text = "Ghi phiếu ";
            this.btnGhiPhieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhiPhieu.UseVisualStyleBackColor = true;
            this.btnGhiPhieu.Click += new System.EventHandler(this.btnGhiPhieu_Click);
            // 
            // txtSoPĐ
            // 
            this.txtSoPĐ.Location = new System.Drawing.Point(110, 30);
            this.txtSoPĐ.Name = "txtSoPĐ";
            this.txtSoPĐ.ReadOnly = true;
            this.txtSoPĐ.Size = new System.Drawing.Size(234, 26);
            this.txtSoPĐ.TabIndex = 3;
            this.txtSoPĐ.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày đặt hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu đặt:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(810, 59);
            this.label1.TabIndex = 14;
            this.label1.Text = "PHIẾU ĐẶT HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(244, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 33);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.txtGia);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(786, 117);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(758, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 28;
            this.label12.Text = "VNĐ";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(541, 605);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(211, 26);
            this.txtTongtien.TabIndex = 27;
            this.txtTongtien.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(459, 608);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tổng cộng:";
            // 
            // frmLapPhieuDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 640);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu đặt hàng";
            this.Load += new System.EventHandler(this.frmLapPhieuDat_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLapPhieuMoi;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.DateTimePicker dtkNgayDat;
        private System.Windows.Forms.Button btnGhiPhieu;
        private System.Windows.Forms.TextBox txtSoPĐ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn colXoa;
    }
}