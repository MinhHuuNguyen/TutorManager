using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTTGS
{
    public partial class FormDangKiLopHoc : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        private SqlCommand cmd;
        
        public FormDangKiLopHoc()
        {
            InitializeComponent();
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_GiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_SinhVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DangKyLamGiaSu_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DanhSachLopMoi_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_LienHe_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDaDangNhap());
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ĐKOnlineInsert";
            cmd.Connection = con;
            cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = tb_HoTen.Text;
            cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tb_SoDienThoai.Text;
            cmd.Parameters.Add("@mon", SqlDbType.NVarChar).Value = cb_Mon.Text;
            cmd.Parameters.Add("@lop", SqlDbType.Char).Value = cb_Lop.Text;
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

            MessageBox.Show("Đăng Kí Thành Công");

        }
    }
}
