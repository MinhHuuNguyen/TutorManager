namespace QLTTGS
{
    partial class FormTimGiaSu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.tb_Taikhoan = new System.Windows.Forms.TextBox();
            this.tb_Matkhau = new System.Windows.Forms.TextBox();
            this.gb_menu = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_TrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_TimGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_GiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DanhChoGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DangKyLamGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DanhSachLopMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_timGiaoVien = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_timGiaoVien = new System.Windows.Forms.TextBox();
            this.cb_timGiaoVien = new System.Windows.Forms.ComboBox();
            this.tTGiáoViênBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTGS = new QLTTGS.TTGS();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_timGiaoVien = new System.Windows.Forms.DataGridView();
            this.tT_Giáo_ViênTableAdapter = new QLTTGS.TTGSTableAdapters.TT_Giáo_ViênTableAdapter();
            this.gb_timSinhVien = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_timSinhVien = new System.Windows.Forms.TextBox();
            this.cb_timSinhVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_timSinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.gb_menu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gb_timGiaoVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTGiáoViênBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTGS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timGiaoVien)).BeginInit();
            this.gb_timSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_taikhoan);
            this.groupBox1.Controls.Add(this.btn_DangNhap);
            this.groupBox1.Controls.Add(this.lb_Matkhau);
            this.groupBox1.Controls.Add(this.tb_Taikhoan);
            this.groupBox1.Controls.Add(this.tb_Matkhau);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(1029, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            // gb_menu
            // 
            this.gb_menu.BackColor = System.Drawing.Color.Transparent;
            this.gb_menu.Controls.Add(this.menuStrip1);
            this.gb_menu.Location = new System.Drawing.Point(103, 140);
            this.gb_menu.Margin = new System.Windows.Forms.Padding(4);
            this.gb_menu.Name = "gb_menu";
            this.gb_menu.Padding = new System.Windows.Forms.Padding(4);
            this.gb_menu.Size = new System.Drawing.Size(839, 58);
            this.gb_menu.TabIndex = 8;
            this.gb_menu.TabStop = false;
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
            // gb_timGiaoVien
            // 
            this.gb_timGiaoVien.BackColor = System.Drawing.Color.Transparent;
            this.gb_timGiaoVien.Controls.Add(this.label2);
            this.gb_timGiaoVien.Controls.Add(this.tb_timGiaoVien);
            this.gb_timGiaoVien.Controls.Add(this.cb_timGiaoVien);
            this.gb_timGiaoVien.Controls.Add(this.label1);
            this.gb_timGiaoVien.Controls.Add(this.dgv_timGiaoVien);
            this.gb_timGiaoVien.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold);
            this.gb_timGiaoVien.Location = new System.Drawing.Point(32, 206);
            this.gb_timGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.gb_timGiaoVien.Name = "gb_timGiaoVien";
            this.gb_timGiaoVien.Padding = new System.Windows.Forms.Padding(4);
            this.gb_timGiaoVien.Size = new System.Drawing.Size(1256, 470);
            this.gb_timGiaoVien.TabIndex = 9;
            this.gb_timGiaoVien.TabStop = false;
            this.gb_timGiaoVien.Text = "Gia Sư Giáo Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nội dung";
            // 
            // tb_timGiaoVien
            // 
            this.tb_timGiaoVien.Location = new System.Drawing.Point(908, 21);
            this.tb_timGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_timGiaoVien.Name = "tb_timGiaoVien";
            this.tb_timGiaoVien.Size = new System.Drawing.Size(277, 37);
            this.tb_timGiaoVien.TabIndex = 3;
            this.tb_timGiaoVien.TextChanged += new System.EventHandler(this.tb_timGiaoVien_TextChanged);
            // 
            // cb_timGiaoVien
            // 
            this.cb_timGiaoVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tTGiáoViênBindingSource, "Môn", true));
            this.cb_timGiaoVien.FormattingEnabled = true;
            this.cb_timGiaoVien.Items.AddRange(new object[] {
            "Họ Và Tên",
            "Lớp",
            "Môn",
            "Đại Học",
            "Chuyên Ngành"});
            this.cb_timGiaoVien.Location = new System.Drawing.Point(477, 17);
            this.cb_timGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.cb_timGiaoVien.Name = "cb_timGiaoVien";
            this.cb_timGiaoVien.Size = new System.Drawing.Size(228, 43);
            this.cb_timGiaoVien.TabIndex = 2;
            // 
            // tTGiáoViênBindingSource
            // 
            this.tTGiáoViênBindingSource.DataMember = "TT Giáo Viên";
            this.tTGiáoViênBindingSource.DataSource = this.tTGS;
            // 
            // tTGS
            // 
            this.tTGS.DataSetName = "TTGS";
            this.tTGS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm Kiếm";
            // 
            // dgv_timGiaoVien
            // 
            this.dgv_timGiaoVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_timGiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timGiaoVien.Location = new System.Drawing.Point(56, 63);
            this.dgv_timGiaoVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_timGiaoVien.Name = "dgv_timGiaoVien";
            this.dgv_timGiaoVien.Size = new System.Drawing.Size(1151, 400);
            this.dgv_timGiaoVien.TabIndex = 0;
            // 
            // tT_Giáo_ViênTableAdapter
            // 
            this.tT_Giáo_ViênTableAdapter.ClearBeforeFill = true;
            // 
            // gb_timSinhVien
            // 
            this.gb_timSinhVien.AutoSize = true;
            this.gb_timSinhVien.BackColor = System.Drawing.Color.Transparent;
            this.gb_timSinhVien.Controls.Add(this.label3);
            this.gb_timSinhVien.Controls.Add(this.tb_timSinhVien);
            this.gb_timSinhVien.Controls.Add(this.cb_timSinhVien);
            this.gb_timSinhVien.Controls.Add(this.label4);
            this.gb_timSinhVien.Controls.Add(this.dgv_timSinhVien);
            this.gb_timSinhVien.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold);
            this.gb_timSinhVien.Location = new System.Drawing.Point(32, 206);
            this.gb_timSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.gb_timSinhVien.Name = "gb_timSinhVien";
            this.gb_timSinhVien.Padding = new System.Windows.Forms.Padding(4);
            this.gb_timSinhVien.Size = new System.Drawing.Size(1256, 501);
            this.gb_timSinhVien.TabIndex = 10;
            this.gb_timSinhVien.TabStop = false;
            this.gb_timSinhVien.Text = "Gia Sư Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nội dung";
            // 
            // tb_timSinhVien
            // 
            this.tb_timSinhVien.Location = new System.Drawing.Point(908, 21);
            this.tb_timSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.tb_timSinhVien.Name = "tb_timSinhVien";
            this.tb_timSinhVien.Size = new System.Drawing.Size(277, 37);
            this.tb_timSinhVien.TabIndex = 3;
            this.tb_timSinhVien.TextChanged += new System.EventHandler(this.tb_timSinhVien_TextChanged);
            // 
            // cb_timSinhVien
            // 
            this.cb_timSinhVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tTGiáoViênBindingSource, "Môn", true));
            this.cb_timSinhVien.FormattingEnabled = true;
            this.cb_timSinhVien.Items.AddRange(new object[] {
            "Họ Và Tên",
            "Lớp",
            "Môn",
            "Đại Học"});
            this.cb_timSinhVien.Location = new System.Drawing.Point(477, 17);
            this.cb_timSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.cb_timSinhVien.Name = "cb_timSinhVien";
            this.cb_timSinhVien.Size = new System.Drawing.Size(228, 43);
            this.cb_timSinhVien.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 35);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tìm Kiếm";
            // 
            // dgv_timSinhVien
            // 
            this.dgv_timSinhVien.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_timSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_timSinhVien.Location = new System.Drawing.Point(56, 63);
            this.dgv_timSinhVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_timSinhVien.Name = "dgv_timSinhVien";
            this.dgv_timSinhVien.Size = new System.Drawing.Size(1151, 400);
            this.dgv_timSinhVien.TabIndex = 0;
            // 
            // FormTimGiaSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTTGS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.gb_timSinhVien);
            this.Controls.Add(this.gb_timGiaoVien);
            this.Controls.Add(this.gb_menu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormTimGiaSu";
            this.Text = "TimGiaSuGV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_menu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb_timGiaoVien.ResumeLayout(false);
            this.gb_timGiaoVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tTGiáoViênBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTGS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timGiaoVien)).EndInit();
            this.gb_timSinhVien.ResumeLayout(false);
            this.gb_timSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_timSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.TextBox tb_Taikhoan;
        private System.Windows.Forms.TextBox tb_Matkhau;
        private System.Windows.Forms.GroupBox gb_menu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TimGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_GiaoVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhChoGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LienHe;
        private System.Windows.Forms.GroupBox gb_timGiaoVien;
        private System.Windows.Forms.DataGridView dgv_timGiaoVien;
        private TTGS tTGS;
        private System.Windows.Forms.BindingSource tTGiáoViênBindingSource;
        private TTGSTableAdapters.TT_Giáo_ViênTableAdapter tT_Giáo_ViênTableAdapter;
        private System.Windows.Forms.ComboBox cb_timGiaoVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_timGiaoVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_timSinhVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timSinhVien;
        private System.Windows.Forms.ComboBox cb_timSinhVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_timSinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangKyLamGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhSachLopMoi;
    }
}