using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTTGS
{
    public partial class FormTimGiaSu : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;
        public static bool laSinhVien = true;

        public FormTimGiaSu()
        {
            InitializeComponent();
            if (laSinhVien)
            {
                gb_timGiaoVien.Hide();
            }
            else
            {
                gb_timSinhVien.Hide();
            }
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            FormManager.ChangeForm(this, formTrangChu);
        }

        private void menuItem_GiaoVien_Click(object sender, EventArgs e)
        {
            gb_timGiaoVien.Show();
            gb_timSinhVien.Hide();
        }

        private void menuItem_SinhVien_Click(object sender, EventArgs e)
        {
            gb_timGiaoVien.Hide();
            gb_timSinhVien.Show();
        }
        

        private void menuItem_LienHe_Click(object sender, EventArgs e)
        {
            FormLienHe formLienHe = new FormLienHe();
            FormManager.ChangeForm(this, formLienHe);
        }

        private void menuItem_DangKyLamGiaSu_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDangKiLamGiaSu());
        }

        private void menuItem_DanhSachLopMoi_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDanhSachLopMoi());
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDaDangNhap());
        }

        private void tb_timGiaoVien_TextChanged(object sender, EventArgs e)
        {
            if (cb_timGiaoVien.Text == "Họ Và Tên")
            {
                da = new SqlDataAdapter("SELECT [MÃ GV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC],[CHUYÊN NGÀNH] FROM[TT Giáo Viên] WHERE [HỌ VÀ TÊN] LIKE '%" +tb_timGiaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timGiaoVien.DataSource = dt;
            }
            else if (cb_timGiaoVien.Text == "Lớp")
            {
                da = new SqlDataAdapter("SELECT [MÃ GV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC],[CHUYÊN NGÀNH] FROM[TT Giáo Viên] WHERE [LỚP] LIKE '" + tb_timGiaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timGiaoVien.DataSource = dt;
            }
            else if (cb_timGiaoVien.Text =="Môn")
            {
                da = new SqlDataAdapter("SELECT [MÃ GV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC],[CHUYÊN NGÀNH] FROM[TT Giáo Viên] WHERE [MÔN] LIKE '" + tb_timGiaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timGiaoVien.DataSource = dt;
            }
            else if(cb_timGiaoVien.Text=="Đại Học")
            {
                da = new SqlDataAdapter("SELECT [MÃ GV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC],[CHUYÊN NGÀNH] FROM[TT Giáo Viên] WHERE [Đại Học] LIKE '%" + tb_timGiaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timGiaoVien.DataSource = dt;
            }
            else if(cb_timGiaoVien.Text=="Chuyên Ngành")
            {
                da = new SqlDataAdapter("SELECT [MÃ GV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC],[CHUYÊN NGÀNH] FROM[TT Giáo Viên] WHERE [Chuyên Ngành] LIKE '%" + tb_timGiaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timGiaoVien.DataSource = dt;
            }
            dgv_timGiaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void tb_timSinhVien_TextChanged(object sender, EventArgs e)
        {
            if (cb_timSinhVien.Text == "Họ Và Tên")
            {
                da = new SqlDataAdapter("SELECT [MÃ SV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC] FROM[TT SINH VIÊN] WHERE [HỌ VÀ TÊN] LIKE '%" + tb_timSinhVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timSinhVien.DataSource = dt;
            }
            else if (cb_timSinhVien.Text == "Lớp")
            {
                da = new SqlDataAdapter("SELECT [MÃ SV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC] FROM[TT SINH VIÊN] WHERE [LỚP] LIKE '" + tb_timSinhVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timSinhVien.DataSource = dt;
            }
            else if (cb_timSinhVien.Text == "Môn")
            {
                da = new SqlDataAdapter("SELECT [MÃ SV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC] FROM[TT SINH VIÊN] WHERE [MÔN] LIKE '" + tb_timSinhVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timSinhVien.DataSource = dt;
            }
            else if (cb_timSinhVien.Text == "Đại Học")
            {
                da = new SqlDataAdapter("SELECT [MÃ SV],[HỌ VÀ TÊN],[LỚP],[MÔN],[ĐẠI HỌC] FROM[TT SINH VIÊN] WHERE [Đại Học] LIKE '%" + tb_timSinhVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_timSinhVien.DataSource = dt;
            }
        }
    }
}
