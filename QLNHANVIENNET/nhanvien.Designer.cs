namespace QLNHANVIENNET
{
    partial class frmnhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghidulieu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblloi = new System.Windows.Forms.Label();
            this.lblthanhcong = new System.Windows.Forms.Label();
            this.lbltongso = new System.Windows.Forms.Label();
            this.dgvNhanvien = new System.Windows.Forms.DataGridView();
            this.txtIDNhanVien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenTKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoiCap = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtIDChucVu = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtSoCCCD = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtIDPhongBan = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployee
            // 
            this.txtEmployee.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(100, 21);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(318, 23);
            this.txtEmployee.TabIndex = 30;
            this.txtEmployee.TextChanged += new System.EventHandler(this.txtEmployee_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tìm Kiếm :";
            // 
            // btnhuybo
            // 
            this.btnhuybo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuybo.Location = new System.Drawing.Point(504, 411);
            this.btnhuybo.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(64, 31);
            this.btnhuybo.TabIndex = 27;
            this.btnhuybo.Text = "Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            // 
            // btnghidulieu
            // 
            this.btnghidulieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnghidulieu.Location = new System.Drawing.Point(374, 411);
            this.btnghidulieu.Margin = new System.Windows.Forms.Padding(2);
            this.btnghidulieu.Name = "btnghidulieu";
            this.btnghidulieu.Size = new System.Drawing.Size(108, 31);
            this.btnghidulieu.TabIndex = 26;
            this.btnghidulieu.Text = "Ghi dữ liệu";
            this.btnghidulieu.UseVisualStyleBackColor = true;
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(282, 411);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 31);
            this.btnxoa.TabIndex = 24;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(188, 411);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(64, 31);
            this.btnsua.TabIndex = 22;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(100, 411);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(64, 31);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // lblloi
            // 
            this.lblloi.AutoSize = true;
            this.lblloi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloi.ForeColor = System.Drawing.Color.Red;
            this.lblloi.Location = new System.Drawing.Point(220, 52);
            this.lblloi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloi.Name = "lblloi";
            this.lblloi.Size = new System.Drawing.Size(28, 17);
            this.lblloi.TabIndex = 17;
            this.lblloi.Text = "Lỗi";
            // 
            // lblthanhcong
            // 
            this.lblthanhcong.AutoSize = true;
            this.lblthanhcong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhcong.Location = new System.Drawing.Point(343, 52);
            this.lblthanhcong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthanhcong.Name = "lblthanhcong";
            this.lblthanhcong.Size = new System.Drawing.Size(83, 17);
            this.lblthanhcong.TabIndex = 15;
            this.lblthanhcong.Text = "Thành Công";
            // 
            // lbltongso
            // 
            this.lbltongso.AutoSize = true;
            this.lbltongso.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongso.Location = new System.Drawing.Point(10, 52);
            this.lbltongso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltongso.Name = "lbltongso";
            this.lbltongso.Size = new System.Drawing.Size(126, 17);
            this.lbltongso.TabIndex = 14;
            this.lbltongso.Text = "Tổng số : 0 Bản ghi";
            // 
            // dgvNhanvien
            // 
            this.dgvNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanvien.Location = new System.Drawing.Point(10, 88);
            this.dgvNhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(618, 122);
            this.dgvNhanvien.TabIndex = 12;
            this.dgvNhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanvien_CellContentClick);
            // 
            // txtIDNhanVien
            // 
            this.txtIDNhanVien.Location = new System.Drawing.Point(125, 231);
            this.txtIDNhanVien.Name = "txtIDNhanVien";
            this.txtIDNhanVien.Size = new System.Drawing.Size(159, 20);
            this.txtIDNhanVien.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "ID nhân viên:";
            // 
            // txtTenTKhoan
            // 
            this.txtTenTKhoan.Location = new System.Drawing.Point(133, 257);
            this.txtTenTKhoan.Name = "txtTenTKhoan";
            this.txtTenTKhoan.Size = new System.Drawing.Size(151, 20);
            this.txtTenTKhoan.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tên tài khoản:";
            // 
            // txtNoiCap
            // 
            this.txtNoiCap.Location = new System.Drawing.Point(414, 234);
            this.txtNoiCap.Name = "txtNoiCap";
            this.txtNoiCap.Size = new System.Drawing.Size(209, 20);
            this.txtNoiCap.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(334, 234);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(62, 17);
            this.label22.TabIndex = 37;
            this.label22.Text = "Nơi cấp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(83, 279);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(201, 20);
            this.txtHoTen.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Họ tên:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(449, 279);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(173, 20);
            this.txtSDT.TabIndex = 42;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(333, 278);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 17);
            this.label23.TabIndex = 41;
            this.label23.Text = "Số điện thoại:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Location = new System.Drawing.Point(109, 305);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(175, 20);
            this.dtpNgaySinh.TabIndex = 44;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 17);
            this.label17.TabIndex = 43;
            this.label17.Text = "Ngày sinh:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(397, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 20);
            this.txtEmail.TabIndex = 46;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(334, 303);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(50, 17);
            this.label24.TabIndex = 45;
            this.label24.Text = "Email:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(12, 335);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 47;
            this.label18.Text = "Giới tính:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(407, 330);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(215, 20);
            this.txtDiaChi.TabIndex = 51;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(334, 331);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 17);
            this.label25.TabIndex = 50;
            this.label25.Text = "Địa chỉ:";
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(97, 362);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(184, 20);
            this.txtQueQuan.TabIndex = 53;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(12, 362);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 17);
            this.label19.TabIndex = 52;
            this.label19.Text = "Quê quán:";
            // 
            // txtIDChucVu
            // 
            this.txtIDChucVu.Location = new System.Drawing.Point(442, 360);
            this.txtIDChucVu.Name = "txtIDChucVu";
            this.txtIDChucVu.Size = new System.Drawing.Size(180, 20);
            this.txtIDChucVu.TabIndex = 55;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(335, 361);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(89, 17);
            this.label26.TabIndex = 54;
            this.label26.Text = "ID Chức vụ:";
            // 
            // txtSoCCCD
            // 
            this.txtSoCCCD.Location = new System.Drawing.Point(97, 389);
            this.txtSoCCCD.Name = "txtSoCCCD";
            this.txtSoCCCD.Size = new System.Drawing.Size(184, 20);
            this.txtSoCCCD.TabIndex = 57;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 389);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 17);
            this.label20.TabIndex = 56;
            this.label20.Text = "Số CCCD:";
            // 
            // txtIDPhongBan
            // 
            this.txtIDPhongBan.Location = new System.Drawing.Point(454, 391);
            this.txtIDPhongBan.Name = "txtIDPhongBan";
            this.txtIDPhongBan.Size = new System.Drawing.Size(168, 20);
            this.txtIDPhongBan.TabIndex = 59;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(335, 390);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(102, 17);
            this.label27.TabIndex = 58;
            this.label27.Text = "ID Phòng ban:";
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(100, 336);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(181, 20);
            this.txtGioitinh.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Ngày cấp:";
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.Location = new System.Drawing.Point(414, 257);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(208, 20);
            this.dtpNgayCap.TabIndex = 62;
            // 
            // frmnhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.dtpNgayCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGioitinh);
            this.Controls.Add(this.txtIDPhongBan);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtSoCCCD);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtIDChucVu);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtQueQuan);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNoiCap);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtTenTKhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDNhanVien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnhuybo);
            this.Controls.Add(this.btnghidulieu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lblloi);
            this.Controls.Add(this.lblthanhcong);
            this.Controls.Add(this.lbltongso);
            this.Controls.Add(this.dgvNhanvien);
            this.Name = "frmnhanvien";
            this.Text = "Quan ly nhan vien";
            this.Load += new System.EventHandler(this.frmnhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghidulieu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblloi;
        private System.Windows.Forms.Label lblthanhcong;
        private System.Windows.Forms.Label lbltongso;
        private System.Windows.Forms.DataGridView dgvNhanvien;
        private System.Windows.Forms.TextBox txtIDNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenTKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoiCap;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtIDChucVu;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtSoCCCD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtIDPhongBan;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
    }
}