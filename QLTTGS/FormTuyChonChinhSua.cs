using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTTGS
{
    public partial class FormTuyChonChinhSua : Form
    {
        SqlConnection con = new SqlConnection(ConnectionString.connectionString);
        SqlCommandBuilder builder;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        public FormTuyChonChinhSua()
        {
            InitializeComponent();
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Hide();
            gb_phuHuynhDaLienLac.Hide();
            gb_hocSinh.Hide();
            gb_giaoVien.Hide();
        }

        private void TuyChonChinhSua_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tTGS.Lớp_Đã_Hủy' table. You can move, or remove it, as needed.
            this.lớp_Đã_HủyTableAdapter.Fill(this.tTGS.Lớp_Đã_Hủy);
            // TODO: This line of code loads data into the 'tTGS.Lớp_Đang_Giao' table. You can move, or remove it, as needed.
            this.lớp_Đang_GiaoTableAdapter.Fill(this.tTGS.Lớp_Đang_Giao);
            // TODO: This line of code loads data into the 'tTGS.Lớp_Đã_Giao' table. You can move, or remove it, as needed.
            this.lớp_Đã_GiaoTableAdapter.Fill(this.tTGS.Lớp_Đã_Giao);


        }

        private void menuItem_ChonBang_LopChuaGiao_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Show();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Hide();
            gb_hocSinh.Hide();
            gb_phuHuynhDaLienLac.Hide();
            gb_giaoVien.Hide();
            string select = "select * from [Lớp chưa giao] where [lương] is null";
            ds = new DataSet();
            da = new SqlDataAdapter(select, con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dgv_lopChuaGiao.DataSource = ds.Tables[0];
            dgv_lopChuaGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void menuItem_ChonBang_LopDaGiao_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Show();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Hide();
            gb_hocSinh.Hide();
            gb_phuHuynhDaLienLac.Hide();
            gb_giaoVien.Hide();
            string select = "select * from [Lớp Đã giao]";
            ds = new DataSet();
            da = new SqlDataAdapter(select, con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dgv_lopDaGiao.DataSource = ds.Tables[0];
        }

        private void menuItem_ChonBang_LopDaHuy_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Show();
            gb_lopDangGiao.Hide();
            gb_hocSinh.Hide();
            gb_phuHuynhDaLienLac.Hide();
            gb_giaoVien.Hide();
            string select = "select * from [Lớp đã hủy]";
            ds = new DataSet();
            da = new SqlDataAdapter(select, con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dgv_lopDaHuy.DataSource = ds.Tables[0];

        }

        private void menuItem_ChonBang_LopDangGiao_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Show();
            gb_phuHuynhDaLienLac.Hide();
            gb_hocSinh.Hide();
            gb_giaoVien.Hide();
            string select = "select * from [Lớp Đang giao]";
            ds = new DataSet();
            da = new SqlDataAdapter(select, con);
            builder = new SqlCommandBuilder(da);
            da.Fill(ds);
            dgv_lopDangGiao.DataSource = ds.Tables[0];
        }
        
        private void menuItem_ChonBang_DanhSachHocSinh_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Hide();
            gb_phuHuynhDaLienLac.Hide();
            gb_hocSinh.Show();
            gb_giaoVien.Hide();
            string select = "select * from  [TT Học Sinh] where [Họ và Tên] is null ";
            string insert = " update [lớp chưa giao] set[mã lớp] = maLop.[mã lớp] from maLop where[lớp chưa giao].[mã hs] = maLop.[mã hs] AND[Lớp Chưa Giao].[Mã Lớp] IS NULL";
            ds = new DataSet();
            DataSet data = new DataSet();
            da = new SqlDataAdapter(select, con);
            SqlDataAdapter adapter = new SqlDataAdapter(insert, con);
            builder = new SqlCommandBuilder(da);
            SqlCommandBuilder builderInsert = new SqlCommandBuilder(adapter);
            da.Fill(ds);
            adapter.Fill(data);
            dgv_hocSinh.DataSource = ds.Tables[0];
            dgv_hocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_lopChuaGiao.DataSource = AllDataSet.dgvLopChuaGiao().Tables[0];
        }

        private void menuItem_ChonBang_DanhSachPhuHuynhDaLienLac_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Hide();
            gb_phuHuynhDaLienLac.Show();
            gb_hocSinh.Hide();
            gb_giaoVien.Hide();
            dgv_phuHuynhDaLienLac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phuHuynhDaLienLac.DataSource = dgvDaLienLac().Tables[0];
            DataSet dgvDaLienLac()
            {
                DataSet data = new DataSet();
                string select = "SELECT * FROM [TT PHỤ HUYNH ĐÃ LIÊN LẠC] WHERE[MÃ PH] IN ( SELECT top 1[mã ph] from[tt phụ huynh đã liên lạc] where[mã ph] like '%ph1___' order by[mã ph] desc) ";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(select, connection);
                    da = new SqlDataAdapter(command);
                    da.Fill(data);
                    connection.Close();
                }
                return data;
            }
        }

        private void menuItem_ChonBang_DanhSachPhuHuynhHenGoiLai_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ChonBang_DanhSachPhuHuynhChuaLienLac_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ChonBang_DanhSachPhuHuynhDKOnline_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ChonBang_DanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            gb_lopChuaGiao.Hide();
            gb_lopDaGiao.Hide();
            gb_lopDaHuy.Hide();
            gb_lopDangGiao.Hide();
            gb_phuHuynhDaLienLac.Hide();
            gb_hocSinh.Hide();
            gb_giaoVien.Show();
        }

        private void menuItem_ChonBang_DanhSachSinhVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ChonBang_GiaSuNoPhi_Click(object sender, EventArgs e)
        {

        }

        #region Thêm Dữ Liệu
        private void bt_lopDangGiaoThem_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_lopChuaGiaoThem_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bt_lopDaGiaoThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                string delete = "delete from [lớp đang giao] where [lớp đang giao].[mã lớp]= [lớp đã giao].[mã lớp]";
                SqlCommand deletecmd = new SqlCommand(delete, connection);
                deletecmd.CommandType = CommandType.Text;
                deletecmd.ExecuteNonQuery();
                AllDataSet.dgvLopDangGiao();
                connection.Close();
            }
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bt_lopDaHuyThem_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_daLienLacThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                int currentIndex = dgv_phuHuynhDaLienLac.CurrentCell.RowIndex;
                string maPH =
                Convert.ToString(dgv_phuHuynhDaLienLac.Rows[currentIndex].Cells[0].Value.ToString());
                string hoTen =
                    Convert.ToString(dgv_phuHuynhDaLienLac.Rows[currentIndex].Cells[1].Value.ToString());
                string soDienThoai =
                    Convert.ToString(dgv_phuHuynhDaLienLac.Rows[currentIndex].Cells[2].Value.ToString());
                string diaChi =
                    Convert.ToString(dgv_phuHuynhDaLienLac.Rows[currentIndex].Cells[3].Value.ToString());
                string maNV =
                    Convert.ToString(dgv_phuHuynhDaLienLac.Rows[currentIndex].Cells[4].Value.ToString());
                string insertStr = "insert into [TT Phụ Huynh Đã Liên Lạc] values ('PH" + maPH + "','" + hoTen + "','" + soDienThoai +
                    "','" + diaChi + "','" + maNV + "')";
                string insert = "INSERT into [TT Học Sinh] ([Mã PH], [Mã HS]) VALUES ('PH" + maPH + "', 'HS" + maPH + "')";
                string insertMaHs = " insert into [Lớp chưa giao]([mã HS]) values('HS" + maPH + "')";
                SqlCommand insertCmd = new SqlCommand(insertStr, connection);
                SqlCommand insertCmd1 = new SqlCommand(insert, connection);
                SqlCommand command1 = new SqlCommand(insertMaHs, connection);
                insertCmd.CommandType = CommandType.Text;
                insertCmd.ExecuteNonQuery();
                insertCmd1.CommandType = CommandType.Text;
                insertCmd1.ExecuteNonQuery();
                command1.CommandType = CommandType.Text;
                command1.ExecuteNonQuery();
                AllDataSet.dgvTTPhuHuynhDaLienLac();
                AllDataSet.dgvTTHocSinh();
                AllDataSet.dgvLopChuaGiao();
                MessageBox.Show("Thêm dữ liệu thành công!!!");
                connection.Close();
            }
        }

        private void bt_hocSinhThem_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_giaoVienThem_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables[0]);
                MessageBox.Show("Cập Nhật Thành Công!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_giaoVienLuu_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Duyệt Dữ Liệu
        private void tb_giaoVien_TextChanged(object sender, EventArgs e)
        {
            if (cb_giaoVien.Text == "Môn")
            {
                da = new SqlDataAdapter("select * from [TT Giáo viên] where [Môn] like '" + tb_giaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_giaoVien.DataSource = dt;
            }
            else if (cb_giaoVien.Text == "Mã GV")
            {
                da = new SqlDataAdapter("select * from [TT giáo viên] where [mã GV] like'GV" + tb_giaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_giaoVien.DataSource = dt;
            }
            else if (cb_giaoVien.Text == "Họ Và Tên")
            {
                da = new SqlDataAdapter(string.Format("select * from [TT Giáo Viên] where [Họ Và Tên] like N'%{0}%'", tb_giaoVien.Text), con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_giaoVien.DataSource = dt;
            }
            else if (cb_giaoVien.Text == "Lớp")
            {
                da = new SqlDataAdapter("select * from [TT Giáo Viên] where [Lớp] like'" + tb_giaoVien.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_giaoVien.DataSource = dt;
            }
        }

        private void tb_lopDaGiao_TextChanged(object sender, EventArgs e)
        {
            if (cb_lopDaGiao.Text == "Mã Lớp")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Giao] where [mã lớp] like '" + tb_lopDaGiao.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaGiao.DataSource = dt;

            }
            else if (cb_lopDaGiao.Text == "Mã HS")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Giao] where [mã Hs] like'HS" + tb_lopDaGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaGiao.DataSource = dt;
            }
            else if (cb_lopDaGiao.Text == "Mã GV")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Giao] where [mã GV] like'GV" + tb_lopDaGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaGiao.DataSource = dt; ;
            }
            else if (cb_lopDaGiao.Text == "Mã SV")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Giao] where [mã SV] like'SV" + tb_lopDaGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaGiao.DataSource = dt;
            }
        }

        private void tb_lopDangGiao_TextChanged(object sender, EventArgs e)
        {
            if (cb_lopDangGiao.Text == "[Mã Lớp]")
            {
                da = new SqlDataAdapter("select * from [Lớp Đang Giao] where [mã lớp] like '" + tb_lopDangGiao.Text + "'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDangGiao.DataSource = dt;
            }
            else if (cb_lopDangGiao.Text == "[Mã HS]")
            {
                da = new SqlDataAdapter("select * from [Lớp Đang Giao] where [mã Hs] like'HS" + tb_lopDangGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDangGiao.DataSource = dt;
            }
            else if (cb_lopDangGiao.Text == "[Mã GV]")
            {
                da = new SqlDataAdapter("select * from [Lớp Đang Giao] where [mã GV] like'GV" + tb_lopDangGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDangGiao.DataSource = dt;

            }
            else if (cb_lopDangGiao.Text == "[Mã SV]")
            {

                da = new SqlDataAdapter("select * from [Lớp Đang Giao] where [mã SV] like'SV" + tb_lopDangGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDangGiao.DataSource = dt;
            }
        }

        private void tb_lopDaHuy_TextChanged(object sender, EventArgs e)
        {
            if (cb_lopDaHuy.Text == "Mã Lớp")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Hủy] where [mã lớp] like '" + tb_lopDaHuy.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaHuy.DataSource = dt;
            }
            else if (cb_lopDaHuy.Text == "Mã HS")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Hủy] where [mã Hs] like'HS" + tb_lopDaHuy.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaHuy.DataSource = dt;
            }
            else if (cb_lopDaHuy.Text == "Mã GV")

            {
                da = new SqlDataAdapter("select * from [Lớp Đã Hủy] where [mã GV] like'GV" + tb_lopDaHuy.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaHuy.DataSource = dt;
            }
            else if (cb_lopDaHuy.Text == "Mã SV")
            {
                da = new SqlDataAdapter("select * from [Lớp Đã Hủy] where [mã SV] like'SV" + tb_lopDaHuy.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopDaHuy.DataSource = dt;
            }
        }

        private void tb_lopChuaGiao_TextChanged(object sender, EventArgs e)
        {
            if (cb_lopChuaGiao.Text == "Mã Lớp")
            {
                da = new SqlDataAdapter("select * from [Lớp Chua Giao] where [mã lớp] like '" + tb_lopChuaGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopChuaGiao.DataSource = dt;

            }
            else if (cb_lopChuaGiao.Text == "Mã HS")
            {
                da = new SqlDataAdapter("select * from [Lớp Chua Giao] where [mã Hs] like'HS" + tb_lopChuaGiao.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_lopChuaGiao.DataSource = dt;
            }
        }

        private void tb_hocSinh_TextChanged(object sender, EventArgs e)
        {
            if (cb_hocSinh.Text == "Mã PH")
            {
                da = new SqlDataAdapter("select * from [TT Học Sinh] where [mã PH] like 'PH" + tb_hocSinh.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hocSinh.DataSource = dt;

            }
            else if (cb_hocSinh.Text == "Mã HS")
            {
                da = new SqlDataAdapter("select * from [TT Học Sinh] where [mã Hs] like'HS" + tb_hocSinh.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hocSinh.DataSource = dt;
            }
            else if (cb_hocSinh.Text == "Họ Và Tên")
            {
                da = new SqlDataAdapter("select * from [TT Học Sinh] where [Họ Và Tên] like'" + tb_hocSinh.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hocSinh.DataSource = dt;

            }
            else if (cb_hocSinh.Text == "Lớp")
            {
                da = new SqlDataAdapter("select * from [TT Học Sinh] where [Lớp] like'" + tb_hocSinh.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hocSinh.DataSource = dt;
            }
            else if (cb_hocSinh.Text == "Môn")
            {
                da = new SqlDataAdapter("select * from [TT Học Sinh] where [Môn] like'" + tb_hocSinh.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_hocSinh.DataSource = dt;
            }
        }

        private void tb_daLienLac_TextChanged(object sender, EventArgs e)
        {
            if (cb_daLienLac.Text == "Mã PH")
            {
                da = new SqlDataAdapter("select*from [TT Phụ Huynh Đã Liên Lạc] where [Mã PH] like 'PH" + tb_daLienLac.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_phuHuynhDaLienLac.DataSource = dt;
            }
            else if (cb_daLienLac.Text == "Họ Và Tên")
            {
                da = new SqlDataAdapter("select*from [TT Phụ Huynh Đã Liên Lạc] where [Họ Và Tên] like '" + tb_daLienLac.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dgv_phuHuynhDaLienLac.DataSource = dt;
            }
        }
        #endregion

        #region Xóa Dữ Liệu 
        private void bt_lopDaGiaoXoa_Click(object sender, EventArgs e)
        {

        }

        private void bt_hocSinhXoa_Click(object sender, EventArgs e)
        {

        }
        private void bt_daLienLacXoa_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void bt_chuyen_Click(object sender, EventArgs e)
        {

        }

        private void bt_chuyenHS_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormTrangChu());
        }

        private void menuItem_DanhSachLopChuaGiao_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DanhSachLopDaGiao_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DanhSachLopHuy_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DanhSachLopDangGiao_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DanhSachNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_SoDiemDanhNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_HopDongNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_BaoCaoNgay_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_LoiNhuan_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_GiaSuNoPhi_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ThongTinCaNhan_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_CapNhatHoSoNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_DanhSachHocSinh_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_PhuHuynhDaLienLac_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_PhuHuynhHenGoiLai_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_PhuHuynhChuaLienLac_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_PhuHuynhDKOnline_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_NV001_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_NV002_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_NV003_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_NV004_Click(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormTrangChu());
        }
    }
}
