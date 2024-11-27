namespace QLNHANVIENNET
{
    partial class frmchucvu
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
            this.dgvChucVu = new System.Windows.Forms.DataGridView();
            this.lbltongso = new System.Windows.Forms.Label();
            this.lblthanhcong = new System.Windows.Forms.Label();
            this.lblloi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDChucVu = new System.Windows.Forms.TextBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenChucVu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnghidulieu = new System.Windows.Forms.Button();
            this.btnhuybo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChucVu
            // 
            this.dgvChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChucVu.Location = new System.Drawing.Point(8, 83);
            this.dgvChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChucVu.Name = "dgvChucVu";
            this.dgvChucVu.RowHeadersWidth = 51;
            this.dgvChucVu.RowTemplate.Height = 24;
            this.dgvChucVu.Size = new System.Drawing.Size(618, 122);
            this.dgvChucVu.TabIndex = 0;
            this.dgvChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChucVu_CellContentClick);
            // 
            // lbltongso
            // 
            this.lbltongso.AutoSize = true;
            this.lbltongso.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltongso.Location = new System.Drawing.Point(8, 47);
            this.lbltongso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltongso.Name = "lbltongso";
            this.lbltongso.Size = new System.Drawing.Size(126, 17);
            this.lbltongso.TabIndex = 1;
            this.lbltongso.Text = "Tổng số : 0 Bản ghi";
            // 
            // lblthanhcong
            // 
            this.lblthanhcong.AutoSize = true;
            this.lblthanhcong.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthanhcong.Location = new System.Drawing.Point(341, 47);
            this.lblthanhcong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblthanhcong.Name = "lblthanhcong";
            this.lblthanhcong.Size = new System.Drawing.Size(83, 17);
            this.lblthanhcong.TabIndex = 2;
            this.lblthanhcong.Text = "Thành Công";
            // 
            // lblloi
            // 
            this.lblloi.AutoSize = true;
            this.lblloi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloi.ForeColor = System.Drawing.Color.Red;
            this.lblloi.Location = new System.Drawing.Point(218, 47);
            this.lblloi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloi.Name = "lblloi";
            this.lblloi.Size = new System.Drawing.Size(28, 17);
            this.lblloi.TabIndex = 3;
            this.lblloi.Text = "Lỗi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Chức Vụ :";
            // 
            // txtIDChucVu
            // 
            this.txtIDChucVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDChucVu.Location = new System.Drawing.Point(98, 225);
            this.txtIDChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDChucVu.Name = "txtIDChucVu";
            this.txtIDChucVu.Size = new System.Drawing.Size(188, 23);
            this.txtIDChucVu.TabIndex = 1;
            this.txtIDChucVu.TextChanged += new System.EventHandler(this.txtIDChucVu_TextChanged);
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaChucVu.Location = new System.Drawing.Point(439, 225);
            this.txtMaChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(188, 23);
            this.txtMaChucVu.TabIndex = 2;
            this.txtMaChucVu.TextChanged += new System.EventHandler(this.txtMaChucVu_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Chức Vụ :";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(98, 297);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(529, 79);
            this.txtGhiChu.TabIndex = 4;
            this.txtGhiChu.TextChanged += new System.EventHandler(this.txtGhiChu_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ghi Chú :";
            // 
            // txtTenChucVu
            // 
            this.txtTenChucVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenChucVu.Location = new System.Drawing.Point(98, 263);
            this.txtTenChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenChucVu.Name = "txtTenChucVu";
            this.txtTenChucVu.Size = new System.Drawing.Size(529, 23);
            this.txtTenChucVu.TabIndex = 3;
            this.txtTenChucVu.TextChanged += new System.EventHandler(this.txtTenChucVu_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Chức Vụ :";
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(98, 406);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(64, 31);
            this.btnthem.TabIndex = 5;
            this.btnthem.Text = "Thêm ";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(186, 406);
            this.btnsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(64, 31);
            this.btnsua.TabIndex = 6;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(280, 406);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(64, 31);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnghidulieu
            // 
            this.btnghidulieu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnghidulieu.Location = new System.Drawing.Point(372, 406);
            this.btnghidulieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnghidulieu.Name = "btnghidulieu";
            this.btnghidulieu.Size = new System.Drawing.Size(108, 31);
            this.btnghidulieu.TabIndex = 8;
            this.btnghidulieu.Text = "Ghi dữ liệu";
            this.btnghidulieu.UseVisualStyleBackColor = true;
            // 
            // btnhuybo
            // 
            this.btnhuybo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuybo.Location = new System.Drawing.Point(502, 406);
            this.btnhuybo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhuybo.Name = "btnhuybo";
            this.btnhuybo.Size = new System.Drawing.Size(64, 31);
            this.btnhuybo.TabIndex = 9;
            this.btnhuybo.Text = "Hủy Bỏ";
            this.btnhuybo.UseVisualStyleBackColor = true;
            this.btnhuybo.Click += new System.EventHandler(this.btnhuybo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tìm Kiếm :";
            // 
            // txtkeyword
            // 
            this.txtkeyword.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkeyword.Location = new System.Drawing.Point(98, 16);
            this.txtkeyword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtkeyword.Name = "txtkeyword";
            this.txtkeyword.Size = new System.Drawing.Size(318, 23);
            this.txtkeyword.TabIndex = 11;
            this.txtkeyword.TextChanged += new System.EventHandler(this.txtkeyword_TextChanged);
            // 
            // frmchucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.txtkeyword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnhuybo);
            this.Controls.Add(this.btnghidulieu);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txtTenChucVu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaChucVu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDChucVu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblloi);
            this.Controls.Add(this.lblthanhcong);
            this.Controls.Add(this.lbltongso);
            this.Controls.Add(this.dgvChucVu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmchucvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.frmchucvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChucVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChucVu;
        private System.Windows.Forms.Label lbltongso;
        private System.Windows.Forms.Label lblthanhcong;
        private System.Windows.Forms.Label lblloi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenChucVu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnghidulieu;
        private System.Windows.Forms.Button btnhuybo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkeyword;
    }
}