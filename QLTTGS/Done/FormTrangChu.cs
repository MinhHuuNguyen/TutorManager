using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTTGS
{
    public partial class FormTrangChu : Form
    {
        public FormTrangChu()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            FormDaDangNhap formDaDangNhap = new FormDaDangNhap();
            FormManager.ChangeForm(this, formDaDangNhap);
        }

        private void menuItem_GiaoVien_Click(object sender, EventArgs e)
        {
            FormTimGiaSu.laSinhVien = false;
            FormTimGiaSu formTimGiaSu = new FormTimGiaSu();
            FormManager.ChangeForm(this, formTimGiaSu);
        }

        private void menuItem_SinhVien_Click(object sender, EventArgs e)
        {
            FormTimGiaSu.laSinhVien = true;
            FormTimGiaSu formTimGiaSu = new FormTimGiaSu();
            FormManager.ChangeForm(this, formTimGiaSu);
        }

        private void menuItem_DangKyLamGiaSu_Click(object sender, EventArgs e)
        {
            FormDangKiLamGiaSu formDangKiLamGiaSu = new FormDangKiLamGiaSu();
            FormManager.ChangeForm(this, formDangKiLamGiaSu);
        }

        private void menuItem_DanhSachLopMoi_Click(object sender, EventArgs e)
        {
            FormDanhSachLopMoi formDanhSachLopMoi = new FormDanhSachLopMoi();
            FormManager.ChangeForm(this, formDanhSachLopMoi);
        }

        private void menuItem_LienHe_Click(object sender, EventArgs e)
        {
            FormLienHe formLienHe = new FormLienHe();
            FormManager.ChangeForm(this, formLienHe);
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {

        }
    }
}

