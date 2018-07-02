using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTGS
{
    public partial class FormLienHe : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        private SqlCommand cmd;

        public FormLienHe()
        {
            InitializeComponent();
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormTrangChu());
        }

        private void menuItem_GiaoVien_Click(object sender, EventArgs e)
        {
            FormTimGiaSu.laSinhVien = false;
            FormManager.ChangeForm(this, new FormTimGiaSu());
        }

        private void menuItem_SinhVien_Click(object sender, EventArgs e)
        {
            FormTimGiaSu.laSinhVien = true;
            FormManager.ChangeForm(this, new FormTimGiaSu());
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

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LienHeInsert";
            cmd.Connection = con;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = tb_HoTen.Text;
            cmd.Parameters.Add("@yKien", SqlDbType.NVarChar).Value = tb_YKien.Text;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            MessageBox.Show("Đã Gửi Yêu Cầu !!!");
        }

    }
}
