namespace QuanLyCuaHang
{
    partial class frmSuaSanPham
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbLoaiSP = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtHangSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataKho = new System.Windows.Forms.DataGridView();
            this.cMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataKho)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "SỬA SẢN PHẨM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.cbLoaiSP);
            this.panel1.Controls.Add(this.btnXacNhan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenSP);
            this.panel1.Controls.Add(this.txtHangSP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDonGia);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 97);
            this.panel1.TabIndex = 22;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(356, 63);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbLoaiSP
            // 
            this.cbLoaiSP.FormattingEnabled = true;
            this.cbLoaiSP.Location = new System.Drawing.Point(492, 5);
            this.cbLoaiSP.Name = "cbLoaiSP";
            this.cbLoaiSP.Size = new System.Drawing.Size(117, 21);
            this.cbLoaiSP.TabIndex = 11;
            this.cbLoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbLoaiSP_SelectedIndexChanged);
            this.cbLoaiSP.Click += new System.EventHandler(this.cbLoaiSP_Click);
            this.cbLoaiSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLoaiSP_KeyPress);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(248, 63);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hãng ";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(196, 5);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(100, 20);
            this.txtTenSP.TabIndex = 7;
            // 
            // txtHangSP
            // 
            this.txtHangSP.Location = new System.Drawing.Point(196, 37);
            this.txtHangSP.Name = "txtHangSP";
            this.txtHangSP.Size = new System.Drawing.Size(100, 20);
            this.txtHangSP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại Sản Phẩm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn Giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(492, 37);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(117, 20);
            this.txtDonGia.TabIndex = 10;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataKho);
            this.panel3.Location = new System.Drawing.Point(1, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 226);
            this.panel3.TabIndex = 24;
            // 
            // dataKho
            // 
            this.dataKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaMH,
            this.cTenSP,
            this.cSize,
            this.cMau,
            this.cSoLuong});
            this.dataKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKho.Location = new System.Drawing.Point(0, 0);
            this.dataKho.Name = "dataKho";
            this.dataKho.Size = new System.Drawing.Size(722, 226);
            this.dataKho.TabIndex = 0;
            // 
            // cMaMH
            // 
            this.cMaMH.DataPropertyName = "maMH";
            this.cMaMH.HeaderText = "Mã Mặt Hàng";
            this.cMaMH.Name = "cMaMH";
            this.cMaMH.ReadOnly = true;
            // 
            // cTenSP
            // 
            this.cTenSP.DataPropertyName = "tenSP";
            this.cTenSP.HeaderText = "Tên Sản Phẩm";
            this.cTenSP.Name = "cTenSP";
            this.cTenSP.ReadOnly = true;
            // 
            // cSize
            // 
            this.cSize.DataPropertyName = "size";
            this.cSize.HeaderText = "Size";
            this.cSize.Name = "cSize";
            this.cSize.ReadOnly = true;
            // 
            // cMau
            // 
            this.cMau.DataPropertyName = "mau";
            this.cMau.HeaderText = "Màu";
            this.cMau.Name = "cMau";
            this.cMau.ReadOnly = true;
            // 
            // cSoLuong
            // 
            this.cSoLuong.DataPropertyName = "slSP";
            this.cSoLuong.HeaderText = "Số Lượng";
            this.cSoLuong.Name = "cSoLuong";
            this.cSoLuong.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "KHO SẢN PHẨM";
            // 
            // frmSuaSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 424);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Name = "frmSuaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmSuaSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataKho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLoaiSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtHangSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMau;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
    }
}