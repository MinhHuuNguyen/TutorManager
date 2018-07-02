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
    public partial class FormDangKiLamGiaSu : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        private SqlCommand cmd;

        public FormDangKiLamGiaSu()
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

        private void menuItem_DanhSachLopMoi_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDanhSachLopMoi());
        }

        private void menuItem_LienHe_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormLienHe());
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDaDangNhap());
        }

        private void btn_GuiDangKy_Click(object sender, EventArgs e)
        {
            if (cb_TrinhDoHocVan.Text == "Giáo Viên")
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GiaoVienInsert";
                cmd.Connection = con;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = tb_HoVaTen.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tb_SoDienThoai.Text;
                cmd.Parameters.Add("@mon", SqlDbType.NVarChar).Value = cb_DayMon.Text;
                cmd.Parameters.Add("@lop", SqlDbType.Char).Value = cb_LopDay.Text;
                cmd.Parameters.Add("@chuyenNganh", SqlDbType.NVarChar).Value = tb_ChuyenNganh.Text;
                cmd.Parameters.Add("@daiHoc", SqlDbType.NVarChar).Value = tb_TenTruong.Text;
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
                MessageBox.Show("Đăng kí thành công!!!");
            }
            else if (cb_TrinhDoHocVan.Text == "Sinh Viên")
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SinhVienInsert";
                cmd.Connection = con;
                cmd.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = tb_HoVaTen.Text;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = tb_SoDienThoai.Text;
                cmd.Parameters.Add("@mon", SqlDbType.NVarChar).Value = cb_DayMon.Text;
                cmd.Parameters.Add("@lop", SqlDbType.Char).Value = cb_LopDay.Text;
                cmd.Parameters.Add("@daiHoc", SqlDbType.NVarChar).Value = tb_TenTruong.Text;
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
                MessageBox.Show("Đăng kí thành công!!!");
            }
        }
    }
}
