namespace QLTTGS
{
    partial class FormDanhSachLopMoi
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_TrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_TimGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_GiaoVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_SinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DanhChoGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DangKyLamGiaSu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_DanhSachLopMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_LienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_taikhoan = new System.Windows.Forms.Label();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.tb_Taikhoan = new System.Windows.Forms.TextBox();
            this.tb_Matkhau = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ll_DangKyLamGiaSu = new System.Windows.Forms.LinkLabel();
            this.bt_DangKiLop = new System.Windows.Forms.Button();
            this.tb_maGiaSu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_GVSV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_maLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachLopMoi = new System.Windows.Forms.DataGridView();
            this.mãLớpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mãHSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngàyNhậnLớpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lươngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốBuổiDạyTuầnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yêuCầuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lớpChưaGiaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tTGS = new QLTTGS.TTGS();
            this.lớp_Chưa_GiaoTableAdapter = new QLTTGS.TTGSTableAdapters.Lớp_Chưa_GiaoTableAdapter();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachLopMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lớpChưaGiaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTGS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.menuStrip1);
            this.groupBox3.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(99, 137);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(753, 58);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
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
            this.menuStrip1.Location = new System.Drawing.Point(4, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(643, 49);
            this.menuStrip1.TabIndex = 1;
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
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.lb_taikhoan);
            this.groupBox4.Controls.Add(this.btn_DangNhap);
            this.groupBox4.Controls.Add(this.lb_Matkhau);
            this.groupBox4.Controls.Add(this.tb_Taikhoan);
            this.groupBox4.Controls.Add(this.tb_Matkhau);
            this.groupBox4.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox4.Location = new System.Drawing.Point(1043, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(267, 123);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.ll_DangKyLamGiaSu);
            this.groupBox1.Controls.Add(this.bt_DangKiLop);
            this.groupBox1.Controls.Add(this.tb_maGiaSu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_GVSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_maLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgv_DanhSachLopMoi);
            this.groupBox1.Font = new System.Drawing.Font("Sitka Banner", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(52, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1216, 477);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Lớp Mới";
            // 
            // ll_DangKyLamGiaSu
            // 
            this.ll_DangKyLamGiaSu.AutoSize = true;
            this.ll_DangKyLamGiaSu.Location = new System.Drawing.Point(849, 56);
            this.ll_DangKyLamGiaSu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ll_DangKyLamGiaSu.Name = "ll_DangKyLamGiaSu";
            this.ll_DangKyLamGiaSu.Size = new System.Drawing.Size(317, 29);
            this.ll_DangKyLamGiaSu.TabIndex = 13;
            this.ll_DangKyLamGiaSu.TabStop = true;
            this.ll_DangKyLamGiaSu.Text = "Chưa đăng kí làm gia sư? Click here..";
            this.ll_DangKyLamGiaSu.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ll_DangKyLamGiaSu_LinkClicked);
            // 
            // bt_DangKiLop
            // 
            this.bt_DangKiLop.Location = new System.Drawing.Point(555, 56);
            this.bt_DangKiLop.Margin = new System.Windows.Forms.Padding(4);
            this.bt_DangKiLop.Name = "bt_DangKiLop";
            this.bt_DangKiLop.Size = new System.Drawing.Size(200, 44);
            this.bt_DangKiLop.TabIndex = 12;
            this.bt_DangKiLop.Text = "Đăng Kí Nhận Lớp";
            this.bt_DangKiLop.UseVisualStyleBackColor = true;
            this.bt_DangKiLop.Click += new System.EventHandler(this.bt_DangKiLop_Click);
            // 
            // tb_maGiaSu
            // 
            this.tb_maGiaSu.Location = new System.Drawing.Point(388, 63);
            this.tb_maGiaSu.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maGiaSu.Name = "tb_maGiaSu";
            this.tb_maGiaSu.Size = new System.Drawing.Size(132, 33);
            this.tb_maGiaSu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã Gia Sư :";
            // 
            // cb_GVSV
            // 
            this.cb_GVSV.FormattingEnabled = true;
            this.cb_GVSV.Items.AddRange(new object[] {
            "Giáo Viên",
            "Sinh Viên"});
            this.cb_GVSV.Location = new System.Drawing.Point(228, 63);
            this.cb_GVSV.Margin = new System.Windows.Forms.Padding(4);
            this.cb_GVSV.Name = "cb_GVSV";
            this.cb_GVSV.Size = new System.Drawing.Size(112, 37);
            this.cb_GVSV.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bạn là:";
            // 
            // tb_maLop
            // 
            this.tb_maLop.Location = new System.Drawing.Point(34, 63);
            this.tb_maLop.Margin = new System.Windows.Forms.Padding(4);
            this.tb_maLop.Name = "tb_maLop";
            this.tb_maLop.Size = new System.Drawing.Size(136, 33);
            this.tb_maLop.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Mã Lớp :";
            // 
            // dgv_DanhSachLopMoi
            // 
            this.dgv_DanhSachLopMoi.AutoGenerateColumns = false;
            this.dgv_DanhSachLopMoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachLopMoi.BackgroundColor = System.Drawing.Color.White;
            this.dgv_DanhSachLopMoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachLopMoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãLớpDataGridViewTextBoxColumn,
            this.mãHSDataGridViewTextBoxColumn,
            this.ngàyNhậnLớpDataGridViewTextBoxColumn,
            this.lươngDataGridViewTextBoxColumn,
            this.sốBuổiDạyTuầnDataGridViewTextBoxColumn,
            this.yêuCầuDataGridViewTextBoxColumn});
            this.dgv_DanhSachLopMoi.DataSource = this.lớpChưaGiaoBindingSource;
            this.dgv_DanhSachLopMoi.Location = new System.Drawing.Point(34, 108);
            this.dgv_DanhSachLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_DanhSachLopMoi.Name = "dgv_DanhSachLopMoi";
            this.dgv_DanhSachLopMoi.Size = new System.Drawing.Size(1145, 361);
            this.dgv_DanhSachLopMoi.TabIndex = 0;
            this.dgv_DanhSachLopMoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachLopMoi_CellClick);
            // 
            // mãLớpDataGridViewTextBoxColumn
            // 
            this.mãLớpDataGridViewTextBoxColumn.DataPropertyName = "Mã Lớp";
            this.mãLớpDataGridViewTextBoxColumn.HeaderText = "Mã Lớp";
            this.mãLớpDataGridViewTextBoxColumn.Name = "mãLớpDataGridViewTextBoxColumn";
            // 
            // mãHSDataGridViewTextBoxColumn
            // 
            this.mãHSDataGridViewTextBoxColumn.DataPropertyName = "Mã HS";
            this.mãHSDataGridViewTextBoxColumn.HeaderText = "Mã HS";
            this.mãHSDataGridViewTextBoxColumn.Name = "mãHSDataGridViewTextBoxColumn";
            // 
            // ngàyNhậnLớpDataGridViewTextBoxColumn
            // 
            this.ngàyNhậnLớpDataGridViewTextBoxColumn.DataPropertyName = "Ngày Nhận Lớp";
            this.ngàyNhậnLớpDataGridViewTextBoxColumn.HeaderText = "Ngày Nhận Lớp";
            this.ngàyNhậnLớpDataGridViewTextBoxColumn.Name = "ngàyNhậnLớpDataGridViewTextBoxColumn";
            // 
            // lươngDataGridViewTextBoxColumn
            // 
            this.lươngDataGridViewTextBoxColumn.DataPropertyName = "Lương";
            this.lươngDataGridViewTextBoxColumn.HeaderText = "Lương";
            this.lươngDataGridViewTextBoxColumn.Name = "lươngDataGridViewTextBoxColumn";
            // 
            // sốBuổiDạyTuầnDataGridViewTextBoxColumn
            // 
            this.sốBuổiDạyTuầnDataGridViewTextBoxColumn.DataPropertyName = "Số Buổi Dạy/Tuần";
            this.sốBuổiDạyTuầnDataGridViewTextBoxColumn.HeaderText = "Số Buổi Dạy/Tuần";
            this.sốBuổiDạyTuầnDataGridViewTextBoxColumn.Name = "sốBuổiDạyTuầnDataGridViewTextBoxColumn";
            // 
            // yêuCầuDataGridViewTextBoxColumn
            // 
            this.yêuCầuDataGridViewTextBoxColumn.DataPropertyName = "Yêu Cầu";
            this.yêuCầuDataGridViewTextBoxColumn.HeaderText = "Yêu Cầu";
            this.yêuCầuDataGridViewTextBoxColumn.Name = "yêuCầuDataGridViewTextBoxColumn";
            // 
            // lớpChưaGiaoBindingSource
            // 
            this.lớpChưaGiaoBindingSource.DataMember = "Lớp Chưa Giao";
            this.lớpChưaGiaoBindingSource.DataSource = this.tTGS;
            // 
            // tTGS
            // 
            this.tTGS.DataSetName = "TTGS";
            this.tTGS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lớp_Chưa_GiaoTableAdapter
            // 
            this.lớp_Chưa_GiaoTableAdapter.ClearBeforeFill = true;
            // 
            // FormDanhSachLopMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLTTGS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormDanhSachLopMoi";
            this.Text = "DanhSachLopMoi";
            this.Load += new System.EventHandler(this.DanhSachLopMoi_Load);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachLopMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lớpChưaGiaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tTGS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TrangChu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_TimGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_GiaoVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_SinhVien;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhChoGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DangKyLamGiaSu;
        private System.Windows.Forms.ToolStripMenuItem menuItem_DanhSachLopMoi;
        private System.Windows.Forms.ToolStripMenuItem menuItem_LienHe;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_taikhoan;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.TextBox tb_Taikhoan;
        private System.Windows.Forms.TextBox tb_Matkhau;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DanhSachLopMoi;
        private TTGS tTGS;
        private System.Windows.Forms.BindingSource lớpChưaGiaoBindingSource;
        private TTGSTableAdapters.Lớp_Chưa_GiaoTableAdapter lớp_Chưa_GiaoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãLớpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãHSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyNhậnLớpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lươngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốBuổiDạyTuầnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yêuCầuDataGridViewTextBoxColumn;
        private System.Windows.Forms.LinkLabel ll_DangKyLamGiaSu;
        private System.Windows.Forms.Button bt_DangKiLop;
        private System.Windows.Forms.TextBox tb_maGiaSu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_GVSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_maLop;
        private System.Windows.Forms.Label label1;
    }
}