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
    public partial class frmnhanvien : Form
    {
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

        public frmnhanvien()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();
        }

        public void GetData()
        {
            // Chuỗi kết nối đến cơ sở dữ liệu
            con = new SqlConnection(sconn);

            try
            {
                con.Open(); // Mở kết nối

                // Câu truy vấn để lấy dữ liệu từ bảng NhanVien
                string sql = "SELECT * FROM NhanVien ORDER BY Ho_Ten";

                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);  // Điền dữ liệu vào DataTable
                dgvNhanvien.DataSource = dt;  // Cập nhật dữ liệu trong DataGridView
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

        private bool CheckIfIDExists(string idNhanVien)
        {
            con = new SqlConnection(sconn);
            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM NhanVien WHERE ID_NhanVien = @ID_NhanVien";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID_NhanVien", idNhanVien);

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


        private void txtEmployee_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtEmployee.Text.Trim();

            con = new SqlConnection(sconn);
            try
            {
                if (con.State != ConnectionState.Open) con.Open();
                // Truy vấn để tìm kiếm các bản ghi phù hợp với từ khóa
                string sql = "SELECT * FROM NhanVien WHERE " +
                     "ID_NhanVien LIKE N'%" + keyword + "%' OR " +
                     "Ten_TKhoan LIKE N'%" + keyword + "%' OR " +
                     "Ho_Ten LIKE N'%" + keyword + "%' OR " +
                     "Ngay_Sinh LIKE N'%" + keyword + "%' OR " +
                     "Gioi_Tinh LIKE N'%" + keyword + "%' OR " +
                     "Que_Quan LIKE N'%" + keyword + "%' OR " +
                     "So_CCCD LIKE N'%" + keyword + "%' OR " +
                     "Noi_Cap LIKE N'%" + keyword + "%' OR " +
                     "SDT LIKE N'%" + keyword + "%' OR " +
                     "Email LIKE N'%" + keyword + "%' OR " +
                     "Dia_Chi LIKE N'%" + keyword + "%' OR " +
                     "ID_Chuc_Vu LIKE N'%" + keyword + "%' OR " +
                     "ID_PhongBan LIKE N'%" + keyword + "%'";
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Hiển thị kết quả tìm kiếm trong DataGridView
                dgvNhanvien.DataSource = dt;

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

        private void frmnhanvien_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // Lấy các giá trị từ các TextBox và DateTimePicker
            string idNhanVien = txtIDNhanVien.Text.Trim();
            string tenTKhoan = txtTenTKhoan.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value; // Lấy giá trị từ DateTimePicker
            string gioiTinh = txtGioitinh.Text.Trim(); // Lấy giá trị giới tính từ TextBox
            string queQuan = txtQueQuan.Text.Trim();
            string soCCCD = txtSoCCCD.Text.Trim();
            string noiCap = txtNoiCap.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string idChucVu = txtIDChucVu.Text.Trim();
            string idPhongBan = txtIDPhongBan.Text.Trim();
            DateTime ngayCap = dtpNgayCap.Value; // Lấy ngày cấp từ DateTimePicker

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(idNhanVien) || string.IsNullOrEmpty(tenTKhoan) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập ID nhân viên, tên tài khoản và họ tên!", "Thông báo");
                return;
            }

            // Kiểm tra ID nhân viên đã tồn tại chưa
            if (CheckIfIDExists(idNhanVien))
            {
                MessageBox.Show("ID nhân viên đã tồn tại. Vui lòng nhập ID khác!", "Thông báo");
                return;
            }

            // Khởi tạo kết nối SQL
            con = new SqlConnection(sconn);
            try
            {
                con.Open();

                // Truy vấn SQL để thêm nhân viên vào bảng NhanVien
                string sql = "INSERT INTO NhanVien (ID_NhanVien, Ten_TKhoan, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Que_Quan, So_CCCD, Noi_Cap, SDT, Email, Dia_Chi, ID_Chuc_Vu, ID_PhongBan, Ngay_Cap) " +
                             "VALUES (@ID_NhanVien, @Ten_TKhoan, @Ho_Ten, @Ngay_Sinh, @Gioi_Tinh, @Que_Quan, @So_CCCD, @Noi_Cap, @SDT, @Email, @Dia_Chi, @ID_Chuc_Vu, @ID_PhongBan, @Ngay_Cap)";

                // Tạo đối tượng SqlCommand và thêm các tham số
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@ID_NhanVien", idNhanVien);
                cmd.Parameters.AddWithValue("@Ten_TKhoan", tenTKhoan);
                cmd.Parameters.AddWithValue("@Ho_Ten", hoTen);
                cmd.Parameters.AddWithValue("@Ngay_Sinh", ngaySinh);
                cmd.Parameters.AddWithValue("@Gioi_Tinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Que_Quan", queQuan);
                cmd.Parameters.AddWithValue("@So_CCCD", soCCCD);
                cmd.Parameters.AddWithValue("@Noi_Cap", noiCap);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Dia_Chi", diaChi);
                cmd.Parameters.AddWithValue("@ID_Chuc_Vu", idChucVu);
                cmd.Parameters.AddWithValue("@ID_PhongBan", idPhongBan);
                cmd.Parameters.AddWithValue("@Ngay_Cap", ngayCap); // Thêm tham số Ngày Cấp

                // Thực thi câu lệnh
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                    GetData();  // Cập nhật dữ liệu sau khi thêm

                    // Xóa trắng các trường nhập liệu sau khi thêm thành công
                    txtIDNhanVien.Clear();
                    txtTenTKhoan.Clear();
                    txtHoTen.Clear();
                    dtpNgaySinh.Value = DateTime.Now; // Đặt lại ngày sinh về ngày hiện tại
                    txtGioitinh.Clear(); // Xóa trường giới tính
                    txtQueQuan.Clear();
                    txtSoCCCD.Clear();
                    txtNoiCap.Clear();
                    txtSDT.Clear();
                    txtEmail.Clear();
                    txtDiaChi.Clear();
                    txtIDChucVu.Clear();
                    txtIDPhongBan.Clear();
                    dtpNgayCap.Value = DateTime.Now; // Đặt lại ngày cấp về ngày hiện tại
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Thông báo");
            }
            finally
            {
                // Đảm bảo đóng kết nối
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            // Kiểm tra nếu index là hợp lệ (không phải dòng tiêu đề hoặc ngoài phạm vi).
            if (index >= 0)
            {
                DataGridViewRow selectedRow = dgvNhanvien.Rows[index];

                txtIDNhanVien.Text = selectedRow.Cells["ID_NhanVien"].Value?.ToString() ?? "";
                txtTenTKhoan.Text = selectedRow.Cells["Ten_TKhoan"].Value?.ToString() ?? "";
                txtHoTen.Text = selectedRow.Cells["Ho_Ten"].Value?.ToString() ?? "";
                dtpNgaySinh.Value = DateTime.TryParse(selectedRow.Cells["Ngay_Sinh"].Value?.ToString(), out DateTime ngaySinh) ? ngaySinh : DateTime.Now;
                txtGioitinh.Text = selectedRow.Cells["Gioi_Tinh"].Value?.ToString() ?? "";
                txtQueQuan.Text = selectedRow.Cells["Que_Quan"].Value?.ToString() ?? "";
                txtSoCCCD.Text = selectedRow.Cells["So_CCCD"].Value?.ToString() ?? "";
                txtNoiCap.Text = selectedRow.Cells["Noi_Cap"].Value?.ToString() ?? "";
                txtSDT.Text = selectedRow.Cells["SDT"].Value?.ToString() ?? "";
                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";
                txtDiaChi.Text = selectedRow.Cells["Dia_Chi"].Value?.ToString() ?? "";
                txtIDChucVu.Text = selectedRow.Cells["ID_Chuc_Vu"].Value?.ToString() ?? "";
                txtIDPhongBan.Text = selectedRow.Cells["ID_PhongBan"].Value?.ToString() ?? "";
                dtpNgayCap.Value = DateTime.TryParse(selectedRow.Cells["Ngay_Cap"].Value?.ToString(), out DateTime ngayCap) ? ngayCap : DateTime.Now;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string idNhanVien = txtIDNhanVien.Text.Trim();
            string tenTKhoan = txtTenTKhoan.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string gioiTinh = txtGioitinh.Text.Trim();
            string queQuan = txtQueQuan.Text.Trim();
            string soCCCD = txtSoCCCD.Text.Trim();
            string noiCap = txtNoiCap.Text.Trim();
            string sdt = txtSDT.Text.Trim();
            string email = txtEmail.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();
            string idChucVu = txtIDChucVu.Text.Trim();
            string idPhongBan = txtIDPhongBan.Text.Trim();
            string ngayCap = dtpNgayCap.Value.ToString("yyyy-MM-dd");

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(idNhanVien) || string.IsNullOrEmpty(tenTKhoan) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi sửa!", "Thông báo");
                return;
            }

            SqlConnection con = new SqlConnection(sconn);
            try
            {
                con.Open();

                // Sử dụng parameterized query để tránh SQL Injection
                string sql = @"UPDATE NhanVien SET 
                        Ten_TKhoan = @TenTKhoan, 
                        Ho_Ten = @HoTen, 
                        Ngay_Sinh = @NgaySinh, 
                        Gioi_Tinh = @GioiTinh, 
                        Que_Quan = @QueQuan, 
                        So_CCCD = @SoCCCD, 
                        Noi_Cap = @NoiCap, 
                        SDT = @SDT, 
                        Email = @Email, 
                        Dia_Chi = @DiaChi, 
                        ID_Chuc_Vu = @IDChucVu, 
                        ID_PhongBan = @IDPhongBan, 
                        Ngay_Cap = @NgayCap 
                      WHERE ID_NhanVien = @IDNhanVien";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@TenTKhoan", tenTKhoan);
                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@QueQuan", queQuan);
                cmd.Parameters.AddWithValue("@SoCCCD", soCCCD);
                cmd.Parameters.AddWithValue("@NoiCap", noiCap);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@IDChucVu", idChucVu);
                cmd.Parameters.AddWithValue("@IDPhongBan", idPhongBan);
                cmd.Parameters.AddWithValue("@NgayCap", ngayCap);
                cmd.Parameters.AddWithValue("@IDNhanVien", idNhanVien);

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
            string idNhanVien = txtIDNhanVien.Text.Trim();

            // Kiểm tra xem ID có được nhập không
            if (string.IsNullOrEmpty(idNhanVien))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!", "Thông báo");
                return;
            }

            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QL_NHANVIEN_NET;Integrated Security=True");

            try
            {
                con.Open();

                // Sử dụng parameterized query để tránh SQL Injection
                string sql = "DELETE FROM NhanVien WHERE ID_NhanVien = @IDNhanVien";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@IDNhanVien", idNhanVien);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    GetData(); // Cập nhật lại DataGridView
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Không tìm thấy nhân viên cần xóa.", "Thông báo");
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
    }
}
