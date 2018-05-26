namespace QuanLyCuaHang
{
    partial class frmNguoiDung
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
            this.tnThem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataNguoiDung = new System.Windows.Forms.DataGridView();
            this.cMaND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayVL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // tnThem
            // 
            this.tnThem.Location = new System.Drawing.Point(279, 46);
            this.tnThem.Name = "tnThem";
            this.tnThem.Size = new System.Drawing.Size(75, 23);
            this.tnThem.TabIndex = 0;
            this.tnThem.Text = "Thêm";
            this.tnThem.UseVisualStyleBackColor = true;
            this.tnThem.Click += new System.EventHandler(this.tnThem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(506, 46);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(397, 46);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.tnThem);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 88);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "NGƯỜI DÙNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataNguoiDung);
            this.panel2.Location = new System.Drawing.Point(-1, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(862, 358);
            this.panel2.TabIndex = 5;
            // 
            // dataNguoiDung
            // 
            this.dataNguoiDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaND,
            this.cTenND,
            this.cGioiTinh,
            this.cNgaySinh,
            this.cNgayVL,
            this.cVaiTro});
            this.dataNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataNguoiDung.Location = new System.Drawing.Point(0, 0);
            this.dataNguoiDung.Name = "dataNguoiDung";
            this.dataNguoiDung.Size = new System.Drawing.Size(862, 358);
            this.dataNguoiDung.TabIndex = 0;
            this.dataNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataNguoiDung.DoubleClick += new System.EventHandler(this.dataNguoiDung_DoubleClick);
            // 
            // cMaND
            // 
            this.cMaND.DataPropertyName = "maND";
            this.cMaND.HeaderText = "Mã Người Dùng";
            this.cMaND.Name = "cMaND";
            this.cMaND.ReadOnly = true;
            // 
            // cTenND
            // 
            this.cTenND.DataPropertyName = "tenND";
            this.cTenND.HeaderText = "Tên Người Dùng";
            this.cTenND.Name = "cTenND";
            this.cTenND.ReadOnly = true;
            // 
            // cGioiTinh
            // 
            this.cGioiTinh.DataPropertyName = "gioitinhND";
            this.cGioiTinh.HeaderText = "Giới Tính";
            this.cGioiTinh.Name = "cGioiTinh";
            this.cGioiTinh.ReadOnly = true;
            // 
            // cNgaySinh
            // 
            this.cNgaySinh.DataPropertyName = "ngaysinhND";
            this.cNgaySinh.HeaderText = "Ngày Sinh";
            this.cNgaySinh.Name = "cNgaySinh";
            this.cNgaySinh.ReadOnly = true;
            // 
            // cNgayVL
            // 
            this.cNgayVL.DataPropertyName = "ngaylam";
            this.cNgayVL.HeaderText = "Ngày Vào Làm";
            this.cNgayVL.Name = "cNgayVL";
            this.cNgayVL.ReadOnly = true;
            // 
            // cVaiTro
            // 
            this.cVaiTro.DataPropertyName = "tenVT";
            this.cVaiTro.HeaderText = "Vai Trò";
            this.cVaiTro.Name = "cVaiTro";
            this.cVaiTro.ReadOnly = true;
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Name = "frmNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataNguoiDung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tnThem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaND;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenND;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayVL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVaiTro;
    }
}