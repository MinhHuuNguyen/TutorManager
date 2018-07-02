using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTTGS
{
    public partial class FormDaDangNhap : Form
    {

        public FormDaDangNhap()
        {
            InitializeComponent();
            gb_danhSachNhanVien.Hide();
            gb_hopDongNhanVien.Hide();
            gb_soDiemDanhNV.Hide();
            gb_danhSachHocSinh.Hide();
            gb_phuHuynhChuaLienLac.Hide();
            gb_phuHuynhHenGoiLai.Hide();
            gb_phuHuynh.Hide();
            gb_phuHuynhDKOnline.Hide();
            gb_luongNV004.Hide();
            gb_luongNV003.Hide();
            gb_luongNV002.Hide();
            gb_luongNV001.Hide();
            gb_danhSachLopDangGiao.Hide();
            gb_danhSachLopChuaGiao.Hide();
            gb_danhSachLopHuy.Hide();
            gb_danhSachLopDaGiao.Hide();
            gb_giaSuNoPhi.Hide();
            gb_loiNhuan.Hide();
            gb_baoCaoNgay.Hide();
            gb_giaoVien.Hide();
            gb_sinhVien.Hide();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormTrangChu());
        }

        private void menuItem_TrangChu_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormTrangChu());
        }

        #region Tra Cuu

        #region Danh Sach Lop Hoc
        private void menuItem_DanhSachLopChuaGiao_Click(object sender, EventArgs e)
        {
            dgv_danhSachLopChuaGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhSachLopChuaGiao.DataSource = AllDataSet.dgvLopChuaGiao().Tables[0];
            AllDataSet.dgvLopChuaGiao();
            gb_danhSachLopDangGiao.Hide();
            gb_danhSachLopChuaGiao.Show();
            gb_danhSachLopHuy.Hide();
            gb_danhSachLopDaGiao.Hide();
        }

        private void menuItem_DanhSachLopDaGiao_Click(object sender, EventArgs e)
        {
            dgv_danhSachLopDaGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhSachLopDaGiao.DataSource = dgvLopDaGiao().Tables[0];
            DataSet dgvLopDaGiao()
            {
                DataSet data = new DataSet();
                string query = "select * from  [Lớp Đã Giao]";
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);
                    connection.Close();
                }
                return data;
            }

            gb_danhSachLopDaGiao.Show();
            gb_danhSachLopChuaGiao.Hide();
            gb_danhSachLopDangGiao.Hide();
            gb_danhSachLopHuy.Hide();

        }

        private void menuItem_DanhSachLopHuy_Click(object sender, EventArgs e)
        {
            dgv_danhSachLopHuy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhSachLopHuy.DataSource = AllDataSet.dgvLopDaHuy().Tables[0];
            AllDataSet.dgvLopDaHuy();
            gb_danhSachLopHuy.Show();
            gb_danhSachLopChuaGiao.Hide();
            gb_danhSachLopDaGiao.Hide();
            gb_danhSachLopDangGiao.Hide();
        }

        private void menuItem_DanhSachLopDangGiao_Click(object sender, EventArgs e)
        {
            dgv_danhSachLopDangGiao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhSachLopDangGiao.DataSource = AllDataSet.dgvLopDangGiao().Tables[0];
            AllDataSet.dgvLopDangGiao();
            gb_danhSachLopHuy.Hide();
            gb_danhSachLopChuaGiao.Hide();
            gb_danhSachLopDangGiao.Show();
            gb_danhSachLopDaGiao.Hide();
        }
        #endregion

        #region Nhân Viên
        private void menuItem_DanhSachNhanVien_Click(object sender, EventArgs e)
        {
            dgv_danhSachNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhSachNhanVien.DataSource = AllDataSet.dgvTTNhanVien().Tables[0];
            AllDataSet.dgvTTNhanVien();
            gb_danhSachNhanVien.Show();
            gb_soDiemDanhNV.Hide();
            gb_hopDongNhanVien.Hide();
        }

        private void menuItem_SoDiemDanhNhanVien_Click(object sender, EventArgs e)
        {
            dgv_soDiemDanhNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_soDiemDanhNV.DataSource = AllDataSet.dgvSoDiemDanhNhanVien().Tables[0];
            AllDataSet.dgvSoDiemDanhNhanVien();
            gb_danhSachNhanVien.Hide();
            gb_soDiemDanhNV.Show();
            gb_hopDongNhanVien.Hide();
        }

        private void menuItem_HopDongNhanVien_Click(object sender, EventArgs e)
        {
            dgv_hopDongNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_hopDongNV.DataSource = AllDataSet.dgvHopDongNhanVien().Tables[0];
            AllDataSet.dgvHopDongNhanVien();
            gb_danhSachNhanVien.Hide();
            gb_soDiemDanhNV.Hide();
            gb_hopDongNhanVien.Show();
        }
        #endregion

        #region Báo Cáo
        private void menuItem_BaoCaoNgay_Click(object sender, EventArgs e)
        {
            dgv_baoCaoNgay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_baoCaoNgay.DataSource = AllDataSet.dgvBaoCaoNgay().Tables[0];
            AllDataSet.dgvBaoCaoNgay();
            gb_baoCaoNgay.Show();
            gb_loiNhuan.Hide();
            gb_giaSuNoPhi.Hide();
        }

        private void menuItem_LoiNhuan_Click(object sender, EventArgs e)
        {
            dgv_loiNhuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_loiNhuan.DataSource = AllDataSet.dgvLoiNhuan().Tables[0];
            AllDataSet.dgvLoiNhuan();
            gb_loiNhuan.Show();
            gb_baoCaoNgay.Hide();
            gb_giaSuNoPhi.Hide();
        }

        private void menuItem_GiaSuNoPhi_Click(object sender, EventArgs e)
        {
            dgv_giaSuNoPhi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_giaSuNoPhi.DataSource = AllDataSet.dgvGiaSuNoPhi().Tables[0];
            AllDataSet.dgvGiaSuNoPhi();
            gb_baoCaoNgay.Hide();
            gb_loiNhuan.Hide();
            gb_giaSuNoPhi.Show();
        }
        #endregion

        #region Gia Sư
        private void menuItem_DanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            dgv_giaoVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_giaoVien.DataSource = AllDataSet.dgvGiaoVien().Tables[0];
            AllDataSet.dgvGiaoVien();
            gb_sinhVien.Hide();
            gb_giaoVien.Show();
        }

        private void menuItem_DanhSachSinhVien_Click(object sender, EventArgs e)
        {
            dgv_sinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_sinhVien.DataSource = AllDataSet.dgvSinhVien().Tables[0];
            AllDataSet.dgvSinhVien();
            gb_sinhVien.Show();
            gb_giaoVien.Hide();
        }
        #endregion

        #endregion

        #region Thong Tin Nguoi Su Dung
        private void menuItem_YKienDongGop_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_ThongTinNguoiSuDung_Click(object sender, EventArgs e)
        {

        }

        private void menuItem_CapNhatHoSoNhanVien_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Thong Tin Phu Huynh Hoc Sinh
        private void menuItem_DanhSachHocSinh_Click(object sender, EventArgs e)
        {
            dgv_danhSachHocSinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_danhSachHocSinh.DataSource = AllDataSet.dgvTTHocSinh().Tables[0];
            AllDataSet.dgvTTHocSinh();
            gb_danhSachNhanVien.Hide();
            gb_hopDongNhanVien.Hide();
            gb_soDiemDanhNV.Hide();
            gb_danhSachHocSinh.Show();
            gb_phuHuynhChuaLienLac.Hide();
            gb_phuHuynhHenGoiLai.Hide();
            gb_phuHuynh.Hide();
            gb_phuHuynhDKOnline.Hide();
            gb_luongNV004.Hide();
            gb_luongNV003.Hide();
            gb_luongNV002.Hide();
            gb_luongNV001.Hide();
            gb_danhSachLopDangGiao.Hide();
            gb_danhSachLopChuaGiao.Hide();
            gb_danhSachLopHuy.Hide();
            gb_danhSachLopDaGiao.Hide();
            gb_giaSuNoPhi.Hide();
            gb_loiNhuan.Hide();
            gb_baoCaoNgay.Hide();
        }

        #region Phụ huynh
        private void menuItem_PhuHuynhDaLienLac_Click(object sender, EventArgs e)
        {
            {
                dgv_phuHuynh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv_phuHuynh.DataSource = AllDataSet.dgvTTPhuHuynhDaLienLac().Tables[0];
                AllDataSet.dgvTTPhuHuynhDaLienLac();
                gb_phuHuynh.Show();
                gb_phuHuynhDKOnline.Hide();
                gb_phuHuynhChuaLienLac.Hide();
                gb_phuHuynhHenGoiLai.Hide();
            }
        }

        private void menuItem_PhuHuynhHenGoiLai_Click(object sender, EventArgs e)
        {
            dgv_phuHuynhHenGoiLai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phuHuynhHenGoiLai.DataSource = AllDataSet.dgvTTPhuHuynhHenGoiLai().Tables[0];
            AllDataSet.dgvTTPhuHuynhHenGoiLai();
            gb_phuHuynh.Hide();
            gb_phuHuynhDKOnline.Hide();
            gb_phuHuynhChuaLienLac.Hide();
            gb_phuHuynhHenGoiLai.Show();
        }

        private void menuItem_PhuHuynhChuaLienLac_Click(object sender, EventArgs e)
        {
            dgv_phuHuynhChuaLienLac.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phuHuynhChuaLienLac.DataSource = AllDataSet.dgvTTPhuHuynhChuaLienLac().Tables[0];
            AllDataSet.dgvTTPhuHuynhChuaLienLac();
            gb_phuHuynh.Hide();
            gb_phuHuynhDKOnline.Hide();
            gb_phuHuynhChuaLienLac.Show();
            gb_phuHuynhHenGoiLai.Hide();
        }

        private void menuItem_PhuHuynhDKOnline_Click(object sender, EventArgs e)
        {
            dgv_phuHuynhDKOnline.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_phuHuynhDKOnline.DataSource = AllDataSet.dgvPhuHuynhDKOnline().Tables[0];
            AllDataSet.dgvPhuHuynhDKOnline();
            gb_phuHuynh.Hide();
            gb_phuHuynhDKOnline.Show();
            gb_phuHuynhChuaLienLac.Hide();
            gb_phuHuynhHenGoiLai.Hide();
        }
        #endregion
        #endregion

        #region Bang Luong
        private void menuItem_NV001_Click(object sender, EventArgs e)
        {
            dgv_luongNV001.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_luongNV001.DataSource = AllDataSet.dgvTTNhanVien().Tables[0];
            AllDataSet.dgvLuongN001();
            gb_luongNV001.Show();
            gb_luongNV002.Hide();
            gb_luongNV003.Hide();
            gb_luongNV004.Hide();
        }

        private void menuItem_NV002_Click(object sender, EventArgs e)
        {
            dgv_luongNV002.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_luongNV002.DataSource = AllDataSet.dgvLuongN002().Tables[0];
            AllDataSet.dgvLuongN002();
            gb_luongNV001.Hide();
            gb_luongNV002.Show();
            gb_luongNV003.Hide();
            gb_luongNV004.Hide();
        }

        private void menuItem_NV003_Click(object sender, EventArgs e)
        {
            dgv_luongNV003.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_luongNV003.DataSource = AllDataSet.dgvLuongN003().Tables[0];
            AllDataSet.dgvLuongN003();
            gb_luongNV001.Hide();
            gb_luongNV002.Hide();
            gb_luongNV003.Show();
            gb_luongNV004.Hide();
        }

        private void menuItem_NV004_Click(object sender, EventArgs e)
        {
            dgv_luongNV004.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_luongNV004.DataSource = AllDataSet.dgvLuongN004().Tables[0];
            AllDataSet.dgvLuongN004();
            gb_luongNV001.Hide();
            gb_luongNV002.Hide();
            gb_luongNV003.Hide();
            gb_luongNV004.Show();
        }
        #endregion

        private void btn_TuyChonChinhSua_Click(object sender, EventArgs e)
        {
            FormManager.ChangeForm(this, new FormTuyChonChinhSua());
        }

    }
}
