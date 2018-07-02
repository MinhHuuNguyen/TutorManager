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
    public partial class FormDanhSachLopMoi : Form
    {
        private SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;

        public FormDanhSachLopMoi()
        {
            InitializeComponent();
        }

        private void DanhSachLopMoi_Load(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_danhSachLopMoi";
            cmd.Connection = con;

            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv_DanhSachLopMoi.DataSource = dt;
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
        }

        private void dgv_DanhSachLopMoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_maLop.DataBindings.Clear();
            tb_maLop.DataBindings.Add("text", dt, "Mã Lớp");
        }

        private void bt_DangKiLop_Click(object sender, EventArgs e)
        {
            if (cb_GVSV.Text == "Giáo Viên")
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GVĐăngKíLớp";
                cmd.Connection = con;
                cmd.Parameters.Add("@maLop", SqlDbType.NVarChar).Value = tb_maLop.Text;
                cmd.Parameters.Add("@maGV", SqlDbType.NVarChar).Value = tb_maGiaSu.Text;
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
            }
            else if (cb_GVSV.Text == "Sinh Viên")
            {
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_SVĐăngKíLớp";
                cmd.Connection = con;
                cmd.Parameters.Add("@maLop", SqlDbType.NVarChar).Value = tb_maLop.Text;
                cmd.Parameters.Add("@maSV", SqlDbType.NVarChar).Value = tb_maGiaSu.Text;
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
            }
            MessageBox.Show("Đã Gửi Yêu Cầu !!!");
        }

        private void ll_DangKyLamGiaSu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDangKiLamGiaSu dangKiLamGiaSu = new FormDangKiLamGiaSu();
            dangKiLamGiaSu.Show();
            dangKiLamGiaSu.Location = Location;
            Hide();
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
            dgv_DanhSachLopMoi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_DanhSachLopMoi.DataSource = AllDataSet.dgvLopChuaGiao().Tables[0];
        }

        private void menuItem_LienHe_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormLienHe());
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormDaDangNhap());
        }


    }
}

