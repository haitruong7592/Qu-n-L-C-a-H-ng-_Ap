namespace QuanLyCuaHang
{
    partial class frmKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataKhachHang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbTimKiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTimKiem);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 112);
            this.panel1.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(381, 71);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(274, 71);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataKhachHang);
            this.panel2.Location = new System.Drawing.Point(0, 157);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 274);
            this.panel2.TabIndex = 2;
            // 
            // dataKhachHang
            // 
            this.dataKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaKH,
            this.cTenKH,
            this.cLoaiKH,
            this.cGioiTinh,
            this.cSDT,
            this.cNgaySinh,
            this.cEmail,
            this.cDiaChi,
            this.cGhiChu});
            this.dataKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKhachHang.Location = new System.Drawing.Point(0, 0);
            this.dataKhachHang.Name = "dataKhachHang";
            this.dataKhachHang.Size = new System.Drawing.Size(867, 274);
            this.dataKhachHang.TabIndex = 0;
            this.dataKhachHang.DoubleClick += new System.EventHandler(this.dataKhachHang_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "KHÁCH HÀNG\r\n";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(490, 71);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbTimKiem
            // 
            this.cbTimKiem.AutoCompleteCustomSource.AddRange(new string[] {
            "tenKH",
            "tenLKH"});
            this.cbTimKiem.FormattingEnabled = true;
            this.cbTimKiem.Items.AddRange(new object[] {
            "Tên Khách Hàng",
            "Loại Khách Hàng"});
            this.cbTimKiem.Location = new System.Drawing.Point(552, 18);
            this.cbTimKiem.Name = "cbTimKiem";
            this.cbTimKiem.Size = new System.Drawing.Size(92, 21);
            this.cbTimKiem.TabIndex = 16;
            this.cbTimKiem.Text = "Tìm Theo";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(784, 16);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 15;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(664, 18);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(100, 20);
            this.txtTimKiem.TabIndex = 14;
            this.txtTimKiem.Text = "Nhập Từ Khóa";
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cMaKH
            // 
            this.cMaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cMaKH.DataPropertyName = "maKH";
            this.cMaKH.Frozen = true;
            this.cMaKH.HeaderText = "Mã Khách Hàng";
            this.cMaKH.Name = "cMaKH";
            this.cMaKH.ReadOnly = true;
            this.cMaKH.Width = 92;
            // 
            // cTenKH
            // 
            this.cTenKH.DataPropertyName = "tenKH";
            this.cTenKH.HeaderText = "Tên Khách Hàng";
            this.cTenKH.Name = "cTenKH";
            this.cTenKH.ReadOnly = true;
            // 
            // cLoaiKH
            // 
            this.cLoaiKH.DataPropertyName = "tenLKH";
            this.cLoaiKH.HeaderText = "Loại Khách Hàng";
            this.cLoaiKH.Name = "cLoaiKH";
            this.cLoaiKH.ReadOnly = true;
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.DataPropertyName = "phaiKH";
            this.cGioiTinh.HeaderText = "Giới Tính";
            this.cGioiTinh.Name = "cGioiTinh";
            this.cGioiTinh.ReadOnly = true;
            // 
            // cSDT
            // 
            this.cSDT.DataPropertyName = "sdtKH";
            this.cSDT.HeaderText = "Số Điện Thoại";
            this.cSDT.Name = "cSDT";
            this.cSDT.ReadOnly = true;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.DataPropertyName = "ngsinhKH";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.cNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.cNgaySinh.HeaderText = "Ngày Sinh";
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.ReadOnly = true;
            // 
            // cEmail
            // 
            this.cEmail.DataPropertyName = "emailKH";
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.ReadOnly = true;
            // 
            // cDiaChi
            // 
            this.cDiaChi.DataPropertyName = "diachiKH";
            this.cDiaChi.HeaderText = "Địa Chỉ";
            this.cDiaChi.Name = "cDiaChi";
            this.cDiaChi.ReadOnly = true;
            // 
            // cGhiChu
            // 
            this.cGhiChu.DataPropertyName = "ghichuKH";
            this.cGhiChu.HeaderText = "Ghi Chú";
            this.cGhiChu.Name = "cGhiChu";
            this.cGhiChu.ReadOnly = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.DoubleClick += new System.EventHandler(this.frmKhachHang_DoubleClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGhiChu;
    }
}