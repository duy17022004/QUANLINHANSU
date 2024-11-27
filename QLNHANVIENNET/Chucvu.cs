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

namespace QLNHANVIENNET
{
    public partial class frmchucvu : Form
    {
        public frmchucvu()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();
        }
        SqlConnection con = null;
        string sconn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHANVIEN_NET;Integrated Security=True";
        #region Public Functions
        public void SetControl(string State)
        {
            switch(State)
            {
                case "Reset":
                    btnthem.Enabled = true;
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true; 
                    btnghidulieu.Enabled = false;
                    btnhuybo.Enabled = true;
                 
                    lbltongso.Text = "";
                    lblloi.Text = " ";
                    lblthanhcong.Text = " ";
                    break;
                default:
                    break;
            }
        }

        #endregion
        public void GetData()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            con = new SqlConnection(sconn);

            try
            {
                con.Open(); // Mở kết nối

                // Câu truy vấn để lấy dữ liệu từ bảng ChucVu
                string sql = "SELECT * FROM ChucVu ORDER BY Ten_ChucVu";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);  // Điền dữ liệu vào DataTable
                dgvChucVu.DataSource = dt;  // Cập nhật dữ liệu trong DataGridView
                // Hiển thị tổng số bản ghi
                lbltongso.Text = "Tổng số : " + dt.Rows.Count + " Bản ghi";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }
        private bool CheckIfIDExists(string idChucVu)
        {
            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM ChucVu WHERE ID_ChucVu = @ID_ChucVu";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID_ChucVu", idChucVu);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kiểm tra: {ex.Message}", "Thông báo");
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
       
            string idChucVu = txtIDChucVu.Text.Trim();
            string maChucVu = txtMaChucVu.Text.Trim();
            string tenChucVu = txtTenChucVu.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();
            
            txtMaChucVu.Focus();
            if (string.IsNullOrEmpty(idChucVu) || string.IsNullOrEmpty(maChucVu) || string.IsNullOrEmpty(tenChucVu))
            {
                MessageBox.Show("Vui lòng nhập ID, mã và tên chức vụ!", "Thông báo");
                return;
            }

            if (CheckIfIDExists(idChucVu))
            {
                MessageBox.Show("ID chức vụ đã tồn tại. Vui lòng nhập ID khác!", "Thông báo");
                return;
            }

            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "INSERT INTO ChucVu (ID_ChucVu, Ma_ChucVu, Ten_ChucVu, Ghi_Chu) VALUES ('" + idChucVu + "', '" + maChucVu + "', '" + tenChucVu + "', '" + ghiChu + "')";

                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm chức vụ thành công!", "Thông báo");
                    GetData();  // Cập nhật dữ liệu sau khi thêm
                    txtIDChucVu.Clear();
                    txtMaChucVu.Clear();
                    txtTenChucVu.Clear();
                    txtGhiChu.Clear();
                }
                else
                {
                    MessageBox.Show("Thêm chức vụ thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvChucVu.Rows[index];
            txtIDChucVu.Text = selectedRow.Cells["ID_ChucVu"].Value.ToString();
            txtMaChucVu.Text = selectedRow.Cells["Ma_ChucVu"].Value.ToString();
            txtTenChucVu.Text = selectedRow.Cells["Ten_ChucVu"].Value.ToString();
            txtGhiChu.Text = selectedRow.Cells["Ghi_Chu"].Value.ToString();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string idChucVu = txtIDChucVu.Text.Trim();
            string maChucVu = txtMaChucVu.Text.Trim();
            string tenChucVu = txtTenChucVu.Text.Trim();
            string ghiChu = txtGhiChu.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(idChucVu) || string.IsNullOrEmpty(maChucVu) || string.IsNullOrEmpty(tenChucVu))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!", "Thông báo");
                return;
            }

            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "UPDATE ChucVu SET Ma_ChucVu = '" + maChucVu + "', Ten_ChucVu = '" + tenChucVu + "', Ghi_Chu = '" + ghiChu + "' WHERE ID_ChucVu = '" + idChucVu + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    GetData(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string idChucVu = txtIDChucVu.Text.Trim();

            // Kiểm tra xem ID có được nhập không
            if (string.IsNullOrEmpty(idChucVu))
            {
                MessageBox.Show("Vui lòng chọn bản ghi để xóa!", "Thông báo");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHANVIEN_NET;Integrated Security=True");

            try
            {
                con.Open();
                string sql = "DELETE FROM ChucVu WHERE ID_ChucVu = '" + idChucVu + "'";

                SqlCommand cmd = new SqlCommand(sql, con);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    GetData(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void btnhuybo_Click(object sender, EventArgs e)
        {
            
        }

        private void txtkeyword_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtkeyword.Text.Trim();

            con = new SqlConnection(sconn);
            try
            {
                if(con.State != ConnectionState.Open)   con.Open();
                // Truy vấn để tìm kiếm các bản ghi phù hợp với từ khóa
                string sql = "SELECT * FROM ChucVu WHERE Ten_ChucVu LIKE N'%" + keyword +"%' OR Ma_ChucVu LIKE N'%"+ keyword +"%'" +
                    "OR ID_ChucVu LIKE N'%"+ keyword +"%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                dgvChucVu.DataSource = dt;

                // Hiển thị tổng số bản ghi tìm thấy
                lbltongso.Text = "Tìm thấy: " + dt.Rows.Count + " bản ghi.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối hoặc thực thi truy vấn: {ex.Message}", "Thông báo");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }           
        }

        private void btntim_Click(object sender, EventArgs e)
        {

        }

        private void frmchucvu_Load(object sender, EventArgs e)
        {

        }

        private void txtIDChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenChucVu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
