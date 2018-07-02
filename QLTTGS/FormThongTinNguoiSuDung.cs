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
    public partial class FormThongTinNguoiSuDung : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlCommandBuilder builder;
        DataTable dt;

        public FormThongTinNguoiSuDung()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Image";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image|*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void bt_capNhatThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(dt);
                MessageBox.Show("Cập Nhật Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox2.Hide();
            groupBox3.Hide();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_QuanLy";
            cmd.Connection = con;
            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                builder = new SqlCommandBuilder(da);
                dgv_thongTin.DataSource = dt;
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

        private void cậpNhậtHồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_SelectAllNhanVien";
            cmd.Connection = con;
            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                builder = new SqlCommandBuilder(da);
                dgv_thongTin.DataSource = dt;
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

        private void ýKiếnĐóngGópToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_LienHe";
            cmd.Connection = con;
            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                dgv_thongTin.DataSource = dt;
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

        private void bt_capNhatNV_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            groupBox1.Hide();
            groupBox3.Hide();
            try
            {
                da.Update(dt);
                MessageBox.Show("Cập Nhật Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_xóa_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deleteNhanVien";
            cmd.Parameters.Add("@maNV", SqlDbType.VarChar).Value = textBox1.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                builder = new SqlCommandBuilder(da);
                dgv_thongTin.DataSource = dt;
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

        private void dgv_TTNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.DataBindings.Clear();
            textBox1.DataBindings.Add("text", dt, "Mã NV");
        }



        private void bt_xongCapNhat_Click(object sender, EventArgs e)
        {
            FormDaDangNhap infoUser = new FormDaDangNhap();
            infoUser.Show();
            infoUser.Location = Location;
            Hide();
        }

        private void bt_xongThongTin_Click(object sender, EventArgs e)
        {
            FormDaDangNhap infoUser = new FormDaDangNhap();
            infoUser.Show();
            infoUser.Location = Location;
            Hide();
        }

        private void bt_xongYKien_Click(object sender, EventArgs e)
        {
            FormDaDangNhap infoUser = new FormDaDangNhap();
            infoUser.Show();
            infoUser.Location = Location;
            Hide();
        }
    }
}
