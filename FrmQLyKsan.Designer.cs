namespace QLyKsan
{
    partial class FrmQLyKsan
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
            this.lbMaPhong = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGidView_tblPhong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGidView_tblPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaPhong
            // 
            this.lbMaPhong.AutoSize = true;
            this.lbMaPhong.Location = new System.Drawing.Point(34, 56);
            this.lbMaPhong.Name = "lbMaPhong";
            this.lbMaPhong.Size = new System.Drawing.Size(56, 39);
            this.lbMaPhong.TabIndex = 0;
            this.lbMaPhong.Text = "Ma Phong\r\n\r\n\r\n";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(112, 53);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhong.TabIndex = 1;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(112, 92);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(100, 20);
            this.txtTenPhong.TabIndex = 3;
            // 
            // lbTenPhong
            // 
            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(34, 95);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(60, 13);
            this.lbTenPhong.TabIndex = 2;
            this.lbTenPhong.Text = "Ten Phong";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(322, 53);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(100, 20);
            this.txtDonGia.TabIndex = 5;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Location = new System.Drawing.Point(244, 56);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(46, 13);
            this.lbDonGia.TabIndex = 4;
            this.lbDonGia.Text = "Don Gia";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(67, 304);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(45, 21);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(160, 304);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(52, 21);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(258, 304);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(50, 20);
            this.btnluu.TabIndex = 9;
            this.btnluu.Text = "Luu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(352, 304);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(44, 19);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "Don Gia";
            this.DonGia.Name = "DonGia";
            // 
            // TenPhong
            // 
            this.TenPhong.HeaderText = "Ten Phong";
            this.TenPhong.Name = "TenPhong";
            // 
            // MaPhong
            // 
            this.MaPhong.HeaderText = "Ma Phong";
            this.MaPhong.Name = "MaPhong";
            // 
            // DataGidView_tblPhong
            // 
            this.DataGidView_tblPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGidView_tblPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhong,
            this.TenPhong,
            this.DonGia});
            this.DataGidView_tblPhong.Location = new System.Drawing.Point(66, 136);
            this.DataGidView_tblPhong.Name = "DataGidView_tblPhong";
            this.DataGidView_tblPhong.Size = new System.Drawing.Size(356, 149);
            this.DataGidView_tblPhong.TabIndex = 6;
            this.DataGidView_tblPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGritView_tblPhong_CellClick);
            // 
            // FrmQLyKsan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 335);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.DataGidView_tblPhong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.txtTenPhong);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.txtMaPhong);
            this.Controls.Add(this.lbMaPhong);
            this.Name = "FrmQLyKsan";
            this.Text = "FrmQLyKsan";
            this.Load += new System.EventHandler(this.FrmQLyKsan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGidView_tblPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhong;
        private System.Windows.Forms.DataGridView DataGidView_tblPhong;
    }
}