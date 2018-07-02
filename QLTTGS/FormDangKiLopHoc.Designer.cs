namespace QLTTGS
{
    partial class FormDangKiLopHoc
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
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.tb_SoDienThoai = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.cb_Lop = new System.Windows.Forms.ComboBox();
            this.cb_Mon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.tb_Taikhoan = new System.Windows.Forms.TextBox();
            this.tb_Matkhau = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.ForeColor = System.Drawing.Color.Black;
            this.btn_DangKy.Location = new System.Drawing.Point(392, 319);
            this.btn_DangKy.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(211, 63);
            this.btn_DangKy.TabIndex = 8;
            this.btn_DangKy.Text = "Đăng Kí";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            this.btn_DangKy.Click += new System.EventHandler(this.btn_DangKy_Click);
            // 
            // tb_SoDienThoai
            // 
            this.tb_SoDienThoai.Location = new System.Drawing.Point(287, 118);
            this.tb_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SoDienThoai.Name = "tb_SoDienThoai";
            this.tb_SoDienThoai.Size = new System.Drawing.Size(315, 37);
            this.tb_SoDienThoai.TabIndex = 6;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(287, 60);
            this.tb_HoTen.Margin = new System.Windows.Forms.Padding(4);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(315, 37);
            this.tb_HoTen.TabIndex = 5;
            // 
            // cb_Lop
            // 
            this.cb_Lop.FormattingEnabled = true;
            this.cb_Lop.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cb_Lop.Location = new System.Drawing.Point(441, 181);
            this.cb_Lop.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Lop.Name = "cb_Lop";
            this.cb_Lop.Size = new System.Drawing.Size(160, 43);
            this.cb_Lop.TabIndex = 3;
            this.cb_Lop.Text = "Lớp";
            // 
            // cb_Mon
            // 
            this.cb_Mon.FormattingEnabled = true;
            this.cb_Mon.Items.AddRange(new object[] {
            "Toán",
            "Văn",
            "Anh ",
            "Sinh",
            "Địa"});
            this.cb_Mon.Location = new System.Drawing.Point(115, 181);
            this.cb_Mon.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Mon.Name = "cb_Mon";
            this.cb_Mon.Size = new System.Drawing.Size(160, 43);
            this.cb_Mon.TabIndex = 2;
            this.cb_Mon.Text = "Môn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 35);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Và Tên";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_DangKy);
            this.groupBox1.Controls.Add(this.cb_Lop);
            this.groupBox1.Controls.Add(this.tb_SoDienThoai);
            this.groupBox1.Controls.Add(this.cb_Mon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_HoTen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(45, 219);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1203, 457);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.menuStrip1);
            this.groupBox2.Location = new System.Drawing.Point(101, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(839, 58);
            this.groupBox2.TabIndex = 10;
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
            this.menuItem_LienHe});
            this.menuStrip1.Location = new System.Drawing.Point(4, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lb_taikhoan);
            this.groupBox3.Controls.Add(this.btn_DangNhap);
            this.groupBox3.Controls.Add(this.lb_Matkhau);
            this.groupBox3.Controls.Add(this.tb_Taikhoan);
            this.groupBox3.Controls.Add(this.tb_Matkhau);
            this.groupBox3.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox3.Location = new System.Drawing.Point(1029, 15);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 123);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // lb_taikhoan
            // 
            this.lb_taikhoan.AutoSize = true;
            this.lb_taikhoan.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_taikhoan.Location = new System.Drawing.Point(28, 23);
            this.lb_taikhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_taikhoan.Name = "lb_taikhoan";
            this.lb_taikhoan.Size = new System.Drawing.Size(76, 24);
            this.lb_taikhoan.TabIndex = 1;
            this.lb_taikhoan.Text = "Tài Khoản";
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangNhap.ForeColor = System.Drawing.Color.Black;
            this.btn_DangNhap.Location = new System.Drawing.Point(157, 90);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(101, 33);
            this.btn_DangNhap.TabIndex = 0;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.Font = new System.Drawing.Font("Sitka Banner", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matkhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lb_Matkhau.Location = new System.Drawing.Point(28, 57);
            this.lb_Matkhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(73, 24);
            this.lb_Matkhau.TabIndex = 2;
            this.lb_Matkhau.Text = "Mật Khẩu";
            // 
            // tb_Taikhoan
            // 
            this.tb_Taikhoan.Location = new System.Drawing.Point(125, 23);
            this.tb_Taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Taikhoan.Name = "tb_Taikhoan";
            this.tb_Taikhoan.Size = new System.Drawing.Size(132, 22);
            this.tb_Taikhoan.TabIndex = 3;
            // 
            // tb_Matkhau
            // 
            this.tb_Matkhau.Location = new System.Drawing.Point(125, 58);
            this.tb_Matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Matkhau.Name = "tb_Matkhau";
            this.tb_Matkhau.Size = new System.Drawing.Size(132, 22);
            this.tb_Matkhau.TabIndex = 4;
            // 
            // FormDangKiLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTTGS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDangKiLopHoc";
            this.Text = "DangKiLopHoc";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_DangKy;
        private System.Windows.Forms.TextBox tb_SoDienThoai;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.ComboBox cb_Lop;
        private System.Windows.Forms.ComboBox cb_Mon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TimGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_GiaoVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhChoGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LienHe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.TextBox tb_Taikhoan;
        private System.Windows.Forms.TextBox tb_Matkhau;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangKyLamGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhSachLopMoi;
    }
}