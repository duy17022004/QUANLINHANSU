namespace QLNHANVIENNET
{
    partial class taikhoan
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
            this.txtAccountKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.btnghidulieu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lblloi = new System.Windows.Forms.Label();
            this.lblthanhcong = new System.Windows.Forms.Label();
            this.lbltongso = new System.Windows.Forms.Label();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cbaccount = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAccountKey
            // 
            this.txtAccountKey.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountKey.Location = new System.Drawing.Point(100, 21);
            this.txtAccountKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccountKey.Name = "txtAccountKey";
            this.txtAccountKey.Size = new System.Drawing.Size(318, 23);
            this.txtAccountKey.TabIndex = 30;
            this.txtAccountKey.TextChanged += new System.EventHandler(this.txtAccountKey_TextChanged);
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
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(10, 88);
            this.dgvTaiKhoan.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(618, 122);
            this.dgvTaiKhoan.TabIndex = 12;
            this.dgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellContentClick);
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(130, 222);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(185, 20);
            this.txtTenTK.TabIndex = 32;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label38.Location = new System.Drawing.Point(6, 222);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(118, 19);
            this.label38.TabIndex = 31;
            this.label38.Text = "Tên tài khoản:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(411, 223);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(217, 20);
            this.txtMatKhau.TabIndex = 34;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label37.Location = new System.Drawing.Point(321, 223);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(84, 19);
            this.label37.TabIndex = 33;
            this.label37.Text = "Mật khẩu:";
            // 
            // cbaccount
            // 
            this.cbaccount.FormattingEnabled = true;
            this.cbaccount.Location = new System.Drawing.Point(137, 253);
            this.cbaccount.Name = "cbaccount";
            this.cbaccount.Size = new System.Drawing.Size(178, 21);
            this.cbaccount.TabIndex = 36;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label30.Location = new System.Drawing.Point(9, 255);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(122, 19);
            this.label30.TabIndex = 35;
            this.label30.Text = "Loại tài khoản:";
            // 
            // taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.cbaccount);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.txtAccountKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnhuybo);
            this.Controls.Add(this.btnghidulieu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lblloi);
            this.Controls.Add(this.lblthanhcong);
            this.Controls.Add(this.lbltongso);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Name = "taikhoan";
            this.Text = "taikhoan";
            this.Load += new System.EventHandler(this.taikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccountKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Button btnghidulieu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Label lblloi;
        private System.Windows.Forms.Label lblthanhcong;
        private System.Windows.Forms.Label lbltongso;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cbaccount;
        private System.Windows.Forms.Label label30;
    }
}