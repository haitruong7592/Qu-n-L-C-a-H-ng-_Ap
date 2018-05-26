namespace QuanLyCuaHang
{
    partial class frmThemHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.cbNhanVien = new System.Windows.Forms.ComboBox();
            this.dataNgayHD = new System.Windows.Forms.DateTimePicker();
            this.txtSDTKH = new System.Windows.Forms.TextBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnTaoIn = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataThemMH = new System.Windows.Forms.DataGridView();
            this.cMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMauSac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDongGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbMaMatHang = new System.Windows.Forms.ComboBox();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThemMH)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM HÓA ĐƠN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtKhachHang);
            this.panel1.Controls.Add(this.cbNhanVien);
            this.panel1.Controls.Add(this.dataNgayHD);
            this.panel1.Controls.Add(this.txtSDTKH);
            this.panel1.Controls.Add(this.btnThemMoi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(814, 92);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(559, 63);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.Size = new System.Drawing.Size(100, 20);
            this.txtKhachHang.TabIndex = 19;
            // 
            // cbNhanVien
            // 
            this.cbNhanVien.FormattingEnabled = true;
            this.cbNhanVien.Location = new System.Drawing.Point(142, 37);
            this.cbNhanVien.Name = "cbNhanVien";
            this.cbNhanVien.Size = new System.Drawing.Size(100, 21);
            this.cbNhanVien.TabIndex = 18;
            // 
            // dataNgayHD
            // 
            this.dataNgayHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNgayHD.Location = new System.Drawing.Point(142, 63);
            this.dataNgayHD.Name = "dataNgayHD";
            this.dataNgayHD.Size = new System.Drawing.Size(100, 20);
            this.dataNgayHD.TabIndex = 17;
            // 
            // txtSDTKH
            // 
            this.txtSDTKH.Location = new System.Drawing.Point(559, 37);
            this.txtSDTKH.Name = "txtSDTKH";
            this.txtSDTKH.Size = new System.Drawing.Size(100, 20);
            this.txtSDTKH.TabIndex = 13;
            this.txtSDTKH.TextChanged += new System.EventHandler(this.txtSDTKH_TextChanged);
            this.txtSDTKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDTKH_KeyPress);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(702, 35);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 10;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "hoặc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(456, 7);
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(55, 20);
            this.numSoLuong.TabIndex = 16;
            this.numSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(384, 41);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Hủy";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(303, 41);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Lượng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Mặt Hàng";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.Location = new System.Drawing.Point(626, 436);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(75, 23);
            this.btnTaoMoi.TabIndex = 3;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.UseVisualStyleBackColor = true;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnTaoIn
            // 
            this.btnTaoIn.Location = new System.Drawing.Point(718, 436);
            this.btnTaoIn.Name = "btnTaoIn";
            this.btnTaoIn.Size = new System.Drawing.Size(83, 23);
            this.btnTaoIn.TabIndex = 4;
            this.btnTaoIn.Text = "Tạo Mới Và In";
            this.btnTaoIn.UseVisualStyleBackColor = true;
            this.btnTaoIn.Click += new System.EventHandler(this.btnTaoIn_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(534, 436);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtTongTien.Location = new System.Drawing.Point(667, 399);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(125, 20);
            this.txtTongTien.TabIndex = 12;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataThemMH);
            this.panel2.Location = new System.Drawing.Point(-1, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(814, 219);
            this.panel2.TabIndex = 13;
            // 
            // dataThemMH
            // 
            this.dataThemMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataThemMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThemMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaMH,
            this.cTenSanPham,
            this.cSize,
            this.cMauSac,
            this.cSoLuong,
            this.cDongGia,
            this.cThanhTien});
            this.dataThemMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataThemMH.Location = new System.Drawing.Point(0, 0);
            this.dataThemMH.Name = "dataThemMH";
            this.dataThemMH.Size = new System.Drawing.Size(814, 219);
            this.dataThemMH.TabIndex = 0;
            this.dataThemMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThemMH_CellContentClick);
            this.dataThemMH.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataThemMH_CellValueChanged);
            this.dataThemMH.SelectionChanged += new System.EventHandler(this.dataThemMH_SelectionChanged);
            this.dataThemMH.TabIndexChanged += new System.EventHandler(this.dataThemMH_TabIndexChanged);
            this.dataThemMH.VisibleChanged += new System.EventHandler(this.dataThemMH_VisibleChanged);
            // 
            // cMaMH
            // 
            this.cMaMH.DataPropertyName = "maMH";
            dataGridViewCellStyle9.NullValue = null;
            this.cMaMH.DefaultCellStyle = dataGridViewCellStyle9;
            this.cMaMH.HeaderText = "Mã Mặt Hàng";
            this.cMaMH.Name = "cMaMH";
            this.cMaMH.ReadOnly = true;
            // 
            // cTenSanPham
            // 
            this.cTenSanPham.DataPropertyName = "tenSP";
            this.cTenSanPham.HeaderText = "Tên Sản Phẩm";
            this.cTenSanPham.Name = "cTenSanPham";
            this.cTenSanPham.ReadOnly = true;
            // 
            // cSize
            // 
            this.cSize.DataPropertyName = "size";
            this.cSize.HeaderText = "Size";
            this.cSize.Name = "cSize";
            this.cSize.ReadOnly = true;
            // 
            // cMauSac
            // 
            this.cMauSac.DataPropertyName = "mau";
            this.cMauSac.HeaderText = "Màu Sắc";
            this.cMauSac.Name = "cMauSac";
            this.cMauSac.ReadOnly = true;
            // 
            // cSoLuong
            // 
            this.cSoLuong.DataPropertyName = "soluong";
            dataGridViewCellStyle10.Format = "N2";
            dataGridViewCellStyle10.NullValue = null;
            this.cSoLuong.DefaultCellStyle = dataGridViewCellStyle10;
            this.cSoLuong.HeaderText = "Số Lượng";
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.ReadOnly = true;
            // 
            // cDongGia
            // 
            this.cDongGia.DataPropertyName = "dongiaSP";
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            this.cDongGia.DefaultCellStyle = dataGridViewCellStyle11;
            this.cDongGia.HeaderText = "Đơn Giá";
            this.cDongGia.Name = "cDongGia";
            this.cDongGia.ReadOnly = true;
            // 
            // cThanhTien
            // 
            this.cThanhTien.DataPropertyName = "dongia";
            dataGridViewCellStyle12.Format = "N2";
            dataGridViewCellStyle12.NullValue = null;
            this.cThanhTien.DefaultCellStyle = dataGridViewCellStyle12;
            this.cThanhTien.HeaderText = "Thành Tiền";
            this.cThanhTien.Name = "cThanhTien";
            this.cThanhTien.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbMaMatHang);
            this.panel3.Controls.Add(this.numSoLuong);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(-1, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 78);
            this.panel3.TabIndex = 14;
            // 
            // cbMaMatHang
            // 
            this.cbMaMatHang.FormattingEnabled = true;
            this.cbMaMatHang.Location = new System.Drawing.Point(290, 7);
            this.cbMaMatHang.Name = "cbMaMatHang";
            this.cbMaMatHang.Size = new System.Drawing.Size(100, 21);
            this.cbMaMatHang.TabIndex = 19;
            // 
            // btnTongTien
            // 
            this.btnTongTien.Location = new System.Drawing.Point(574, 399);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(75, 23);
            this.btnTongTien.TabIndex = 15;
            this.btnTongTien.Text = "Tổng Tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // frmThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 478);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTaoIn);
            this.Controls.Add(this.btnTaoMoi);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThemHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataThemMH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnTaoIn;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.TextBox txtSDTKH;
        private System.Windows.Forms.DateTimePicker dataNgayHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataThemMH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbNhanVien;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.ComboBox cbMaMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMauSac;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDongGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cThanhTien;
        private System.Windows.Forms.Button btnTongTien;
    }
}