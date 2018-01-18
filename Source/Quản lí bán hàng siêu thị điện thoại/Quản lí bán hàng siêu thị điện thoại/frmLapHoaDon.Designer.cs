namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmLapHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLapHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pbcheck = new System.Windows.Forms.PictureBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnLapHoaDonMoi = new System.Windows.Forms.Button();
            this.dtkNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnGhiHoaDon = new System.Windows.Forms.Button();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.colMaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcheck)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pbcheck);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.btnLapHoaDonMoi);
            this.groupBox1.Controls.Add(this.dtkNgayLap);
            this.groupBox1.Controls.Add(this.btnGhiHoaDon);
            this.groupBox1.Controls.Add(this.txtSoHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 113);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(354, 71);
            this.txtMaNV.MaxLength = 8;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(137, 26);
            this.txtMaNV.TabIndex = 16;
            this.txtMaNV.TabStop = false;
            this.txtMaNV.Text = "NV00001";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã NV:";
            // 
            // pbcheck
            // 
            this.pbcheck.Enabled = false;
            this.pbcheck.Image = ((System.Drawing.Image)(resources.GetObject("pbcheck.Image")));
            this.pbcheck.Location = new System.Drawing.Point(498, 36);
            this.pbcheck.Name = "pbcheck";
            this.pbcheck.Size = new System.Drawing.Size(16, 16);
            this.pbcheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbcheck.TabIndex = 14;
            this.pbcheck.TabStop = false;
            this.pbcheck.Click += new System.EventHandler(this.pbcheck_Click);
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(354, 30);
            this.txtMaKH.MaxLength = 8;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(137, 26);
            this.txtMaKH.TabIndex = 13;
            this.txtMaKH.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã KH:";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.Location = new System.Drawing.Point(543, 68);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(102, 31);
            this.btnIn.TabIndex = 4;
            this.btnIn.TabStop = false;
            this.btnIn.Text = "Lưu và in";
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnLapHoaDonMoi
            // 
            this.btnLapHoaDonMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLapHoaDonMoi.Image")));
            this.btnLapHoaDonMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLapHoaDonMoi.Location = new System.Drawing.Point(543, 27);
            this.btnLapHoaDonMoi.Name = "btnLapHoaDonMoi";
            this.btnLapHoaDonMoi.Size = new System.Drawing.Size(236, 31);
            this.btnLapHoaDonMoi.TabIndex = 5;
            this.btnLapHoaDonMoi.TabStop = false;
            this.btnLapHoaDonMoi.Text = "Lập hóa đơn mới";
            this.btnLapHoaDonMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLapHoaDonMoi.UseVisualStyleBackColor = true;
            this.btnLapHoaDonMoi.Click += new System.EventHandler(this.btnLapHoaDonMoi_Click);
            // 
            // dtkNgayLap
            // 
            this.dtkNgayLap.Enabled = false;
            this.dtkNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtkNgayLap.Location = new System.Drawing.Point(110, 71);
            this.dtkNgayLap.Name = "dtkNgayLap";
            this.dtkNgayLap.Size = new System.Drawing.Size(147, 26);
            this.dtkNgayLap.TabIndex = 4;
            this.dtkNgayLap.TabStop = false;
            // 
            // btnGhiHoaDon
            // 
            this.btnGhiHoaDon.Enabled = false;
            this.btnGhiHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnGhiHoaDon.Image")));
            this.btnGhiHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhiHoaDon.Location = new System.Drawing.Point(664, 68);
            this.btnGhiHoaDon.Name = "btnGhiHoaDon";
            this.btnGhiHoaDon.Size = new System.Drawing.Size(115, 31);
            this.btnGhiHoaDon.TabIndex = 3;
            this.btnGhiHoaDon.TabStop = false;
            this.btnGhiHoaDon.Text = "Ghi hóa đơn";
            this.btnGhiHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGhiHoaDon.UseVisualStyleBackColor = true;
            this.btnGhiHoaDon.Click += new System.EventHandler(this.btnGhiHoaDon_Click);
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(110, 30);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.ReadOnly = true;
            this.txtSoHD.Size = new System.Drawing.Size(147, 26);
            this.txtSoHD.TabIndex = 3;
            this.txtSoHD.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày lập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "VNĐ";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.Location = new System.Drawing.Point(12, 605);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(107, 31);
            this.btnThoat.TabIndex = 22;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemSP
            // 
            this.btnThemSP.Enabled = false;
            this.btnThemSP.Image = ((System.Drawing.Image)(resources.GetObject("btnThemSP.Image")));
            this.btnThemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemSP.Location = new System.Drawing.Point(633, 46);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(128, 31);
            this.btnThemSP.TabIndex = 6;
            this.btnThemSP.TabStop = false;
            this.btnThemSP.Text = "Thêm sản phẩm";
            this.btnThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(283, 69);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.ReadOnly = true;
            this.txtGiaBan.Size = new System.Drawing.Size(263, 26);
            this.txtGiaBan.TabIndex = 11;
            this.txtGiaBan.TabStop = false;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(76, 30);
            this.txtMaSP.MaxLength = 8;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(118, 26);
            this.txtMaSP.TabIndex = 10;
            this.txtMaSP.TabStop = false;
            this.txtMaSP.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(283, 30);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(312, 26);
            this.txtTenSP.TabIndex = 8;
            this.txtTenSP.TabStop = false;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(76, 69);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(118, 26);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.TabStop = false;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(760, 611);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "VNĐ";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(543, 608);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(211, 26);
            this.txtTongtien.TabIndex = 24;
            this.txtTongtien.TabStop = false;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(211, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Giá bán:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(211, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tên SP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(461, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tổng cộng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnThemSP);
            this.groupBox2.Controls.Add(this.txtGiaBan);
            this.groupBox2.Controls.Add(this.txtMaSP);
            this.groupBox2.Controls.Add(this.txtTenSP);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 112);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin mặt hàng";
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
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSach,
            this.colTenSach,
            this.colSLBan,
            this.colGiaBan,
            this.Column1});
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 25);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(781, 249);
            this.dgvDanhSach.TabIndex = 3;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellEndEdit);
            // 
            // colMaSach
            // 
            this.colMaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colMaSach.HeaderText = "Mã sản phẩm";
            this.colMaSach.Name = "colMaSach";
            this.colMaSach.ReadOnly = true;
            this.colMaSach.Width = 116;
            // 
            // colTenSach
            // 
            this.colTenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenSach.HeaderText = "Tên sản phẩm";
            this.colTenSach.Name = "colTenSach";
            this.colTenSach.ReadOnly = true;
            // 
            // colSLBan
            // 
            this.colSLBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colSLBan.HeaderText = "Số lượng";
            this.colSLBan.Name = "colSLBan";
            this.colSLBan.Width = 89;
            // 
            // colGiaBan
            // 
            this.colGiaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.NullValue = null;
            this.colGiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.Name = "colGiaBan";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Xóa";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.Name = "Column1";
            this.Column1.Width = 41;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSach);
            this.groupBox3.Location = new System.Drawing.Point(12, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(793, 291);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết hóa đơn";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 59);
            this.label1.TabIndex = 18;
            this.label1.Text = "HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 644);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTongtien);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập hóa đơn";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbcheck)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbcheck;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnLapHoaDonMoi;
        private System.Windows.Forms.DateTimePicker dtkNgayLap;
        private System.Windows.Forms.Button btnGhiHoaDon;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
    }
}