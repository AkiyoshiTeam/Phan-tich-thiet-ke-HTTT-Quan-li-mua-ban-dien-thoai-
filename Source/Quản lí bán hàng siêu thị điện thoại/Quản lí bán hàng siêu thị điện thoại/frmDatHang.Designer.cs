﻿namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmDatHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnLapphieu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLapphieu,
            this.toolStripSeparator1,
            this.tsbtnUpdate,
            this.toolStripSeparator3,
            this.tsbtnXoa,
            this.toolStripSeparator2,
            this.tsbtnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 75);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnLapphieu
            // 
            this.tsbtnLapphieu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLapphieu.Image")));
            this.tsbtnLapphieu.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnLapphieu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnLapphieu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLapphieu.Name = "tsbtnLapphieu";
            this.tsbtnLapphieu.Size = new System.Drawing.Size(73, 72);
            this.tsbtnLapphieu.Text = "Lập phiếu";
            this.tsbtnLapphieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnLapphieu.Click += new System.EventHandler(this.tsbtnLapphieu_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 75);
            // 
            // tsbtnXoa
            // 
            this.tsbtnXoa.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnXoa.Image")));
            this.tsbtnXoa.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnXoa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnXoa.Name = "tsbtnXoa";
            this.tsbtnXoa.Size = new System.Drawing.Size(75, 72);
            this.tsbtnXoa.Text = "Xóa phiếu";
            this.tsbtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 75);
            // 
            // tsbtnThoat
            // 
            this.tsbtnThoat.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnThoat.Image")));
            this.tsbtnThoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbtnThoat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnThoat.Name = "tsbtnThoat";
            this.tsbtnThoat.Size = new System.Drawing.Size(68, 72);
            this.tsbtnThoat.Text = "  Thoát   ";
            this.tsbtnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnThoat.Click += new System.EventHandler(this.tsbtnThoat_Click);
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSach.Location = new System.Drawing.Point(6, 25);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(579, 575);
            this.dgvDanhSach.TabIndex = 5;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDanhSach_KeyDown);
            this.dgvDanhSach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDanhSach_KeyUp);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTiet);
            this.groupBox2.Location = new System.Drawing.Point(609, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 606);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu đặt hàng";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(6, 25);
            this.dgvChiTiet.MultiSelect = false;
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTiet.Size = new System.Drawing.Size(726, 575);
            this.dgvChiTiet.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSach);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 606);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đặt hàng";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 75);
            // 
            // tsbtnUpdate
            // 
            this.tsbtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdate.Image")));
            this.tsbtnUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdate.Name = "tsbtnUpdate";
            this.tsbtnUpdate.Size = new System.Drawing.Size(68, 72);
            this.tsbtnUpdate.Text = "Cập nhật";
            this.tsbtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatHang";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Quản lý phiếu đặt hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnLapphieu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnThoat;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton tsbtnUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}