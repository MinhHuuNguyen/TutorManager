namespace QLTTGS
{
    partial class FormTrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.gb_theme = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_TrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_TimGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_GiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DanhChoGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DangKyLamGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DanhSachLopMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.bt_DangNhap = new System.Windows.Forms.Button();
            this.lb_TaiKhoan = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_theme
            // 
            this.gb_theme.BackColor = System.Drawing.Color.Transparent;
            this.gb_theme.ForeColor = System.Drawing.Color.Yellow;
            this.gb_theme.Location = new System.Drawing.Point(71, 215);
            this.gb_theme.Margin = new System.Windows.Forms.Padding(4);
            this.gb_theme.Name = "gb_theme";
            this.gb_theme.Padding = new System.Windows.Forms.Padding(4);
            this.gb_theme.Size = new System.Drawing.Size(1189, 437);
            this.gb_theme.TabIndex = 6;
            this.gb_theme.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(103, 139);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(839, 58);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_TrangChu,
            this.menuItem_TimGiaSu,
            this.menuItem_DanhChoGiaSu,
            this.menuItem_LienHe,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(4, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(649, 49);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_TrangChu
            // 
            this.menuItem_TrangChu.Name = "menuItem_TrangChu";
            this.menuItem_TrangChu.Size = new System.Drawing.Size(132, 45);
            this.menuItem_TrangChu.Text = "Trang chủ ";
            this.menuItem_TrangChu.Click += new System.EventHandler(this.menuItem_TrangChu_Click);
            // 
            // menuItem_TimGiaSu
            // 
            this.menuItem_TimGiaSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_GiaoVien,
            this.menuItem_SinhVien});
            this.menuItem_TimGiaSu.Name = "menuItem_TimGiaSu";
            this.menuItem_TimGiaSu.Size = new System.Drawing.Size(138, 45);
            this.menuItem_TimGiaSu.Text = "Tìm Gia Sư";
            // 
            // menuItem_GiaoVien
            // 
            this.menuItem_GiaoVien.Name = "menuItem_GiaoVien";
            this.menuItem_GiaoVien.Size = new System.Drawing.Size(191, 40);
            this.menuItem_GiaoVien.Text = "Giáo Viên";
            this.menuItem_GiaoVien.Click += new System.EventHandler(this.menuItem_GiaoVien_Click);
            // 
            // menuItem_SinhVien
            // 
            this.menuItem_SinhVien.Name = "menuItem_SinhVien";
            this.menuItem_SinhVien.Size = new System.Drawing.Size(191, 40);
            this.menuItem_SinhVien.Text = "Sinh Viên";
            this.menuItem_SinhVien.Click += new System.EventHandler(this.menuItem_SinhVien_Click);
            // 
            // menuItem_DanhChoGiaSu
            // 
            this.menuItem_DanhChoGiaSu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_DangKyLamGiaSu,
            this.menuItem_DanhSachLopMoi});
            this.menuItem_DanhChoGiaSu.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.menuItem_DanhChoGiaSu.Name = "menuItem_DanhChoGiaSu";
            this.menuItem_DanhChoGiaSu.Size = new System.Drawing.Size(193, 45);
            this.menuItem_DanhChoGiaSu.Text = "Dành Cho Gia Sư";
            // 
            // menuItem_DangKyLamGiaSu
            // 
            this.menuItem_DangKyLamGiaSu.Name = "menuItem_DangKyLamGiaSu";
            this.menuItem_DangKyLamGiaSu.Size = new System.Drawing.Size(292, 40);
            this.menuItem_DangKyLamGiaSu.Text = "Đăng Kí Làm Gia Sư";
            this.menuItem_DangKyLamGiaSu.Click += new System.EventHandler(this.menuItem_DangKyLamGiaSu_Click);
            // 
            // menuItem_DanhSachLopMoi
            // 
            this.menuItem_DanhSachLopMoi.Name = "menuItem_DanhSachLopMoi";
            this.menuItem_DanhSachLopMoi.Size = new System.Drawing.Size(292, 40);
            this.menuItem_DanhSachLopMoi.Text = "Danh Sách Lớp Mới";
            this.menuItem_DanhSachLopMoi.Click += new System.EventHandler(this.menuItem_DanhSachLopMoi_Click);
            // 
            // menuItem_LienHe
            // 
            this.menuItem_LienHe.Name = "menuItem_LienHe";
            this.menuItem_LienHe.Size = new System.Drawing.Size(103, 45);
            this.menuItem_LienHe.Text = "Liên Hệ";
            this.menuItem_LienHe.Click += new System.EventHandler(this.menuItem_LienHe_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(12, 45);
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(125, 58);
            this.tb_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(132, 22);
            this.tb_MatKhau.TabIndex = 4;
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Location = new System.Drawing.Point(125, 23);
            this.tb_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(132, 22);
            this.tb_TaiKhoan.TabIndex = 3;
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_MatKhau.Location = new System.Drawing.Point(31, 58);
            this.lb_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(73, 24);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật Khẩu";
            // 
            // bt_DangNhap
            // 
            this.bt_DangNhap.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.bt_DangNhap.Location = new System.Drawing.Point(157, 90);
            this.bt_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangNhap.Name = "bt_DangNhap";
            this.bt_DangNhap.Size = new System.Drawing.Size(101, 33);
            this.bt_DangNhap.TabIndex = 0;
            this.bt_DangNhap.Text = "Đăng Nhập";
            this.bt_DangNhap.UseVisualStyleBackColor = true;
            this.bt_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lb_TaiKhoan
            // 
            this.lb_TaiKhoan.AutoSize = true;
            this.lb_TaiKhoan.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_TaiKhoan.Location = new System.Drawing.Point(28, 23);
            this.lb_TaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_TaiKhoan.Name = "lb_TaiKhoan";
            this.lb_TaiKhoan.Size = new System.Drawing.Size(76, 24);
            this.lb_TaiKhoan.TabIndex = 1;
            this.lb_TaiKhoan.Text = "Tài Khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_TaiKhoan);
            this.groupBox1.Controls.Add(this.bt_DangNhap);
            this.groupBox1.Controls.Add(this.lb_MatKhau);
            this.groupBox1.Controls.Add(this.tb_TaiKhoan);
            this.groupBox1.Controls.Add(this.tb_MatKhau);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(1036, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1308, 686);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_theme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTrangChu";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_theme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TimGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_GiaoVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhChoGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LienHe;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Button bt_DangNhap;
        private System.Windows.Forms.Label lb_TaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangKyLamGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhSachLopMoi;
    }
}

