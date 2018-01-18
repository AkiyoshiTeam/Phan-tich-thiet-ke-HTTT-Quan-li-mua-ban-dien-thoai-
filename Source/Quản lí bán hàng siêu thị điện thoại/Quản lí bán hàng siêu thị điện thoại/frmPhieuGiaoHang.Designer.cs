namespace Quản_lí_bán_hàng_siêu_thị_điện_thoại
{
    partial class frmPhieuGiaoHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuGiaoHang));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnLapphieu = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnThoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPG = new System.Windows.Forms.DataGridView();
            this.dgvChiTietPG = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPD = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietPD = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPG)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPD)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPD)).BeginInit();
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
            this.tsbtnXoa,
            this.toolStripSeparator2,
            this.tsbtnThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 75);
            this.toolStrip1.TabIndex = 6;
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
            this.tsbtnXoa.Click += new System.EventHandler(this.tsbtnXoa_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDanhSachPG);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 302);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu giao hàng";
            // 
            // dgvDanhSachPG
            // 
            this.dgvDanhSachPG.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPG.Location = new System.Drawing.Point(6, 25);
            this.dgvDanhSachPG.MultiSelect = false;
            this.dgvDanhSachPG.Name = "dgvDanhSachPG";
            this.dgvDanhSachPG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPG.Size = new System.Drawing.Size(579, 271);
            this.dgvDanhSachPG.TabIndex = 5;
            this.dgvDanhSachPG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPG_CellClick);
            this.dgvDanhSachPG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDanhSachPG_KeyDown);
            this.dgvDanhSachPG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDanhSachPG_KeyUp);
            // 
            // dgvChiTietPG
            // 
            this.dgvChiTietPG.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietPG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPG.Location = new System.Drawing.Point(6, 25);
            this.dgvChiTietPG.MultiSelect = false;
            this.dgvChiTietPG.Name = "dgvChiTietPG";
            this.dgvChiTietPG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPG.Size = new System.Drawing.Size(726, 271);
            this.dgvChiTietPG.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvChiTietPG);
            this.groupBox2.Location = new System.Drawing.Point(609, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 302);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu giao hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDanhSachPD);
            this.groupBox3.Location = new System.Drawing.Point(12, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 289);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu đặt hàng";
            // 
            // dgvDanhSachPD
            // 
            this.dgvDanhSachPD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachPD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPD.Location = new System.Drawing.Point(6, 25);
            this.dgvDanhSachPD.MultiSelect = false;
            this.dgvDanhSachPD.Name = "dgvDanhSachPD";
            this.dgvDanhSachPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPD.Size = new System.Drawing.Size(579, 258);
            this.dgvDanhSachPD.TabIndex = 5;
            this.dgvDanhSachPD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachPD_CellEndEdit);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvChiTietPD);
            this.groupBox4.Location = new System.Drawing.Point(609, 395);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(738, 289);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chi tiết phiếu đặt hàng";
            // 
            // dgvChiTietPD
            // 
            this.dgvChiTietPD.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietPD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietPD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietPD.Location = new System.Drawing.Point(6, 25);
            this.dgvChiTietPD.MultiSelect = false;
            this.dgvChiTietPD.Name = "dgvChiTietPD";
            this.dgvChiTietPD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietPD.Size = new System.Drawing.Size(726, 258);
            this.dgvChiTietPD.TabIndex = 6;
            // 
            // frmPhieuGiaoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 696);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuGiaoHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu giao hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuGiaoHang_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPG)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietPD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnLapphieu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnXoa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnThoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvDanhSachPG;
        private System.Windows.Forms.DataGridView dgvChiTietPG;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDanhSachPD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvChiTietPD;
    }
}