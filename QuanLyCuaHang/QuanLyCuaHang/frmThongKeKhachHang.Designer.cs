namespace QuanLyCuaHang
{
    partial class frmThongKeKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataThongKeKH = new System.Windows.Forms.DataGridView();
            this.cMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKeKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnXem);
            this.panel1.Controls.Add(this.txtNam);
            this.panel1.Controls.Add(this.txtThang);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 428);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ THEO KHÁCH HÀNG";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(612, 127);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 13;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(612, 101);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(100, 20);
            this.txtNam.TabIndex = 12;
            this.txtNam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNam_KeyPress);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(430, 101);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(100, 20);
            this.txtThang.TabIndex = 11;
            this.txtThang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThang_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(548, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Nhập Năm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(346, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Nhập Tháng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataThongKeKH);
            this.panel2.Location = new System.Drawing.Point(0, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 265);
            this.panel2.TabIndex = 14;
            // 
            // dataThongKeKH
            // 
            this.dataThongKeKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataThongKeKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThongKeKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMaKH,
            this.cTenKH,
            this.cSDT,
            this.cSL,
            this.cTongTien});
            this.dataThongKeKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataThongKeKH.Location = new System.Drawing.Point(0, 0);
            this.dataThongKeKH.Name = "dataThongKeKH";
            this.dataThongKeKH.Size = new System.Drawing.Size(730, 265);
            this.dataThongKeKH.TabIndex = 0;
            // 
            // cMaKH
            // 
            this.cMaKH.DataPropertyName = "maKH";
            this.cMaKH.HeaderText = "Mã Khách Hàng";
            this.cMaKH.Name = "cMaKH";
            this.cMaKH.ReadOnly = true;
            // 
            // cTenKH
            // 
            this.cTenKH.DataPropertyName = "tenKH";
            this.cTenKH.HeaderText = "Tên Khách Hàng";
            this.cTenKH.Name = "cTenKH";
            this.cTenKH.ReadOnly = true;
            // 
            // cSDT
            // 
            this.cSDT.DataPropertyName = "sdtKH";
            this.cSDT.HeaderText = "Số Điện Thoại";
            this.cSDT.Name = "cSDT";
            this.cSDT.ReadOnly = true;
            // 
            // cSL
            // 
            this.cSL.DataPropertyName = "sl";
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = null;
            this.cSL.DefaultCellStyle = dataGridViewCellStyle7;
            this.cSL.HeaderText = "Số Lượng";
            this.cSL.Name = "cSL";
            this.cSL.ReadOnly = true;
            // 
            // cTongTien
            // 
            this.cTongTien.DataPropertyName = "tongtien";
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = null;
            this.cTongTien.DefaultCellStyle = dataGridViewCellStyle8;
            this.cTongTien.HeaderText = "Tổng Tiền";
            this.cTongTien.Name = "cTongTien";
            this.cTongTien.ReadOnly = true;
            // 
            // frmThongKeKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 428);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmThongKeKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKeKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataThongKeKH;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTongTien;
    }
}