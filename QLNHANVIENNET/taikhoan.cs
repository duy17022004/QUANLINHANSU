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
    public partial class taikhoan : Form
    {
        public taikhoan()
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
            switch (State)
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
            con = new SqlConnection(sconn);

            try
            {
                con.Open();
                string sql = "SELECT * FROM TaiKhoan ORDER BY Ten_TKhoan";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTaiKhoan.DataSource = dt;
                lbltongso.Text = "Tổng số: " + dt.Rows.Count + " tài khoản.";
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

        private bool CheckIfUsernameExists(string tenTK)
        {
            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE Ten_TKhoan = @TenTK";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);

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
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string loaiTK = cbaccount.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(loaiTK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            if (CheckIfUsernameExists(tenTK))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập tên khác!", "Thông báo");
                return;
            }

            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "INSERT INTO TaiKhoan (Ten_TKhoan, Mat_Khau, Loai_TKhoan) VALUES (@TenTK, @MatKhau, @LoaiTK)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@LoaiTK", loaiTK);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản thất bại!", "Thông báo");
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string loaiTK = cbaccount.SelectedItem?.ToString(); // Lấy giá trị từ ComboBox

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau) || string.IsNullOrEmpty(loaiTK))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "UPDATE TaiKhoan SET Mat_Khau = @MatKhau, Loai_TKhoan = @LoaiTK WHERE Ten_TKhoan = @TenTK";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);
                cmd.Parameters.AddWithValue("@MatKhau", matKhau);
                cmd.Parameters.AddWithValue("@LoaiTK", loaiTK);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Sửa tài khoản thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Sửa tài khoản thất bại!", "Thông báo");
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
            string tenTK = txtTenTK.Text.Trim();

            if (string.IsNullOrEmpty(tenTK))
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa!", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "DELETE FROM TaiKhoan WHERE Ten_TKhoan = @TenTK";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenTK", tenTK);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại!", "Thông báo");
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

        private void txtAccountKey_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtAccountKey.Text.Trim();

            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "SELECT * FROM TaiKhoan WHERE Ten_TKhoan LIKE N'%" + keyword + "%' OR Loai_TKhoan LIKE N'%" + keyword + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTaiKhoan.DataSource = dt;
                lbltongso.Text = "Tìm thấy: " + dt.Rows.Count + " tài khoản.";
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

        private void taikhoan_Load(object sender, EventArgs e)
        {
            // Thêm các mục vào ComboBox
            cbaccount.Items.Add("admin");
            cbaccount.Items.Add("nhân viên");

            // Đặt mục mặc định (không bắt buộc)
            cbaccount.SelectedIndex = 0;
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTaiKhoan.Rows[e.RowIndex];
                txtTenTK.Text = row.Cells["Ten_TKhoan"].Value.ToString();
                txtMatKhau.Text = row.Cells["Mat_Khau"].Value.ToString();

                // Đặt ComboBox theo giá trị Loai_TKhoan
                string loaiTK = row.Cells["Loai_TKhoan"].Value.ToString();
                cbaccount.SelectedItem = loaiTK; // Đảm bảo giá trị trong ComboBox phù hợp
            }
        }
    }
}
