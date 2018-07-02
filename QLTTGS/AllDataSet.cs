using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLTTGS
{
    public class AllDataSet
    {
        public static DataSet dgvGiaSuNoPhi()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Nợ]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvLopChuaGiao()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Lớp Chưa Giao]";

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
        public static DataSet dgvLopDaGiao()
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
        public static DataSet dgvLopDaHuy()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Lớp Đã Hủy]";

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
        public static DataSet dgvLopDangGiao()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Lớp Đang Giao]";

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
        public static DataSet dgvTTHocSinh()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Học Sinh]";
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
        public static DataSet dgvTTPhuHuynhDaLienLac()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Phụ Huynh Đã Liên Lạc]";
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
        public static DataSet dgvPhuHuynhDKOnline()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Đăng Kí Lớp Học Online]";
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
        public static DataSet dgvTTNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Nhân Viên]";
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
        public static DataSet dgvHopDongNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Hợp Đồng Nhân Viên]";
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
        public static DataSet dgvBaoCaoNgay()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Báo Cáo Ngày]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvLoiNhuan()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Lợi Nhuận]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvLuongN001()
        {
            DataSet data = new DataSet();
            string query = "select * from  [LuongNV001]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvLuongN002()
        {
            DataSet data = new DataSet();
            string query = "select * from  [LuongNV002]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvLuongN003()
        {
            DataSet data = new DataSet();
            string query = "select * from  [LuongNV003]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvLuongN004()
        {
            DataSet data = new DataSet();
            string query = "select * from  [LuongNV004]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvTTPhuHuynhHenGoiLai()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Phụ Huynh Hẹn Gọi Lại]";
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
        public static DataSet dgvTTPhuHuynhChuaLienLac()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Phụ Huynh Chưa Liên Lạc]";
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
        public static DataSet dgvSoDiemDanhNhanVien()
        {
            DataSet data = new DataSet();
            string query = "select * from  [Sổ Điểm Danh]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvGiaoVien()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Giáo Viên]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        public static DataSet dgvSinhVien()
        {
            DataSet data = new DataSet();
            string query = "select * from  [TT Sinh Viên]";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
