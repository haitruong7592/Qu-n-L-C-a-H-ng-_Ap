namespace QuanLyCuaHang
{
    partial class frmThemNguoiDung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenND = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cbVaiTro = new System.Windows.Forms.ComboBox();
            this.datTimeNgayLam = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rBtnNam = new System.Windows.Forms.RadioButton();
            this.rBtnNu = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Người Dùng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới Tính";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Sinh";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Làm";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Vai Trò";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tài Khoản";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mật Khẩu";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(230, 405);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 8;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(311, 405);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenND
            // 
            this.txtTenND.Location = new System.Drawing.Point(156, 83);
            this.txtTenND.Name = "txtTenND";
            this.txtTenND.Size = new System.Drawing.Size(196, 20);
            this.txtTenND.TabIndex = 11;
            this.txtTenND.TextChanged += new System.EventHandler(this.txtTenND_TextChanged);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(156, 281);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(196, 20);
            this.txtTaiKhoan.TabIndex = 12;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(156, 320);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(196, 20);
            this.txtMatKhau.TabIndex = 13;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.FormattingEnabled = true;
            this.cbVaiTro.Location = new System.Drawing.Point(156, 239);
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(196, 21);
            this.cbVaiTro.TabIndex = 14;
            this.cbVaiTro.SelectedIndexChanged += new System.EventHandler(this.cbVaiTro_SelectedIndexChanged);
            // 
            // datTimeNgayLam
            // 
            this.datTimeNgayLam.CustomFormat = "dd/MM/yyyy";
            this.datTimeNgayLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datTimeNgayLam.Location = new System.Drawing.Point(156, 194);
            this.datTimeNgayLam.Name = "datTimeNgayLam";
            this.datTimeNgayLam.Size = new System.Drawing.Size(196, 20);
            this.datTimeNgayLam.TabIndex = 15;
            this.datTimeNgayLam.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimeNgaySinh
            // 
            this.dateTimeNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgaySinh.Location = new System.Drawing.Point(156, 151);
            this.dateTimeNgaySinh.Name = "dateTimeNgaySinh";
            this.dateTimeNgaySinh.Size = new System.Drawing.Size(196, 20);
            this.dateTimeNgaySinh.TabIndex = 16;
            this.dateTimeNgaySinh.Value = new System.DateTime(2017, 12, 19, 18, 10, 59, 0);
            this.dateTimeNgaySinh.ValueChanged += new System.EventHandler(this.dateTimeNgaySinh_ValueChanged);
            // 
            // rBtnNam
            // 
            this.rBtnNam.AutoSize = true;
            this.rBtnNam.Location = new System.Drawing.Point(156, 109);
            this.rBtnNam.Name = "rBtnNam";
            this.rBtnNam.Size = new System.Drawing.Size(47, 17);
            this.rBtnNam.TabIndex = 17;
            this.rBtnNam.TabStop = true;
            this.rBtnNam.Text = "Nam";
            this.rBtnNam.UseVisualStyleBackColor = true;
            this.rBtnNam.CheckedChanged += new System.EventHandler(this.rBtnNam_CheckedChanged);
            // 
            // rBtnNu
            // 
            this.rBtnNu.AutoSize = true;
            this.rBtnNu.Location = new System.Drawing.Point(229, 109);
            this.rBtnNu.Name = "rBtnNu";
            this.rBtnNu.Size = new System.Drawing.Size(39, 17);
            this.rBtnNu.TabIndex = 18;
            this.rBtnNu.TabStop = true;
            this.rBtnNu.Text = "Nữ";
            this.rBtnNu.UseVisualStyleBackColor = true;
            this.rBtnNu.CheckedChanged += new System.EventHandler(this.rBtnNu_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(143, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "THÊM NGƯỜI DÙNG";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(156, 358);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(196, 20);
            this.txtGhiChu.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ghi Chú";
            // 
            // frmThemNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 469);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rBtnNu);
            this.Controls.Add(this.rBtnNam);
            this.Controls.Add(this.dateTimeNgaySinh);
            this.Controls.Add(this.datTimeNgayLam);
            this.Controls.Add(this.cbVaiTro);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.txtTenND);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmThemNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThemNguoiDung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenND;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cbVaiTro;
        private System.Windows.Forms.DateTimePicker datTimeNgayLam;
        private System.Windows.Forms.DateTimePicker dateTimeNgaySinh;
        private System.Windows.Forms.RadioButton rBtnNam;
        private System.Windows.Forms.RadioButton rBtnNu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
    }
}